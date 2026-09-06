using System;

namespace AudioProcessingModuleCs.Media.Dsp;

public interface IAudioFilter
{
	string InstanceName { set; }

	void Write(byte[] sampleData);

	bool Read(Array frame, out bool moreFrames);
}
