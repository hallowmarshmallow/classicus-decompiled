namespace AudioProcessingModuleCs.Media.Dsp.WebRtc;

public class RingBuffer
{
	public enum Wrap
	{
		SameWrap,
		DiffWrap
	}

	private readonly short[] data;

	private int readPos;

	private Wrap rwWrap;

	private int writePos;

	private int size
	{
		get
		{
			throw null;
		}
	}

	public RingBuffer(int size)
	{
		throw null;
	}

	public void Write(short[] input, int length)
	{
		throw null;
	}

	public int get_buffer_size()
	{
		throw null;
	}

	public void Read(short[] output, int length)
	{
		throw null;
	}

	public void Stuff(int size)
	{
		throw null;
	}
}
