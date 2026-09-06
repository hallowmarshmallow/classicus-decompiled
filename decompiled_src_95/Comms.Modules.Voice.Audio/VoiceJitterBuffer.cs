namespace Comms.Modules.Voice.Audio;

public sealed class VoiceJitterBuffer
{
	private readonly VoicePacket[] _packets;

	private readonly object _gate;

	private ushort _playoutSequence;

	private bool _started;

	private int _bufferedFrames;

	public bool Started => false;

	public int BufferedFrames => 0;

	public VoiceJitterBuffer(int capacityFrames)
	{
	}

	public void Insert(VoicePacket packet)
	{
	}

	public bool TryPop(out VoicePacket packet)
	{
		packet = null;
		return false;
	}

	public bool TryPeekNext(out VoicePacket packet)
	{
		packet = null;
		return false;
	}

	private bool TryStartLocked()
	{
		return false;
	}

	private void DropUntil(ushort targetSequence)
	{
	}

	private static bool IsOlder(ushort candidate, ushort reference)
	{
		return false;
	}

	private static int SequenceDistance(ushort candidate, ushort reference)
	{
		return 0;
	}
}
