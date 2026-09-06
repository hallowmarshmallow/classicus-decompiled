using System;
using Concentus.Structs;

namespace Comms.Modules.Voice.Audio;

public sealed class OpusVoiceDecoder : IDisposable
{
	private static readonly byte[] EmptyPacket;

	private readonly OpusDecoder _decoder;

	public OpusVoiceDecoder()
	{
		throw null;
	}

	public int Decode(byte[] data, int length, float[] destination)
	{
		throw null;
	}

	public int DecodeForwardErrorCorrection(byte[] nextData, int nextLength, float[] destination)
	{
		throw null;
	}

	public int DecodeMissing(float[] destination)
	{
		throw null;
	}

	public void Dispose()
	{
		throw null;
	}

	static OpusVoiceDecoder()
	{
		throw null;
	}
}
