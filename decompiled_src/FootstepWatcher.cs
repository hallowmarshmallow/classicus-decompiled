using UnityEngine;

internal class FootstepWatcher : MonoBehaviour, IStepWatcher
{
	public int priority;

	public Collider2D Area;

	public SoundGroup Sounds;

	public int Priority
	{
		get
		{
			throw null;
		}
	}

	public SoundGroup MakeFootstep(PlayerControl player)
	{
		throw null;
	}

	private void OnDrawGizmos()
	{
		throw null;
	}

	public FootstepWatcher()
	{
		throw null;
	}
}
