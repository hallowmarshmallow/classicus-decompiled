namespace Comms.Modules.Voice;

public sealed class VoicePacket
{
	private readonly ushort _003CSequence_003Ek__BackingField;

	private readonly uint _003CSenderNetId_003Ek__BackingField;

	private readonly VoicePacketFlags _003CFlags_003Ek__BackingField;

	private readonly ushort _003COpusLength_003Ek__BackingField;

	private readonly byte[] _003COpusData_003Ek__BackingField;

	public ushort Sequence => _003CSequence_003Ek__BackingField;

	public uint SenderNetId => _003CSenderNetId_003Ek__BackingField;

	public VoicePacketFlags Flags => _003CFlags_003Ek__BackingField;

	public ushort OpusLength => _003COpusLength_003Ek__BackingField;

	public byte[] OpusData => _003COpusData_003Ek__BackingField;

	public VoicePacket(ushort sequence, uint senderNetId, VoicePacketFlags flags, byte[] opusData, ushort opusLength)
	{
	}
}
