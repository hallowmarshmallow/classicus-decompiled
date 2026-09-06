using System.Collections.Generic;

namespace Comms.Modules.Voice.Audio;

public static class VoiceCaptureBackendRegistry
{
	private sealed class UnityMicrophoneCaptureFactory : IVoiceCaptureBackendFactory
	{
		public string BackendName => null;

		public bool IsSupported => false;

		public IVoiceCaptureBackend Create()
		{
			return null;
		}
	}

	private static readonly List<IVoiceCaptureBackendFactory> Factories;

	public static IVoiceCaptureBackendFactory Resolve(string requestedBackend)
	{
		return null;
	}

	public static string GetBackendList()
	{
		return null;
	}
}
