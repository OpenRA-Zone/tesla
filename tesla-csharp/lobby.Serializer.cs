﻿// This is the backend code for reading and writing

// Generated by ProtocolBuffer
// - a pure c# code generation implementation of protocol buffers
// Report bugs to: https://silentorbit.com/protobuf/

// DO NOT EDIT
// This file will be overwritten when CodeGenerator is run.
using System;
using System.IO;
using System.Text;
using System.Collections.Generic;

namespace Tesla
{
	[System.Serializable()]
	public partial class LobbyPlayerJoin
	{
		/// <summary>Helper: create a new instance to deserializing into</summary>
		public static LobbyPlayerJoin Deserialize(Stream stream)
		{
			LobbyPlayerJoin instance = new LobbyPlayerJoin();
			Deserialize(stream, instance);
			return instance;
		}

		/// <summary>Helper: create a new instance to deserializing into</summary>
		public static LobbyPlayerJoin DeserializeLengthDelimited(Stream stream)
		{
			LobbyPlayerJoin instance = new LobbyPlayerJoin();
			DeserializeLengthDelimited(stream, instance);
			return instance;
		}

		/// <summary>Helper: create a new instance to deserializing into</summary>
		public static LobbyPlayerJoin DeserializeLength(Stream stream, int length)
		{
			LobbyPlayerJoin instance = new LobbyPlayerJoin();
			DeserializeLength(stream, length, instance);
			return instance;
		}

		/// <summary>Helper: put the buffer into a MemoryStream and create a new instance to deserializing into</summary>
		public static LobbyPlayerJoin Deserialize(byte[] buffer)
		{
			LobbyPlayerJoin instance = new LobbyPlayerJoin();
			using (var ms = new MemoryStream(buffer))
				Deserialize(ms, instance);
			return instance;
		}

		/// <summary>Helper: put the buffer into a MemoryStream before deserializing</summary>
		public static Tesla.LobbyPlayerJoin Deserialize(byte[] buffer, Tesla.LobbyPlayerJoin instance)
		{
			using (var ms = new MemoryStream(buffer))
				Deserialize(ms, instance);
			return instance;
		}

		/// <summary>Takes the remaining content of the stream and deserialze it into the instance.</summary>
		public static Tesla.LobbyPlayerJoin Deserialize(Stream stream, Tesla.LobbyPlayerJoin instance)
		{
			while (true)
			{
				int keyByte = stream.ReadByte();
				if (keyByte == -1)
					break;
				// Optimized reading of known fields with field ID < 16
				switch (keyByte)
				{
					// Field 1 Varint
					case 8:
						instance.PlayerID = global::SilentOrbit.ProtocolBuffers.ProtocolParser.ReadUInt64(stream);
						continue;
					// Field 2 Varint
					case 16:
						instance.EventTime = (long)global::SilentOrbit.ProtocolBuffers.ProtocolParser.ReadUInt64(stream);
						continue;
				}

				var key = global::SilentOrbit.ProtocolBuffers.ProtocolParser.ReadKey((byte)keyByte, stream);

				// Reading field ID > 16 and unknown field ID/wire type combinations
				switch (key.Field)
				{
					case 0:
						throw new global::SilentOrbit.ProtocolBuffers.ProtocolBufferException("Invalid field id: 0, something went wrong in the stream");
					default:
						global::SilentOrbit.ProtocolBuffers.ProtocolParser.SkipKey(stream, key);
						break;
				}
			}

			return instance;
		}

		/// <summary>Read the VarInt length prefix and the given number of bytes from the stream and deserialze it into the instance.</summary>
		public static Tesla.LobbyPlayerJoin DeserializeLengthDelimited(Stream stream, Tesla.LobbyPlayerJoin instance)
		{
			long limit = global::SilentOrbit.ProtocolBuffers.ProtocolParser.ReadUInt32(stream);
			limit += stream.Position;
			while (true)
			{
				if (stream.Position >= limit)
				{
					if (stream.Position == limit)
						break;
					else
						throw new global::SilentOrbit.ProtocolBuffers.ProtocolBufferException("Read past max limit");
				}
				int keyByte = stream.ReadByte();
				if (keyByte == -1)
					throw new System.IO.EndOfStreamException();
				// Optimized reading of known fields with field ID < 16
				switch (keyByte)
				{
					// Field 1 Varint
					case 8:
						instance.PlayerID = global::SilentOrbit.ProtocolBuffers.ProtocolParser.ReadUInt64(stream);
						continue;
					// Field 2 Varint
					case 16:
						instance.EventTime = (long)global::SilentOrbit.ProtocolBuffers.ProtocolParser.ReadUInt64(stream);
						continue;
				}

				var key = global::SilentOrbit.ProtocolBuffers.ProtocolParser.ReadKey((byte)keyByte, stream);

				// Reading field ID > 16 and unknown field ID/wire type combinations
				switch (key.Field)
				{
					case 0:
						throw new global::SilentOrbit.ProtocolBuffers.ProtocolBufferException("Invalid field id: 0, something went wrong in the stream");
					default:
						global::SilentOrbit.ProtocolBuffers.ProtocolParser.SkipKey(stream, key);
						break;
				}
			}

			return instance;
		}

		/// <summary>Read the given number of bytes from the stream and deserialze it into the instance.</summary>
		public static Tesla.LobbyPlayerJoin DeserializeLength(Stream stream, int length, Tesla.LobbyPlayerJoin instance)
		{
			long limit = stream.Position + length;
			while (true)
			{
				if (stream.Position >= limit)
				{
					if (stream.Position == limit)
						break;
					else
						throw new global::SilentOrbit.ProtocolBuffers.ProtocolBufferException("Read past max limit");
				}
				int keyByte = stream.ReadByte();
				if (keyByte == -1)
					throw new System.IO.EndOfStreamException();
				// Optimized reading of known fields with field ID < 16
				switch (keyByte)
				{
					// Field 1 Varint
					case 8:
						instance.PlayerID = global::SilentOrbit.ProtocolBuffers.ProtocolParser.ReadUInt64(stream);
						continue;
					// Field 2 Varint
					case 16:
						instance.EventTime = (long)global::SilentOrbit.ProtocolBuffers.ProtocolParser.ReadUInt64(stream);
						continue;
				}

				var key = global::SilentOrbit.ProtocolBuffers.ProtocolParser.ReadKey((byte)keyByte, stream);

				// Reading field ID > 16 and unknown field ID/wire type combinations
				switch (key.Field)
				{
					case 0:
						throw new global::SilentOrbit.ProtocolBuffers.ProtocolBufferException("Invalid field id: 0, something went wrong in the stream");
					default:
						global::SilentOrbit.ProtocolBuffers.ProtocolParser.SkipKey(stream, key);
						break;
				}
			}

			return instance;
		}

		/// <summary>Serialize the instance into the stream</summary>
		public static void Serialize(Stream stream, LobbyPlayerJoin instance)
		{
			var msField = global::SilentOrbit.ProtocolBuffers.ProtocolParser.Stack.Pop();
			// Key for field: 1, Varint
			stream.WriteByte(8);
			global::SilentOrbit.ProtocolBuffers.ProtocolParser.WriteUInt64(stream, instance.PlayerID);
			// Key for field: 2, Varint
			stream.WriteByte(16);
			global::SilentOrbit.ProtocolBuffers.ProtocolParser.WriteUInt64(stream,(ulong)instance.EventTime);
			global::SilentOrbit.ProtocolBuffers.ProtocolParser.Stack.Push(msField);
		}

		/// <summary>Helper: Serialize into a MemoryStream and return its byte array</summary>
		public static byte[] SerializeToBytes(LobbyPlayerJoin instance)
		{
			using (var ms = new MemoryStream())
			{
				Serialize(ms, instance);
				return ms.ToArray();
			}
		}
		/// <summary>Helper: Serialize with a varint length prefix</summary>
		public static void SerializeLengthDelimited(Stream stream, LobbyPlayerJoin instance)
		{
			var data = SerializeToBytes(instance);
			global::SilentOrbit.ProtocolBuffers.ProtocolParser.WriteUInt32(stream, (uint)data.Length);
			stream.Write(data, 0, data.Length);
		}
	}

	[System.Serializable()]
	public partial class LobbyPlayerLeave
	{
		/// <summary>Helper: create a new instance to deserializing into</summary>
		public static LobbyPlayerLeave Deserialize(Stream stream)
		{
			LobbyPlayerLeave instance = new LobbyPlayerLeave();
			Deserialize(stream, instance);
			return instance;
		}

		/// <summary>Helper: create a new instance to deserializing into</summary>
		public static LobbyPlayerLeave DeserializeLengthDelimited(Stream stream)
		{
			LobbyPlayerLeave instance = new LobbyPlayerLeave();
			DeserializeLengthDelimited(stream, instance);
			return instance;
		}

		/// <summary>Helper: create a new instance to deserializing into</summary>
		public static LobbyPlayerLeave DeserializeLength(Stream stream, int length)
		{
			LobbyPlayerLeave instance = new LobbyPlayerLeave();
			DeserializeLength(stream, length, instance);
			return instance;
		}

		/// <summary>Helper: put the buffer into a MemoryStream and create a new instance to deserializing into</summary>
		public static LobbyPlayerLeave Deserialize(byte[] buffer)
		{
			LobbyPlayerLeave instance = new LobbyPlayerLeave();
			using (var ms = new MemoryStream(buffer))
				Deserialize(ms, instance);
			return instance;
		}

		/// <summary>Helper: put the buffer into a MemoryStream before deserializing</summary>
		public static Tesla.LobbyPlayerLeave Deserialize(byte[] buffer, Tesla.LobbyPlayerLeave instance)
		{
			using (var ms = new MemoryStream(buffer))
				Deserialize(ms, instance);
			return instance;
		}

		/// <summary>Takes the remaining content of the stream and deserialze it into the instance.</summary>
		public static Tesla.LobbyPlayerLeave Deserialize(Stream stream, Tesla.LobbyPlayerLeave instance)
		{
			while (true)
			{
				int keyByte = stream.ReadByte();
				if (keyByte == -1)
					break;
				// Optimized reading of known fields with field ID < 16
				switch (keyByte)
				{
					// Field 1 Varint
					case 8:
						instance.PlayerID = global::SilentOrbit.ProtocolBuffers.ProtocolParser.ReadUInt64(stream);
						continue;
					// Field 2 Varint
					case 16:
						instance.EventTime = (long)global::SilentOrbit.ProtocolBuffers.ProtocolParser.ReadUInt64(stream);
						continue;
				}

				var key = global::SilentOrbit.ProtocolBuffers.ProtocolParser.ReadKey((byte)keyByte, stream);

				// Reading field ID > 16 and unknown field ID/wire type combinations
				switch (key.Field)
				{
					case 0:
						throw new global::SilentOrbit.ProtocolBuffers.ProtocolBufferException("Invalid field id: 0, something went wrong in the stream");
					default:
						global::SilentOrbit.ProtocolBuffers.ProtocolParser.SkipKey(stream, key);
						break;
				}
			}

			return instance;
		}

		/// <summary>Read the VarInt length prefix and the given number of bytes from the stream and deserialze it into the instance.</summary>
		public static Tesla.LobbyPlayerLeave DeserializeLengthDelimited(Stream stream, Tesla.LobbyPlayerLeave instance)
		{
			long limit = global::SilentOrbit.ProtocolBuffers.ProtocolParser.ReadUInt32(stream);
			limit += stream.Position;
			while (true)
			{
				if (stream.Position >= limit)
				{
					if (stream.Position == limit)
						break;
					else
						throw new global::SilentOrbit.ProtocolBuffers.ProtocolBufferException("Read past max limit");
				}
				int keyByte = stream.ReadByte();
				if (keyByte == -1)
					throw new System.IO.EndOfStreamException();
				// Optimized reading of known fields with field ID < 16
				switch (keyByte)
				{
					// Field 1 Varint
					case 8:
						instance.PlayerID = global::SilentOrbit.ProtocolBuffers.ProtocolParser.ReadUInt64(stream);
						continue;
					// Field 2 Varint
					case 16:
						instance.EventTime = (long)global::SilentOrbit.ProtocolBuffers.ProtocolParser.ReadUInt64(stream);
						continue;
				}

				var key = global::SilentOrbit.ProtocolBuffers.ProtocolParser.ReadKey((byte)keyByte, stream);

				// Reading field ID > 16 and unknown field ID/wire type combinations
				switch (key.Field)
				{
					case 0:
						throw new global::SilentOrbit.ProtocolBuffers.ProtocolBufferException("Invalid field id: 0, something went wrong in the stream");
					default:
						global::SilentOrbit.ProtocolBuffers.ProtocolParser.SkipKey(stream, key);
						break;
				}
			}

			return instance;
		}

		/// <summary>Read the given number of bytes from the stream and deserialze it into the instance.</summary>
		public static Tesla.LobbyPlayerLeave DeserializeLength(Stream stream, int length, Tesla.LobbyPlayerLeave instance)
		{
			long limit = stream.Position + length;
			while (true)
			{
				if (stream.Position >= limit)
				{
					if (stream.Position == limit)
						break;
					else
						throw new global::SilentOrbit.ProtocolBuffers.ProtocolBufferException("Read past max limit");
				}
				int keyByte = stream.ReadByte();
				if (keyByte == -1)
					throw new System.IO.EndOfStreamException();
				// Optimized reading of known fields with field ID < 16
				switch (keyByte)
				{
					// Field 1 Varint
					case 8:
						instance.PlayerID = global::SilentOrbit.ProtocolBuffers.ProtocolParser.ReadUInt64(stream);
						continue;
					// Field 2 Varint
					case 16:
						instance.EventTime = (long)global::SilentOrbit.ProtocolBuffers.ProtocolParser.ReadUInt64(stream);
						continue;
				}

				var key = global::SilentOrbit.ProtocolBuffers.ProtocolParser.ReadKey((byte)keyByte, stream);

				// Reading field ID > 16 and unknown field ID/wire type combinations
				switch (key.Field)
				{
					case 0:
						throw new global::SilentOrbit.ProtocolBuffers.ProtocolBufferException("Invalid field id: 0, something went wrong in the stream");
					default:
						global::SilentOrbit.ProtocolBuffers.ProtocolParser.SkipKey(stream, key);
						break;
				}
			}

			return instance;
		}

		/// <summary>Serialize the instance into the stream</summary>
		public static void Serialize(Stream stream, LobbyPlayerLeave instance)
		{
			var msField = global::SilentOrbit.ProtocolBuffers.ProtocolParser.Stack.Pop();
			// Key for field: 1, Varint
			stream.WriteByte(8);
			global::SilentOrbit.ProtocolBuffers.ProtocolParser.WriteUInt64(stream, instance.PlayerID);
			// Key for field: 2, Varint
			stream.WriteByte(16);
			global::SilentOrbit.ProtocolBuffers.ProtocolParser.WriteUInt64(stream,(ulong)instance.EventTime);
			global::SilentOrbit.ProtocolBuffers.ProtocolParser.Stack.Push(msField);
		}

		/// <summary>Helper: Serialize into a MemoryStream and return its byte array</summary>
		public static byte[] SerializeToBytes(LobbyPlayerLeave instance)
		{
			using (var ms = new MemoryStream())
			{
				Serialize(ms, instance);
				return ms.ToArray();
			}
		}
		/// <summary>Helper: Serialize with a varint length prefix</summary>
		public static void SerializeLengthDelimited(Stream stream, LobbyPlayerLeave instance)
		{
			var data = SerializeToBytes(instance);
			global::SilentOrbit.ProtocolBuffers.ProtocolParser.WriteUInt32(stream, (uint)data.Length);
			stream.Write(data, 0, data.Length);
		}
	}

	[System.Serializable()]
	public partial class LobbyChatMessage
	{
		/// <summary>Helper: create a new instance to deserializing into</summary>
		public static LobbyChatMessage Deserialize(Stream stream)
		{
			LobbyChatMessage instance = new LobbyChatMessage();
			Deserialize(stream, instance);
			return instance;
		}

		/// <summary>Helper: create a new instance to deserializing into</summary>
		public static LobbyChatMessage DeserializeLengthDelimited(Stream stream)
		{
			LobbyChatMessage instance = new LobbyChatMessage();
			DeserializeLengthDelimited(stream, instance);
			return instance;
		}

		/// <summary>Helper: create a new instance to deserializing into</summary>
		public static LobbyChatMessage DeserializeLength(Stream stream, int length)
		{
			LobbyChatMessage instance = new LobbyChatMessage();
			DeserializeLength(stream, length, instance);
			return instance;
		}

		/// <summary>Helper: put the buffer into a MemoryStream and create a new instance to deserializing into</summary>
		public static LobbyChatMessage Deserialize(byte[] buffer)
		{
			LobbyChatMessage instance = new LobbyChatMessage();
			using (var ms = new MemoryStream(buffer))
				Deserialize(ms, instance);
			return instance;
		}

		/// <summary>Helper: put the buffer into a MemoryStream before deserializing</summary>
		public static Tesla.LobbyChatMessage Deserialize(byte[] buffer, Tesla.LobbyChatMessage instance)
		{
			using (var ms = new MemoryStream(buffer))
				Deserialize(ms, instance);
			return instance;
		}

		/// <summary>Takes the remaining content of the stream and deserialze it into the instance.</summary>
		public static Tesla.LobbyChatMessage Deserialize(Stream stream, Tesla.LobbyChatMessage instance)
		{
			while (true)
			{
				int keyByte = stream.ReadByte();
				if (keyByte == -1)
					break;
				// Optimized reading of known fields with field ID < 16
				switch (keyByte)
				{
					// Field 1 Varint
					case 8:
						instance.PlayerID = global::SilentOrbit.ProtocolBuffers.ProtocolParser.ReadUInt64(stream);
						continue;
					// Field 2 Varint
					case 16:
						instance.EventTime = (long)global::SilentOrbit.ProtocolBuffers.ProtocolParser.ReadUInt64(stream);
						continue;
					// Field 3 LengthDelimited
					case 26:
						instance.Text = global::SilentOrbit.ProtocolBuffers.ProtocolParser.ReadString(stream);
						continue;
					// Field 4 Varint
					case 32:
						instance.Target = (Tesla.LobbyChatMessage.MessageTarget)global::SilentOrbit.ProtocolBuffers.ProtocolParser.ReadUInt64(stream);
						continue;
				}

				var key = global::SilentOrbit.ProtocolBuffers.ProtocolParser.ReadKey((byte)keyByte, stream);

				// Reading field ID > 16 and unknown field ID/wire type combinations
				switch (key.Field)
				{
					case 0:
						throw new global::SilentOrbit.ProtocolBuffers.ProtocolBufferException("Invalid field id: 0, something went wrong in the stream");
					default:
						global::SilentOrbit.ProtocolBuffers.ProtocolParser.SkipKey(stream, key);
						break;
				}
			}

			return instance;
		}

		/// <summary>Read the VarInt length prefix and the given number of bytes from the stream and deserialze it into the instance.</summary>
		public static Tesla.LobbyChatMessage DeserializeLengthDelimited(Stream stream, Tesla.LobbyChatMessage instance)
		{
			long limit = global::SilentOrbit.ProtocolBuffers.ProtocolParser.ReadUInt32(stream);
			limit += stream.Position;
			while (true)
			{
				if (stream.Position >= limit)
				{
					if (stream.Position == limit)
						break;
					else
						throw new global::SilentOrbit.ProtocolBuffers.ProtocolBufferException("Read past max limit");
				}
				int keyByte = stream.ReadByte();
				if (keyByte == -1)
					throw new System.IO.EndOfStreamException();
				// Optimized reading of known fields with field ID < 16
				switch (keyByte)
				{
					// Field 1 Varint
					case 8:
						instance.PlayerID = global::SilentOrbit.ProtocolBuffers.ProtocolParser.ReadUInt64(stream);
						continue;
					// Field 2 Varint
					case 16:
						instance.EventTime = (long)global::SilentOrbit.ProtocolBuffers.ProtocolParser.ReadUInt64(stream);
						continue;
					// Field 3 LengthDelimited
					case 26:
						instance.Text = global::SilentOrbit.ProtocolBuffers.ProtocolParser.ReadString(stream);
						continue;
					// Field 4 Varint
					case 32:
						instance.Target = (Tesla.LobbyChatMessage.MessageTarget)global::SilentOrbit.ProtocolBuffers.ProtocolParser.ReadUInt64(stream);
						continue;
				}

				var key = global::SilentOrbit.ProtocolBuffers.ProtocolParser.ReadKey((byte)keyByte, stream);

				// Reading field ID > 16 and unknown field ID/wire type combinations
				switch (key.Field)
				{
					case 0:
						throw new global::SilentOrbit.ProtocolBuffers.ProtocolBufferException("Invalid field id: 0, something went wrong in the stream");
					default:
						global::SilentOrbit.ProtocolBuffers.ProtocolParser.SkipKey(stream, key);
						break;
				}
			}

			return instance;
		}

		/// <summary>Read the given number of bytes from the stream and deserialze it into the instance.</summary>
		public static Tesla.LobbyChatMessage DeserializeLength(Stream stream, int length, Tesla.LobbyChatMessage instance)
		{
			long limit = stream.Position + length;
			while (true)
			{
				if (stream.Position >= limit)
				{
					if (stream.Position == limit)
						break;
					else
						throw new global::SilentOrbit.ProtocolBuffers.ProtocolBufferException("Read past max limit");
				}
				int keyByte = stream.ReadByte();
				if (keyByte == -1)
					throw new System.IO.EndOfStreamException();
				// Optimized reading of known fields with field ID < 16
				switch (keyByte)
				{
					// Field 1 Varint
					case 8:
						instance.PlayerID = global::SilentOrbit.ProtocolBuffers.ProtocolParser.ReadUInt64(stream);
						continue;
					// Field 2 Varint
					case 16:
						instance.EventTime = (long)global::SilentOrbit.ProtocolBuffers.ProtocolParser.ReadUInt64(stream);
						continue;
					// Field 3 LengthDelimited
					case 26:
						instance.Text = global::SilentOrbit.ProtocolBuffers.ProtocolParser.ReadString(stream);
						continue;
					// Field 4 Varint
					case 32:
						instance.Target = (Tesla.LobbyChatMessage.MessageTarget)global::SilentOrbit.ProtocolBuffers.ProtocolParser.ReadUInt64(stream);
						continue;
				}

				var key = global::SilentOrbit.ProtocolBuffers.ProtocolParser.ReadKey((byte)keyByte, stream);

				// Reading field ID > 16 and unknown field ID/wire type combinations
				switch (key.Field)
				{
					case 0:
						throw new global::SilentOrbit.ProtocolBuffers.ProtocolBufferException("Invalid field id: 0, something went wrong in the stream");
					default:
						global::SilentOrbit.ProtocolBuffers.ProtocolParser.SkipKey(stream, key);
						break;
				}
			}

			return instance;
		}

		/// <summary>Serialize the instance into the stream</summary>
		public static void Serialize(Stream stream, LobbyChatMessage instance)
		{
			var msField = global::SilentOrbit.ProtocolBuffers.ProtocolParser.Stack.Pop();
			// Key for field: 1, Varint
			stream.WriteByte(8);
			global::SilentOrbit.ProtocolBuffers.ProtocolParser.WriteUInt64(stream, instance.PlayerID);
			// Key for field: 2, Varint
			stream.WriteByte(16);
			global::SilentOrbit.ProtocolBuffers.ProtocolParser.WriteUInt64(stream,(ulong)instance.EventTime);
			if (instance.Text == null)
				throw new ArgumentNullException("Text", "Required by proto specification.");
			// Key for field: 3, LengthDelimited
			stream.WriteByte(26);
			global::SilentOrbit.ProtocolBuffers.ProtocolParser.WriteBytes(stream, Encoding.UTF8.GetBytes(instance.Text));
			// Key for field: 4, Varint
			stream.WriteByte(32);
			global::SilentOrbit.ProtocolBuffers.ProtocolParser.WriteUInt64(stream,(ulong)instance.Target);
			global::SilentOrbit.ProtocolBuffers.ProtocolParser.Stack.Push(msField);
		}

		/// <summary>Helper: Serialize into a MemoryStream and return its byte array</summary>
		public static byte[] SerializeToBytes(LobbyChatMessage instance)
		{
			using (var ms = new MemoryStream())
			{
				Serialize(ms, instance);
				return ms.ToArray();
			}
		}
		/// <summary>Helper: Serialize with a varint length prefix</summary>
		public static void SerializeLengthDelimited(Stream stream, LobbyChatMessage instance)
		{
			var data = SerializeToBytes(instance);
			global::SilentOrbit.ProtocolBuffers.ProtocolParser.WriteUInt32(stream, (uint)data.Length);
			stream.Write(data, 0, data.Length);
		}
	}

}
