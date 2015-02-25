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
	public partial class EventGameStart
	{
		/// <summary>Helper: create a new instance to deserializing into</summary>
		public static EventGameStart Deserialize(Stream stream)
		{
			EventGameStart instance = new EventGameStart();
			Deserialize(stream, instance);
			return instance;
		}

		/// <summary>Helper: create a new instance to deserializing into</summary>
		public static EventGameStart DeserializeLengthDelimited(Stream stream)
		{
			EventGameStart instance = new EventGameStart();
			DeserializeLengthDelimited(stream, instance);
			return instance;
		}

		/// <summary>Helper: create a new instance to deserializing into</summary>
		public static EventGameStart DeserializeLength(Stream stream, int length)
		{
			EventGameStart instance = new EventGameStart();
			DeserializeLength(stream, length, instance);
			return instance;
		}

		/// <summary>Helper: put the buffer into a MemoryStream and create a new instance to deserializing into</summary>
		public static EventGameStart Deserialize(byte[] buffer)
		{
			EventGameStart instance = new EventGameStart();
			using (var ms = new MemoryStream(buffer))
				Deserialize(ms, instance);
			return instance;
		}

		/// <summary>Helper: put the buffer into a MemoryStream before deserializing</summary>
		public static Tesla.EventGameStart Deserialize(byte[] buffer, Tesla.EventGameStart instance)
		{
			using (var ms = new MemoryStream(buffer))
				Deserialize(ms, instance);
			return instance;
		}

		/// <summary>Takes the remaining content of the stream and deserialze it into the instance.</summary>
		public static Tesla.EventGameStart Deserialize(Stream stream, Tesla.EventGameStart instance)
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
						instance.GameID = global::SilentOrbit.ProtocolBuffers.ProtocolParser.ReadUInt64(stream);
						continue;
					// Field 2 Varint
					case 16:
						instance.StartTime = (long)global::SilentOrbit.ProtocolBuffers.ProtocolParser.ReadUInt64(stream);
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
		public static Tesla.EventGameStart DeserializeLengthDelimited(Stream stream, Tesla.EventGameStart instance)
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
						instance.GameID = global::SilentOrbit.ProtocolBuffers.ProtocolParser.ReadUInt64(stream);
						continue;
					// Field 2 Varint
					case 16:
						instance.StartTime = (long)global::SilentOrbit.ProtocolBuffers.ProtocolParser.ReadUInt64(stream);
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
		public static Tesla.EventGameStart DeserializeLength(Stream stream, int length, Tesla.EventGameStart instance)
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
						instance.GameID = global::SilentOrbit.ProtocolBuffers.ProtocolParser.ReadUInt64(stream);
						continue;
					// Field 2 Varint
					case 16:
						instance.StartTime = (long)global::SilentOrbit.ProtocolBuffers.ProtocolParser.ReadUInt64(stream);
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
		public static void Serialize(Stream stream, EventGameStart instance)
		{
			var msField = global::SilentOrbit.ProtocolBuffers.ProtocolParser.Stack.Pop();
			// Key for field: 1, Varint
			stream.WriteByte(8);
			global::SilentOrbit.ProtocolBuffers.ProtocolParser.WriteUInt64(stream, instance.GameID);
			// Key for field: 2, Varint
			stream.WriteByte(16);
			global::SilentOrbit.ProtocolBuffers.ProtocolParser.WriteUInt64(stream,(ulong)instance.StartTime);
			global::SilentOrbit.ProtocolBuffers.ProtocolParser.Stack.Push(msField);
		}

		/// <summary>Helper: Serialize into a MemoryStream and return its byte array</summary>
		public static byte[] SerializeToBytes(EventGameStart instance)
		{
			using (var ms = new MemoryStream())
			{
				Serialize(ms, instance);
				return ms.ToArray();
			}
		}
		/// <summary>Helper: Serialize with a varint length prefix</summary>
		public static void SerializeLengthDelimited(Stream stream, EventGameStart instance)
		{
			var data = SerializeToBytes(instance);
			global::SilentOrbit.ProtocolBuffers.ProtocolParser.WriteUInt32(stream, (uint)data.Length);
			stream.Write(data, 0, data.Length);
		}
	}

	[System.Serializable()]
	public partial class EventGameEnd
	{
		/// <summary>Helper: create a new instance to deserializing into</summary>
		public static EventGameEnd Deserialize(Stream stream)
		{
			EventGameEnd instance = new EventGameEnd();
			Deserialize(stream, instance);
			return instance;
		}

		/// <summary>Helper: create a new instance to deserializing into</summary>
		public static EventGameEnd DeserializeLengthDelimited(Stream stream)
		{
			EventGameEnd instance = new EventGameEnd();
			DeserializeLengthDelimited(stream, instance);
			return instance;
		}

		/// <summary>Helper: create a new instance to deserializing into</summary>
		public static EventGameEnd DeserializeLength(Stream stream, int length)
		{
			EventGameEnd instance = new EventGameEnd();
			DeserializeLength(stream, length, instance);
			return instance;
		}

		/// <summary>Helper: put the buffer into a MemoryStream and create a new instance to deserializing into</summary>
		public static EventGameEnd Deserialize(byte[] buffer)
		{
			EventGameEnd instance = new EventGameEnd();
			using (var ms = new MemoryStream(buffer))
				Deserialize(ms, instance);
			return instance;
		}

		/// <summary>Helper: put the buffer into a MemoryStream before deserializing</summary>
		public static Tesla.EventGameEnd Deserialize(byte[] buffer, Tesla.EventGameEnd instance)
		{
			using (var ms = new MemoryStream(buffer))
				Deserialize(ms, instance);
			return instance;
		}

		/// <summary>Takes the remaining content of the stream and deserialze it into the instance.</summary>
		public static Tesla.EventGameEnd Deserialize(Stream stream, Tesla.EventGameEnd instance)
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
						instance.GameID = global::SilentOrbit.ProtocolBuffers.ProtocolParser.ReadUInt64(stream);
						continue;
					// Field 2 Varint
					case 16:
						instance.EndTime = (long)global::SilentOrbit.ProtocolBuffers.ProtocolParser.ReadUInt64(stream);
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
		public static Tesla.EventGameEnd DeserializeLengthDelimited(Stream stream, Tesla.EventGameEnd instance)
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
						instance.GameID = global::SilentOrbit.ProtocolBuffers.ProtocolParser.ReadUInt64(stream);
						continue;
					// Field 2 Varint
					case 16:
						instance.EndTime = (long)global::SilentOrbit.ProtocolBuffers.ProtocolParser.ReadUInt64(stream);
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
		public static Tesla.EventGameEnd DeserializeLength(Stream stream, int length, Tesla.EventGameEnd instance)
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
						instance.GameID = global::SilentOrbit.ProtocolBuffers.ProtocolParser.ReadUInt64(stream);
						continue;
					// Field 2 Varint
					case 16:
						instance.EndTime = (long)global::SilentOrbit.ProtocolBuffers.ProtocolParser.ReadUInt64(stream);
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
		public static void Serialize(Stream stream, EventGameEnd instance)
		{
			var msField = global::SilentOrbit.ProtocolBuffers.ProtocolParser.Stack.Pop();
			// Key for field: 1, Varint
			stream.WriteByte(8);
			global::SilentOrbit.ProtocolBuffers.ProtocolParser.WriteUInt64(stream, instance.GameID);
			// Key for field: 2, Varint
			stream.WriteByte(16);
			global::SilentOrbit.ProtocolBuffers.ProtocolParser.WriteUInt64(stream,(ulong)instance.EndTime);
			global::SilentOrbit.ProtocolBuffers.ProtocolParser.Stack.Push(msField);
		}

		/// <summary>Helper: Serialize into a MemoryStream and return its byte array</summary>
		public static byte[] SerializeToBytes(EventGameEnd instance)
		{
			using (var ms = new MemoryStream())
			{
				Serialize(ms, instance);
				return ms.ToArray();
			}
		}
		/// <summary>Helper: Serialize with a varint length prefix</summary>
		public static void SerializeLengthDelimited(Stream stream, EventGameEnd instance)
		{
			var data = SerializeToBytes(instance);
			global::SilentOrbit.ProtocolBuffers.ProtocolParser.WriteUInt32(stream, (uint)data.Length);
			stream.Write(data, 0, data.Length);
		}
	}

}
