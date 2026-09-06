namespace Comms.Modules.Voice;

public sealed class VoicePacket
{
	private readonly ushort _003CSequence_003Ek__BackingField;

	private readonly uint _003CSenderNetId_003Ek__BackingField;

	private readonly VoicePacketFlags _003CFlags_003Ek__BackingField;

	private readonly ushort _003COpusLength_003Ek__BackingField;

	private readonly byte[] _003COpusData_003Ek__BackingField;

	public ushort Sequence
	{
		get
		{
			throw null;
		}
	}

	public uint SenderNetId
	{
		get
		{
			throw null;
		}
	}

	public VoicePacketFlags Flags
	{
		get
		{
			throw null;
		}
	}

	public ushort OpusLength
	{
		get
		{
			throw null;
		}
	}

	public byte[] OpusData
	{
		get
		{
			throw null;
		}
	}

	public VoicePacket(ushort sequence, uint senderNetId, VoicePacketFlags flags, byte[] opusData, ushort opusLength)
	{
		throw null;
	}
}
