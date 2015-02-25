﻿// Classes and structures being serialized

// Generated by ProtocolBuffer
// - a pure c# code generation implementation of protocol buffers
// Report bugs to: https://silentorbit.com/protobuf/

// DO NOT EDIT
// This file will be overwritten when CodeGenerator is run.
// To make custom modifications, edit the .proto file and add //:external before the message line
// then write the code and the changes in a separate file.
using System;
using System.Collections.Generic;

namespace Tesla
{
	public partial class PlayerReference
	{
		public ulong ID { get; set; }

		public string DisplayName { get; set; }

	}

	public partial class PlayerInfo
	{
		public ulong ID { get; set; }

		public string DisplayName { get; set; }

	}

	public enum PlayerAuthenticationLevel
	{
		None = 0,
		Anonymous = 1,
		Member = 2,
		ProMember = 3,
		Mod = 21,
		Admin = 42,
	}


}