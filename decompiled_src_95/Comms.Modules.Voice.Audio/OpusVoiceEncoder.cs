using System;
using Concentus.Structs;

namespace Comms.Modules.Voice.Audio;

public sealed class OpusVoiceEncoder : IDisposable
{
	private readonly OpusEncoder _encoder;

	public int Encode(float[] pcmFrame, byte[] destination)
	{
		return 0;
	}

	public void Dispose()
	{
	}
}
