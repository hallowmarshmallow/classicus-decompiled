namespace Comms.Modules.Voice.Audio;

public interface IVoiceCaptureBackendFactory
{
	string BackendName { get; }

	bool IsSupported { get; }

	IVoiceCaptureBackend Create();
}
