using System.Collections.Generic;

namespace Comms.Modules.Voice;

public sealed class VoiceCapabilityRegistry
{
	private readonly Dictionary<uint, VoiceState> _states;

	private VoiceMode _authoritativeMode;

	private bool _hasAuthoritativeMode;

	public void Clear()
	{
		throw null;
	}

	public VoiceState Register(uint playerNetId, VoiceHello hello, VoiceMode mode)
	{
		throw null;
	}

	public void Apply(VoiceState state)
	{
		throw null;
	}

	public bool HasCompatibleVoice(uint playerNetId)
	{
		throw null;
	}

	public bool TryGet(uint playerNetId, out VoiceState state)
	{
		throw null;
	}

	public void CopyStatesTo(List<VoiceState> destination, VoiceMode mode)
	{
		throw null;
	}

	public VoiceMode GetEffectiveMode(VoiceMode fallback)
	{
		throw null;
	}

	public bool GetEffectiveProximityEnabled(bool fallback)
	{
		throw null;
	}

	public bool GetEffectiveWallsBlockVoice(bool fallback)
	{
		throw null;
	}

	public float GetEffectiveProximityRange(float fallback)
	{
		throw null;
	}

	private void SetAuthoritativeMode(VoiceMode mode)
	{
		throw null;
	}

	public VoiceCapabilityRegistry()
	{
		throw null;
	}
}
