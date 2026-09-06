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

	private static float ActiveClaimSeconds => 0f;

	public float UsableDistance => 0f;

	public float PercentCool => 0f;

	private void Awake()
	{
	}

	private void Update()
	{
	}

	private void TickChannel()
	{
	}

	private void CancelChannel()
	{
	}

	private void BeginProgressLabel(PlayerControl me)
	{
	}

	private void UpdateProgressLabel(float t)
	{
	}

	private void ClearProgressLabel()
	{
	}

	public void SetSpriteChild(SpriteRenderer sr)
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

	public void SetOutline(bool on, bool mainTarget)
	{
	}
}
