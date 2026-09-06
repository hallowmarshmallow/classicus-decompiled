namespace Comms.Modules.Voice.Audio;

public interface IVoicePlaybackReferenceConsumer
{
	void RegisterPlaybackReference(float[] samples, int length, float gain, int channels, string source);
}
