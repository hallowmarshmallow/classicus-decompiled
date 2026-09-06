namespace Comms.Modules.Voice.Audio;

public sealed class VoiceJitterBuffer
{
	private readonly VoicePacket[] _packets;

	private readonly object _gate;

	private ushort _playoutSequence;

	private bool _started;

	private int _bufferedFrames;

	public bool Started
	{
		get
		{
			throw null;
		}
	}

	public int BufferedFrames
	{
		get
		{
			throw null;
		}
	}

	public VoiceJitterBuffer(int capacityFrames)
	{
		throw null;
	}

	public void Insert(VoicePacket packet)
	{
		throw null;
	}

	public bool TryPop(out VoicePacket packet)
	{
		throw null;
	}

	public bool TryPeekNext(out VoicePacket packet)
	{
		throw null;
	}

	private bool TryStartLocked()
	{
		throw null;
	}

	private void DropUntil(ushort targetSequence)
	{
		throw null;
	}

	private static bool IsOlder(ushort candidate, ushort reference)
	{
		throw null;
	}

	private static int SequenceDistance(ushort candidate, ushort reference)
	{
		throw null;
	}
}
