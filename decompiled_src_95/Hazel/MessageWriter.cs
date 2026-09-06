using System;
using System.Collections.Generic;

namespace Hazel;

public class MessageWriter : IRecyclable
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		internal MessageWriter _003C_002Ecctor_003Eb__42_0()
		{
			return null;
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
			return _003CSendOption_003Ek__BackingField;
		}
		private set
		{
			_003CSendOption_003Ek__BackingField = value;
		}
	}

	public MessageWriter(int bufferSize)
	{
	}

	public byte[] ToByteArray(bool includeHeader)
	{
		return null;
	}

	public static MessageWriter Get(SendOption sendOption = SendOption.None)
	{
		return null;
	}

	public bool HasBytes(int expected)
	{
		return false;
	}

	public void StartMessage(byte typeFlag)
	{
	}

	public void EndMessage()
	{
	}

	public void CancelMessage()
	{
	}

	public void Clear(SendOption sendOption)
	{
	}

	public void Recycle()
	{
	}

	public void CopyFrom(MessageReader target)
	{
	}

	public void Write(bool value)
	{
	}

	public void Write(sbyte value)
	{
	}

	public void Write(byte value)
	{
	}

	public void Write(ushort value)
	{
	}

	public void Write(uint value)
	{
	}

	public void Write(int value)
	{
	}

	public void Write(float value)
	{
	}

	public void Write(string value)
	{
	}

	public void WriteBytesAndSize(byte[] bytes)
	{
	}

	public void Write(byte[] bytes)
	{
	}

	public void Write(byte[] bytes, int offset, int length)
	{
	}

	public void WritePacked(int value)
	{
	}

	public void WritePacked(uint value)
	{
	}
}
