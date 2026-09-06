using UnityEngine;
using UnityEngine.UI;

public class ElevatorControl : MonoBehaviour, IUsable
{
	public float usableDistance;

	public SpriteRenderer Image;

	public ElevatorTransition TargetElevator;

	public Button.ButtonClickedEvent OnUse;

	private Material cachedImageMaterial;

	public float UsableDistance
	{
		get
		{
			throw null;
		}
	}

	public float PercentCool
	{
		get
		{
			throw null;
		}
	}

	private Material ImageMaterial
	{
		get
		{
			throw null;
		}
	}

	public void SetOutline(bool on, bool mainTarget)
	{
		throw null;
	}

	public float CanUse(GameData.PlayerInfo pc, out bool canUse, out bool couldUse)
	{
		throw null;
	}

	public void Use()
	{
		throw null;
	}

	private void OnDestroy()
	{
		throw null;
	}

	public ElevatorControl()
	{
		throw null;
	}
}
