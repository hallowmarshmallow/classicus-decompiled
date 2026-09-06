using System;

namespace Hazel;

public class SmartBuffer : IRecyclable, IDisposable
{
	private readonly ObjectPool<SmartBuffer> parent;

	private byte[] buffer;

	private int usageCount;

	private int length;

	public int Length
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

	// C# has no syntax for parameterized property 'Item'.
	public void set_Item(int i, byte value)
	{
		throw null;
	}

	public SmartBuffer(ObjectPool<SmartBuffer> parent, int size)
	{
		throw null;
	}

	public static explicit operator byte[](SmartBuffer b)
	{
		throw null;
	}

	public void AddUsage()
	{
		throw null;
	}

	public void Dispose()
	{
		throw null;
	}

	public void Recycle()
	{
		throw null;
	}

	public void CopyFrom(byte[] bytes)
	{
		throw null;
	}

	public void CopyFrom(MessageWriter data, bool includeHeader = true)
	{
		throw null;
	}
}
