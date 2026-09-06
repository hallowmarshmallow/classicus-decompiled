using System;
using System.Collections.Generic;

namespace Comms.Modules.Voice.Audio;

public static class VoiceNoiseSuppressorRegistry
{
	private sealed class LightweightNoiseSuppressorFactory : IVoiceNoiseSuppressorFactory
	{
		public string Name
		{
			get
			{
				throw null;
			}
		}

		public bool IsSupported
		{
			get
			{
				throw null;
			}
		}

		public IVoiceNoiseSuppressor Create()
		{
			throw null;
		}

		public LightweightNoiseSuppressorFactory()
		{
			throw null;
		}
	}

	private sealed class BypassNoiseSuppressorFactory : IVoiceNoiseSuppressorFactory
	{
		public string Name
		{
			get
			{
				throw null;
			}
		}

		public bool IsSupported
		{
			get
			{
				throw null;
			}
		}

		public IVoiceNoiseSuppressor Create()
		{
			throw null;
		}

		public BypassNoiseSuppressorFactory()
		{
			throw null;
		}
	}

	private sealed class BypassNoiseSuppressor : IVoiceNoiseSuppressor, IDisposable
	{
		public string Name
		{
			get
			{
				throw null;
			}
		}

		public string Status
		{
			get
			{
				throw null;
			}
		}

		public void Process(float[] samples, int length)
		{
			throw null;
		}

		public void Reset()
		{
			throw null;
		}

		public void Dispose()
		{
			throw null;
		}

		public BypassNoiseSuppressor()
		{
			throw null;
		}
	}

	private static readonly List<IVoiceNoiseSuppressorFactory> Factories;

	public static IVoiceNoiseSuppressorFactory Resolve(string requestedName)
	{
		throw null;
	}

	public static string GetSuppressorList()
	{
		throw null;
	}

	static VoiceNoiseSuppressorRegistry()
	{
		throw null;
	}
}
