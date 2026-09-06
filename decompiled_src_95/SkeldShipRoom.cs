using UnityEngine;

public class SkeldShipRoom : ShipRoom, IStepWatcher
{
	private RaycastHit2D[] volumeBuffer;

	private readonly int _003CPriority_003Ek__BackingField;

	public int Priority => _003CPriority_003Ek__BackingField;

	public void Start()
	{
	}

	public SoundGroup MakeFootstep(PlayerControl player)
	{
		return null;
	}

	private void GetAmbientSoundVolume(AudioSource player, float dt)
	{
	}

	private void _003CStart_003Eb__4_0(AudioSource player, float dt)
	{
	}
}
