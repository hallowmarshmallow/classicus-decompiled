using System;
using System.Collections.Generic;

namespace Hazel;

public class MessageWriter : IRecyclable
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		static _003C_003Ec()
		{
			throw null;
		}

		public _003C_003Ec()
		{
			throw null;
		}

		internal MessageWriter _003C_002Ecctor_003Eb__42_0()
		{
			throw null;
		}
	}

	public static int BufferSize;

	public static readonly ObjectPool<MessageWriter> WriterPool;

	public byte[] Buffer;

	public int Length;

	public int Position;

	private SendOption _003CSendOption_003Ek__BackingField;

	private Stack<int> messageStarts;

	public SendOption SendOption
	{
		get
		{
			throw null;
		}
		private set
		{
			throw null;
		}
	}

	public MessageWriter(int bufferSize)
	{
		throw null;
	}

	public byte[] ToByteArray(bool includeHeader)
	{
		throw null;
	}

	public static MessageWriter Get(SendOption sendOption = SendOption.None)
	{
		throw null;
	}

	public bool HasBytes(int expected)
	{
		throw null;
	}

	public void StartMessage(byte typeFlag)
	{
		throw null;
	}

	public void EndMessage()
	{
		throw null;
	}

	public void CancelMessage()
	{
		throw null;
	}

	public void Clear(SendOption sendOption)
	{
		throw null;
	}

	public void Recycle()
	{
		throw null;
	}

	public void CopyFrom(MessageReader target)
	{
		throw null;
	}

	public void Write(bool value)
	{
		throw null;
	}

	public void Write(sbyte value)
	{
		throw null;
	}

	public void Write(byte value)
	{
		throw null;
	}

	public void Write(ushort value)
	{
		throw null;
	}

	public void Write(uint value)
	{
		throw null;
	}

	public void Write(int value)
	{
		throw null;
	}

	public void Write(float value)
	{
		throw null;
	}

	public void Write(string value)
	{
		throw null;
	}

	public void WriteBytesAndSize(byte[] bytes)
	{
		throw null;
	}

	public void Write(byte[] bytes)
	{
		throw null;
	}

	public void Write(byte[] bytes, int offset, int length)
	{
		throw null;
	}

	public void WritePacked(int value)
	{
		throw null;
	}

	public void WritePacked(uint value)
	{
		throw null;
	}

	static MessageWriter()
	{
		throw null;
	}
}
