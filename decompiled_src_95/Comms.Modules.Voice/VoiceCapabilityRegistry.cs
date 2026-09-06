using System.Collections.Generic;

namespace Comms.Modules.Voice;

public sealed class VoiceCapabilityRegistry
{
	private readonly Dictionary<uint, VoiceState> _states;

	private VoiceMode _authoritativeMode;

	private bool _hasAuthoritativeMode;

	public void Clear()
	{
	}

	public VoiceState Register(uint playerNetId, VoiceHello hello, VoiceMode mode)
	{
		return default(VoiceState);
	}

	public void Apply(VoiceState state)
	{
	}

	public bool HasCompatibleVoice(uint playerNetId)
	{
		return false;
	}

	public bool TryGet(uint playerNetId, out VoiceState state)
	{
		state = default(VoiceState);
		return false;
	}

	public void CopyStatesTo(List<VoiceState> destination, VoiceMode mode)
	{
	}

	public VoiceMode GetEffectiveMode(VoiceMode fallback)
	{
		return default(VoiceMode);
	}

	public bool GetEffectiveProximityEnabled(bool fallback)
	{
		return false;
	}

	public bool GetEffectiveWallsBlockVoice(bool fallback)
	{
		return false;
	}

	public float GetEffectiveProximityRange(float fallback)
	{
		return 0f;
	}

	private void SetAuthoritativeMode(VoiceMode mode)
	{
	}
}
