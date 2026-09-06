namespace Comms.Modules.Voice.Audio;

public sealed class FloatRingBuffer
{
	private readonly float[] _buffer;

	private readonly object _gate;

	private int _read;

	private int _write;

	private int _count;

	public int Count
	{
		get
		{
			throw null;
		}
	}

	public FloatRingBuffer(int capacity)
	{
		throw null;
	}

	public void Clear()
	{
		throw null;
	}

	public void TrimToLatest(int samplesToKeep)
	{
		throw null;
	}

	public void Write(float[] source, int offset, int length)
	{
		throw null;
	}

	public bool Read(float[] destination, int offset, int length)
	{
		throw null;
	}

	private void Drop(int samples)
	{
		throw null;
	}
}
