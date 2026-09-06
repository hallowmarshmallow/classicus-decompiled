using Hazel;

namespace Comms.Modules.Voice.Networking;

public static class VoiceFrameRpc
{
	public static void Write(MessageWriter writer, VoicePacket data)
	{
	}

	public static VoicePacket Read(MessageReader reader)
	{
		return null;
	}

	public static void Handle(PlayerControl innerNetObject, VoicePacket data)
	{
	}
}
