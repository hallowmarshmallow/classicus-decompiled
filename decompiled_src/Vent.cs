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

	public float UsableDistance
	{
		get
		{
			throw null;
		}
	}

	public static float LocalCooldownRemaining
	{
		get
		{
			throw null;
		}
	}

	public static float LocalCooldownDuration
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

	public static void StartLocalExitCooldown()
	{
		throw null;
	}

	public static void ClearLocalCooldown()
	{
		throw null;
	}

	private void Start()
	{
		throw null;
	}

	public void SetButtons(bool enabled)
	{
		throw null;
	}

	public float CanUse(GameData.PlayerInfo pc, out bool canUse, out bool couldUse)
	{
		throw null;
	}

	public void SetOutline(bool on, bool mainTarget)
	{
		throw null;
	}

	public void ClickRight()
	{
		throw null;
	}

	public void ClickLeft()
	{
		throw null;
	}

	public void ClickCenter()
	{
		throw null;
	}

	private static void DoMove(Vector3 pos, Vent destinationVent)
	{
		throw null;
	}

	private static AudioClip GetMoveSound(PlayerControl pc)
	{
		throw null;
	}

	private static AudioClip GetEnterSound(PlayerControl pc)
	{
		throw null;
	}

	private static AudioClip GetExitSound(PlayerControl pc)
	{
		throw null;
	}

	public void Use()
	{
		throw null;
	}

	internal void EnterVent(PlayerControl pc)
	{
		throw null;
	}

	internal void ExitVent(PlayerControl pc)
	{
		throw null;
	}

	internal void ExitVentScary(PlayerControl pc)
	{
		throw null;
	}

	private static void ConsumeLocalVentUse()
	{
		throw null;
	}

	public Vent()
	{
		throw null;
	}

	static Vent()
	{
		throw null;
	}
}
