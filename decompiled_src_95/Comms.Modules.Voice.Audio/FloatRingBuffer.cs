namespace Comms.Modules.Voice.Audio;

public sealed class FloatRingBuffer
{
	private readonly float[] _buffer;

	private readonly object _gate;

	private int _read;

	private int _write;

	private int _count;

	public int Count => 0;

	public FloatRingBuffer(int capacity)
	{
	}

	public void Clear()
	{
	}

	public void TrimToLatest(int samplesToKeep)
	{
	}

	public void Write(float[] source, int offset, int length)
	{
	}

	public bool Read(float[] destination, int offset, int length)
	{
		return false;
	}

	private void Drop(int samples)
	{
	}
}
