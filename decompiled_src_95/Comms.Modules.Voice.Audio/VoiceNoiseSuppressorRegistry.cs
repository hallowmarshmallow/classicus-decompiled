using System;
using System.Collections.Generic;

namespace Comms.Modules.Voice.Audio;

public static class VoiceNoiseSuppressorRegistry
{
	private sealed class LightweightNoiseSuppressorFactory : IVoiceNoiseSuppressorFactory
	{
		public string Name => null;

		public bool IsSupported => false;

		public IVoiceNoiseSuppressor Create()
		{
			return null;
		}
	}

	private sealed class BypassNoiseSuppressorFactory : IVoiceNoiseSuppressorFactory
	{
		public string Name => null;

		public bool IsSupported => false;

		public IVoiceNoiseSuppressor Create()
		{
			return null;
		}
	}

	private sealed class BypassNoiseSuppressor : IVoiceNoiseSuppressor, IDisposable
	{
		public string Name => null;

		public string Status => null;

		public void Process(float[] samples, int length)
		{
		}

		public void Reset()
		{
		}

		public void Dispose()
		{
		}
	}

	private static readonly List<IVoiceNoiseSuppressorFactory> Factories;

	public static IVoiceNoiseSuppressorFactory Resolve(string requestedName)
	{
		return null;
	}

	public static string GetSuppressorList()
	{
		return null;
	}
}
