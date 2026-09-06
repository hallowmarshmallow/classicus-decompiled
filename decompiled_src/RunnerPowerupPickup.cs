using TMPro;
using UnityEngine;

public sealed class RunnerPowerupPickup : MonoBehaviour, IUsable
{
	public byte PickupId;

	public RunnerPowerupType Type;

	public float SpawnedAt;

	public bool Permanent;

	private const float UseRange = 0.9f;

	private const float ClaimSeconds = 1.5f;

	private const float UltimateClaimSeconds = 0.5f;

	private bool _requested;

	private float _bobPhase;

	private SpriteRenderer _spriteChild;

	private bool _channeling;

	private float _channelStart;

	private TextMeshPro _progressLabel;

	private static float ActiveClaimSeconds
	{
		get
		{
			throw null;
		}
	}

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

	private void Awake()
	{
		throw null;
	}

	private void Update()
	{
		throw null;
	}

	private void TickChannel()
	{
		throw null;
	}

	private void CancelChannel()
	{
		throw null;
	}

	private void BeginProgressLabel(PlayerControl me)
	{
		throw null;
	}

	private void UpdateProgressLabel(float t)
	{
		throw null;
	}

	private void ClearProgressLabel()
	{
		throw null;
	}

	public void SetSpriteChild(SpriteRenderer sr)
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

	public void SetOutline(bool on, bool mainTarget)
	{
		throw null;
	}

	public RunnerPowerupPickup()
	{
		throw null;
	}
}
