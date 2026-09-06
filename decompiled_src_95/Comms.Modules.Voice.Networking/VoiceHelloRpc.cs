using Hazel;

namespace Comms.Modules.Voice.Networking;

public sealed class VoiceHelloRpc
{
	public static void Write(MessageWriter writer, VoiceHello data)
	{
	}

	public static VoiceHello Read(MessageReader reader)
	{
		return default(VoiceHello);
	}

	public static void Handle(PlayerControl innerNetObject, VoiceHello data)
	{
	}
}
