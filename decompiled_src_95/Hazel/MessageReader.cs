using System;
using System.Runtime.CompilerServices;

namespace Hazel;

public class MessageReader : IRecyclable
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		internal MessageReader _003C_002Ecctor_003Eb__46_0()
		{
			return null;
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

	public int BytesRemaining => 0;

	public int Position
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public static MessageReader GetSized(int minSize)
	{
		return null;
	}

	public static MessageReader Get(byte[] buffer)
	{
		return null;
	}

	public static MessageReader CopyMessageIntoParent(MessageReader source)
	{
		return null;
	}

	public static MessageReader Get(MessageReader source)
	{
		return null;
	}

	public MessageReader ReadMessage()
	{
		return null;
	}

	public MessageReader ReadMessageAsNewBuffer()
	{
		return null;
	}

	public void Recycle()
	{
	}

	public bool ReadBoolean()
	{
		return false;
	}

	public sbyte ReadSByte()
	{
		return 0;
	}

	public byte ReadByte()
	{
		return 0;
	}

	public ushort ReadUInt16()
	{
		return 0;
	}

	public uint ReadUInt32()
	{
		return 0u;
	}

	public int ReadInt32()
	{
		return 0;
	}

	public float ReadSingle()
	{
		return 0f;
	}

	public string ReadString()
	{
		return null;
	}

	public byte[] ReadBytesAndSize()
	{
		return null;
	}

	public byte[] ReadBytes(int length)
	{
		return null;
	}

	public void ReadBytes(int length, byte[] destination)
	{
	}

	public int ReadPackedInt32()
	{
		return 0;
	}

	public uint ReadPackedUInt32()
	{
		return 0u;
	}

	[MethodImpl((MethodImplOptions)256)]
	private byte FastByte()
	{
		return 0;
	}
}
