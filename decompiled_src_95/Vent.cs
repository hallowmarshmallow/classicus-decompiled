using UnityEngine;

public class Vent : MonoBehaviour, IUsable
{
	public int Id;

	public Vent Left;

	public Vent Right;

	public Vent Center;

	public ButtonBehavior[] Buttons;

	public AnimationClip EnterVentAnim;

	public AnimationClip ExitVentAnim;

	public bool isBigDistance;

	public bool showPlayerInside;

	public bool ventOnlyEntrance;

	private static readonly Vector3 CollOffset;

	private SpriteRenderer myRend;

	private static float localCooldownUntil;

	private static float localCooldownDuration;

	public static Vent currentVent;

	public float UsableDistance => 0f;

	public static float LocalCooldownRemaining => 0f;

	public static float LocalCooldownDuration => 0f;

	public float PercentCool => 0f;

	public static void StartLocalExitCooldown()
	{
	}

	public static void ClearLocalCooldown()
	{
	}

	private void Start()
	{
	}

	public void SetButtons(bool enabled)
	{
	}

	public float CanUse(GameData.PlayerInfo pc, out bool canUse, out bool couldUse)
	{
		canUse = default(bool);
		couldUse = default(bool);
		return 0f;
	}

	public void SetOutline(bool on, bool mainTarget)
	{
	}

	public void ClickRight()
	{
	}

	public void ClickLeft()
	{
	}

	public void ClickCenter()
	{
	}

	private static void DoMove(Vector3 pos, Vent destinationVent)
	{
	}

	private static AudioClip GetMoveSound(PlayerControl pc)
	{
		return null;
	}

	private static AudioClip GetEnterSound(PlayerControl pc)
	{
		return null;
	}

	private static AudioClip GetExitSound(PlayerControl pc)
	{
		return null;
	}

	public void Use()
	{
	}

	internal void EnterVent(PlayerControl pc)
	{
	}

	internal void ExitVent(PlayerControl pc)
	{
	}

	internal void ExitVentScary(PlayerControl pc)
	{
	}

	private static void ConsumeLocalVentUse()
	{
	}
}
