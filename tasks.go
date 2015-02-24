// +build slurp
package main

//This file will be only compiled along the project with slurp. So don't put any projec code here.
import (
	"github.com/omeid/slurp"
	"github.com/slurp-contrib/watch"
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
		filepath.Walk(".", func(path string, info os.FileInfo, err error) error {
			if path != "." && info.IsDir() {
				return filepath.SkipDir
			}
			if strings.HasSuffix(path, ".proto") {
				protocArgs = append(protocArgs, path)
			}
			return nil
		})
		cmd := exec.Command("protoc", protocArgs...)
		cmd.Stderr = os.Stderr
		cmd.Stdin = os.Stdin
		cmd.Stdout = os.Stdout
		return cmd.Run()
	})
	b.Task("proto-csharp", nil, func(c *slurp.C) error {
		//++
		return nil
	})
	b.Task("proto-doc", nil, func(c *slurp.C) error {
		//++
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