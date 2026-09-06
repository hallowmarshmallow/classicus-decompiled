using Hazel;

namespace Comms.Modules.Voice.Networking;

public static class VoiceStateRpc
{
	public static void Write(MessageWriter writer, VoiceState data)
	{
	}

	public static VoiceState Read(MessageReader reader)
	{
		return default(VoiceState);
	}

	public static void Handle(PlayerControl innerNetObject, VoiceState data)
	{
	}
}
