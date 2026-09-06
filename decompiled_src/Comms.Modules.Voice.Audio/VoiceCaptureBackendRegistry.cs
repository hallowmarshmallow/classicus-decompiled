using System.Collections.Generic;

namespace Comms.Modules.Voice.Audio;

public static class VoiceCaptureBackendRegistry
{
	private sealed class UnityMicrophoneCaptureFactory : IVoiceCaptureBackendFactory
	{
		public string BackendName
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

		public IVoiceCaptureBackend Create()
		{
			throw null;
		}

		public UnityMicrophoneCaptureFactory()
		{
			throw null;
		}
	}

	private static readonly List<IVoiceCaptureBackendFactory> Factories;

	public static IVoiceCaptureBackendFactory Resolve(string requestedBackend)
	{
		throw null;
	}

	public static string GetBackendList()
	{
		throw null;
	}

	static VoiceCaptureBackendRegistry()
	{
		throw null;
	}
}
