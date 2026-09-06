using System;

namespace Comms.Modules.Voice.Audio;

public interface IVoiceNoiseSuppressor : IDisposable
{
	string Name { get; }

	string Status { get; }

	void Process(float[] samples, int length);

	void Reset();
}
