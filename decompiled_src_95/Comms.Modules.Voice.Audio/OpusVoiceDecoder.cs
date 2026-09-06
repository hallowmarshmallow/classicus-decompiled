using System;
using Concentus.Structs;

namespace Comms.Modules.Voice.Audio;

public sealed class OpusVoiceDecoder : IDisposable
{
	private static readonly byte[] EmptyPacket;

	private readonly OpusDecoder _decoder;

	public int Decode(byte[] data, int length, float[] destination)
	{
		return 0;
	}

	public int DecodeForwardErrorCorrection(byte[] nextData, int nextLength, float[] destination)
	{
		return 0;
	}

	public int DecodeMissing(float[] destination)
	{
		return 0;
	}

	public void Dispose()
	{
	}
}
