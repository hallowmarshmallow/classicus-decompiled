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
			return 0;
		}
		set
		{
		}
	}

	// C# has no syntax for parameterized property 'Item'.
	public void set_Item(int i, byte value)
	{
	}

	public SmartBuffer(ObjectPool<SmartBuffer> parent, int size)
	{
	}

	public static explicit operator byte[](SmartBuffer b)
	{
		return null;
	}

	public void AddUsage()
	{
	}

	public void Dispose()
	{
	}

	public void Recycle()
	{
	}

	public void CopyFrom(byte[] bytes)
	{
	}

	public void CopyFrom(MessageWriter data, bool includeHeader = true)
	{
	}
}
