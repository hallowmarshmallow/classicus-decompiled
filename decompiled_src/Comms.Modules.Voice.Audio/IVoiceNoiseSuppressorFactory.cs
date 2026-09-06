namespace Comms.Modules.Voice.Audio;

public interface IVoiceNoiseSuppressorFactory
{
	string Name { get; }

	bool IsSupported { get; }

	IVoiceNoiseSuppressor Create();
}
