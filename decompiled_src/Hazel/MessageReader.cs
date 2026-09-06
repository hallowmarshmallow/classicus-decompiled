using System;
using System.Runtime.CompilerServices;

namespace Hazel;

public class MessageReader : IRecyclable
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

		internal MessageReader _003C_002Ecctor_003Eb__46_0()
		{
			throw null;
		}
	}

	public static readonly ObjectPool<MessageReader> ReaderPool;

	public byte[] Buffer;

	public byte Tag;

	public int Length;

	public int Offset;

	private MessageReader Parent;

	private int _position;

	private int readHead;

	public int BytesRemaining
	{
		get
		{
			throw null;
		}
	}

	public int Position
	{
		get
		{
			throw null;
		}
		set
		{
			throw null;
		}
	}

	public static MessageReader GetSized(int minSize)
	{
		throw null;
	}

	public static MessageReader Get(byte[] buffer)
	{
		throw null;
	}

	public static MessageReader CopyMessageIntoParent(MessageReader source)
	{
		throw null;
	}

	public static MessageReader Get(MessageReader source)
	{
		throw null;
	}

	public MessageReader ReadMessage()
	{
		throw null;
	}

	public MessageReader ReadMessageAsNewBuffer()
	{
		throw null;
	}

	public void Recycle()
	{
		throw null;
	}

	public bool ReadBoolean()
	{
		throw null;
	}

	public sbyte ReadSByte()
	{
		throw null;
	}

	public byte ReadByte()
	{
		throw null;
	}

	public ushort ReadUInt16()
	{
		throw null;
	}

	public uint ReadUInt32()
	{
		throw null;
	}

	public int ReadInt32()
	{
		throw null;
	}

	public float ReadSingle()
	{
		throw null;
	}

	public string ReadString()
	{
		throw null;
	}

	public byte[] ReadBytesAndSize()
	{
		throw null;
	}

	public byte[] ReadBytes(int length)
	{
		throw null;
	}

	public void ReadBytes(int length, byte[] destination)
	{
		throw null;
	}

	public int ReadPackedInt32()
	{
		throw null;
	}

	public uint ReadPackedUInt32()
	{
		throw null;
	}

	[MethodImpl((MethodImplOptions)256)]
	private byte FastByte()
	{
		throw null;
	}

	public MessageReader()
	{
		throw null;
	}

	static MessageReader()
	{
		throw null;
	}
}
