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

	private int size => 0;

	public RingBuffer(int size)
	{
	}

	public void Write(short[] input, int length)
	{
	}

	public int get_buffer_size()
	{
		return 0;
	}

	public void Read(short[] output, int length)
	{
	}

	public void Stuff(int size)
	{
	}
}
