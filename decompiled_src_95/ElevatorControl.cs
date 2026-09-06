using UnityEngine;
using UnityEngine.UI;

public class ElevatorControl : MonoBehaviour, IUsable
{
	public float usableDistance;

	public SpriteRenderer Image;

	public ElevatorTransition TargetElevator;

	public Button.ButtonClickedEvent OnUse;

	private Material cachedImageMaterial;

	public float UsableDistance => 0f;

	public float PercentCool => 0f;

	private Material ImageMaterial => null;

	public void SetOutline(bool on, bool mainTarget)
	{
	}

	public float CanUse(GameData.PlayerInfo pc, out bool canUse, out bool couldUse)
	{
		canUse = default(bool);
		couldUse = default(bool);
		return 0f;
	}

	public void Use()
	{
	}

	private void OnDestroy()
	{
	}
}
