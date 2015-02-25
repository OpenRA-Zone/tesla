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
	public partial class PlayerJoinRequest
	{
		/// <summary>Helper: create a new instance to deserializing into</summary>
		public static PlayerJoinRequest Deserialize(Stream stream)
		{
			PlayerJoinRequest instance = new PlayerJoinRequest();
			Deserialize(stream, instance);
			return instance;
		}

		/// <summary>Helper: create a new instance to deserializing into</summary>
		public static PlayerJoinRequest DeserializeLengthDelimited(Stream stream)
		{
			PlayerJoinRequest instance = new PlayerJoinRequest();
			DeserializeLengthDelimited(stream, instance);
			return instance;
		}

		/// <summary>Helper: create a new instance to deserializing into</summary>
		public static PlayerJoinRequest DeserializeLength(Stream stream, int length)
		{
			PlayerJoinRequest instance = new PlayerJoinRequest();
			DeserializeLength(stream, length, instance);
			return instance;
		}

		/// <summary>Helper: put the buffer into a MemoryStream and create a new instance to deserializing into</summary>
		public static PlayerJoinRequest Deserialize(byte[] buffer)
		{
			PlayerJoinRequest instance = new PlayerJoinRequest();
			using (var ms = new MemoryStream(buffer))
				Deserialize(ms, instance);
			return instance;
		}

		/// <summary>Helper: put the buffer into a MemoryStream before deserializing</summary>
		public static Tesla.PlayerJoinRequest Deserialize(byte[] buffer, Tesla.PlayerJoinRequest instance)
		{
			using (var ms = new MemoryStream(buffer))
				Deserialize(ms, instance);
			return instance;
		}

		/// <summary>Takes the remaining content of the stream and deserialze it into the instance.</summary>
		public static Tesla.PlayerJoinRequest Deserialize(Stream stream, Tesla.PlayerJoinRequest instance)
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
						instance.RequestID = global::SilentOrbit.ProtocolBuffers.ProtocolParser.ReadUInt64(stream);
						continue;
					// Field 2 Varint
					case 16:
						instance.PlayerID = global::SilentOrbit.ProtocolBuffers.ProtocolParser.ReadUInt64(stream);
						continue;
					// Field 3 LengthDelimited
					case 26:
						instance.AuthenticationHash = global::SilentOrbit.ProtocolBuffers.ProtocolParser.ReadBytes(stream);
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
		public static Tesla.PlayerJoinRequest DeserializeLengthDelimited(Stream stream, Tesla.PlayerJoinRequest instance)
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
						instance.RequestID = global::SilentOrbit.ProtocolBuffers.ProtocolParser.ReadUInt64(stream);
						continue;
					// Field 2 Varint
					case 16:
						instance.PlayerID = global::SilentOrbit.ProtocolBuffers.ProtocolParser.ReadUInt64(stream);
						continue;
					// Field 3 LengthDelimited
					case 26:
						instance.AuthenticationHash = global::SilentOrbit.ProtocolBuffers.ProtocolParser.ReadBytes(stream);
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
		public static Tesla.PlayerJoinRequest DeserializeLength(Stream stream, int length, Tesla.PlayerJoinRequest instance)
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
						instance.RequestID = global::SilentOrbit.ProtocolBuffers.ProtocolParser.ReadUInt64(stream);
						continue;
					// Field 2 Varint
					case 16:
						instance.PlayerID = global::SilentOrbit.ProtocolBuffers.ProtocolParser.ReadUInt64(stream);
						continue;
					// Field 3 LengthDelimited
					case 26:
						instance.AuthenticationHash = global::SilentOrbit.ProtocolBuffers.ProtocolParser.ReadBytes(stream);
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
		public static void Serialize(Stream stream, PlayerJoinRequest instance)
		{
			var msField = global::SilentOrbit.ProtocolBuffers.ProtocolParser.Stack.Pop();
			// Key for field: 1, Varint
			stream.WriteByte(8);
			global::SilentOrbit.ProtocolBuffers.ProtocolParser.WriteUInt64(stream, instance.RequestID);
			// Key for field: 2, Varint
			stream.WriteByte(16);
			global::SilentOrbit.ProtocolBuffers.ProtocolParser.WriteUInt64(stream, instance.PlayerID);
			if (instance.AuthenticationHash == null)
				throw new ArgumentNullException("AuthenticationHash", "Required by proto specification.");
			// Key for field: 3, LengthDelimited
			stream.WriteByte(26);
			global::SilentOrbit.ProtocolBuffers.ProtocolParser.WriteBytes(stream, instance.AuthenticationHash);
			global::SilentOrbit.ProtocolBuffers.ProtocolParser.Stack.Push(msField);
		}

		/// <summary>Helper: Serialize into a MemoryStream and return its byte array</summary>
		public static byte[] SerializeToBytes(PlayerJoinRequest instance)
		{
			using (var ms = new MemoryStream())
			{
				Serialize(ms, instance);
				return ms.ToArray();
			}
		}
		/// <summary>Helper: Serialize with a varint length prefix</summary>
		public static void SerializeLengthDelimited(Stream stream, PlayerJoinRequest instance)
		{
			var data = SerializeToBytes(instance);
			global::SilentOrbit.ProtocolBuffers.ProtocolParser.WriteUInt32(stream, (uint)data.Length);
			stream.Write(data, 0, data.Length);
		}
	}

	[System.Serializable()]
	public partial class PlayerJoinResponse
	{
		/// <summary>Helper: create a new instance to deserializing into</summary>
		public static PlayerJoinResponse Deserialize(Stream stream)
		{
			PlayerJoinResponse instance = new PlayerJoinResponse();
			Deserialize(stream, instance);
			return instance;
		}

		/// <summary>Helper: create a new instance to deserializing into</summary>
		public static PlayerJoinResponse DeserializeLengthDelimited(Stream stream)
		{
			PlayerJoinResponse instance = new PlayerJoinResponse();
			DeserializeLengthDelimited(stream, instance);
			return instance;
		}

		/// <summary>Helper: create a new instance to deserializing into</summary>
		public static PlayerJoinResponse DeserializeLength(Stream stream, int length)
		{
			PlayerJoinResponse instance = new PlayerJoinResponse();
			DeserializeLength(stream, length, instance);
			return instance;
		}

		/// <summary>Helper: put the buffer into a MemoryStream and create a new instance to deserializing into</summary>
		public static PlayerJoinResponse Deserialize(byte[] buffer)
		{
			PlayerJoinResponse instance = new PlayerJoinResponse();
			using (var ms = new MemoryStream(buffer))
				Deserialize(ms, instance);
			return instance;
		}

		/// <summary>Helper: put the buffer into a MemoryStream before deserializing</summary>
		public static Tesla.PlayerJoinResponse Deserialize(byte[] buffer, Tesla.PlayerJoinResponse instance)
		{
			using (var ms = new MemoryStream(buffer))
				Deserialize(ms, instance);
			return instance;
		}

		/// <summary>Takes the remaining content of the stream and deserialze it into the instance.</summary>
		public static Tesla.PlayerJoinResponse Deserialize(Stream stream, Tesla.PlayerJoinResponse instance)
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
						instance.RequestID = global::SilentOrbit.ProtocolBuffers.ProtocolParser.ReadUInt64(stream);
						continue;
					// Field 2 Varint
					case 16:
						instance.Valid = global::SilentOrbit.ProtocolBuffers.ProtocolParser.ReadBool(stream);
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
		public static Tesla.PlayerJoinResponse DeserializeLengthDelimited(Stream stream, Tesla.PlayerJoinResponse instance)
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
						instance.RequestID = global::SilentOrbit.ProtocolBuffers.ProtocolParser.ReadUInt64(stream);
						continue;
					// Field 2 Varint
					case 16:
						instance.Valid = global::SilentOrbit.ProtocolBuffers.ProtocolParser.ReadBool(stream);
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
		public static Tesla.PlayerJoinResponse DeserializeLength(Stream stream, int length, Tesla.PlayerJoinResponse instance)
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
						instance.RequestID = global::SilentOrbit.ProtocolBuffers.ProtocolParser.ReadUInt64(stream);
						continue;
					// Field 2 Varint
					case 16:
						instance.Valid = global::SilentOrbit.ProtocolBuffers.ProtocolParser.ReadBool(stream);
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
		public static void Serialize(Stream stream, PlayerJoinResponse instance)
		{
			var msField = global::SilentOrbit.ProtocolBuffers.ProtocolParser.Stack.Pop();
			// Key for field: 1, Varint
			stream.WriteByte(8);
			global::SilentOrbit.ProtocolBuffers.ProtocolParser.WriteUInt64(stream, instance.RequestID);
			// Key for field: 2, Varint
			stream.WriteByte(16);
			global::SilentOrbit.ProtocolBuffers.ProtocolParser.WriteBool(stream, instance.Valid);
			global::SilentOrbit.ProtocolBuffers.ProtocolParser.Stack.Push(msField);
		}

		/// <summary>Helper: Serialize into a MemoryStream and return its byte array</summary>
		public static byte[] SerializeToBytes(PlayerJoinResponse instance)
		{
			using (var ms = new MemoryStream())
			{
				Serialize(ms, instance);
				return ms.ToArray();
			}
		}
		/// <summary>Helper: Serialize with a varint length prefix</summary>
		public static void SerializeLengthDelimited(Stream stream, PlayerJoinResponse instance)
		{
			var data = SerializeToBytes(instance);
			global::SilentOrbit.ProtocolBuffers.ProtocolParser.WriteUInt32(stream, (uint)data.Length);
			stream.Write(data, 0, data.Length);
		}
	}

}