// +build slurp
package main

//This file will be only compiled along the project with slurp. So don't put any projec code here.
import (
	"bytes"
	"fmt"
	"github.com/omeid/slurp"
	"github.com/slurp-contrib/watch"
	"io"
	"os"
	"os/exec"
	"path/filepath"
	"strings"
)

// This function is called to allow registering the tasks when slurp is run.
func Slurp(b *slurp.Build) {

	// Watch stuff
	b.Task("watch", nil, func(c *slurp.C) error {
		b.Run(c, "proto-all")
		// watch the proto files
		watchProtoFiles := watch.Watch(c, func(string) {
			b.Run(c, "proto-all")
		}, "*.proto")

		// close all watchers on task exit
		b.Defer(func() {
			watchProtoFiles.Close()
		})

		// wait until task is forced to stop
		b.Wait()
		return nil
	})

	b.Task("proto-go", nil, func(c *slurp.C) error {
		var protocArgs = []string{"--go_out=./tesla-go"}
		protocArgs = findProtoFiles(protocArgs)
		cmd := exec.Command("protoc", protocArgs...)
		cmd.Stderr = os.Stderr
		cmd.Stdin = os.Stdin
		cmd.Stdout = os.Stdout
		return cmd.Run()
	})
	b.Task("proto-csharp", nil, func(c *slurp.C) error {
		wd, err := os.Getwd()
		if err != nil {
			return fmt.Errorf("error getting working dir: %v", err)
		}

		// inherit host environment, but suppress wine whining
		environment := os.Environ()
		environment = append(environment, "WINEDEBUG=-all")

		protoFiles := findProtoFiles(nil)
		for _, protoFile := range protoFiles {
			cmd := exec.Command("wine", "/opt/ProtoBuf-2014-08-23-bin/CodeGenerator.exe", "--use-tabs", protoFile, fmt.Sprintf(`--output=tesla-csharp/%s.cs`, strings.TrimSuffix(protoFile, ".proto")))
			cmd.Dir = wd
			cmd.Env = environment
			cmd.Stderr = os.Stderr
			cmd.Stdin = os.Stdin
			cmd.Stdout = os.Stdout
			err := cmd.Run()
			if err != nil {
				return err
			}
		}
		return nil
	})
	b.Task("proto-doc", nil, func(c *slurp.C) error {
		var protocArgs = []string{"--doc_out=markdown,/stdout:/dev"}
		protocArgs = findProtoFiles(protocArgs)
		cmd := exec.Command("protoc", protocArgs...)
		cmd.Stderr = os.Stderr
		cmd.Stdin = os.Stdin
		buf := &bytes.Buffer{}
		cmd.Stdout = buf
		err := cmd.Run()
		if err != nil {
			return err
		}

		mdFile, err := os.Create("../docs.openra.zone/content/tech/tesla-messages.md")
		if err != nil {
			return fmt.Errorf("error rewriting tesla-messages.md: %v", err)
		}
		defer mdFile.Close()
		io.WriteString(mdFile, `---
date: 2013-07-01
linktitle: Tesla messages
menu:
  main:
    parent: tech
notoc: notoc
title: Tesla messages
description: Message specifications for the Tesla protocol
weight: 81
---

`)
		io.Copy(mdFile, buf)
		mdFile.Sync()
		mdFile.Close()
		return nil
	})

	// b.Task("proto-all", []string{"proto-go", "proto-csharp", "proto-doc"}, func(c *slurp.C) error {
	// 	// run all proto generators
	// 	return nil
	// })

	b.Task("proto-all", nil, func(c *slurp.C) error {
		// run all proto generators
		b.Run(c, "proto-go")
		b.Run(c, "proto-csharp")
		b.Run(c, "proto-doc")
		return nil
	})

	// when running slurp with no args, the "default" task is run.
	b.Task("default", []string{"proto-all"}, func(c *slurp.C) error {
		return nil
	})
}

func findProtoFiles(list []string) []string {
	if list == nil {
		list = []string{}
	}
	filepath.Walk(".", func(path string, info os.FileInfo, err error) error {
		if path != "." && info.IsDir() {
			return filepath.SkipDir
		}
		if strings.HasSuffix(path, ".proto") {
			list = append(list, path)
		}
		return nil
	})
	return list
}
