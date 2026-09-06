using Hazel;
using UnityEngine;

public sealed class WardenRole : RoleBehaviour
{
	public enum RpcCalls
	{
		Safeguard,
		NotifyBlocked
	}

	private static readonly Color WardenColor;

	private float _safeguardDuration;

	private float _safeguardCooldown;

	private float _cooldownUntil;

	private bool _safeguardActive;

	private SystemTypes _activeRoomId;

	private float _activeUntil;

	private VanillaButtonManager _button;

	private GameObject _shieldObj;

	public override bool IsEnabled
	{
		get
		{
			throw null;
		}
	}

	public override string roleDisplayName
	{
		get
		{
			throw null;
		}
	}

	public override string roleDescription
	{
		get
		{
			throw null;
		}
	}

	public override string roleDescriptionShort
	{
		get
		{
			throw null;
		}
	}

	public override void ConfigureRole()
	{
		throw null;
	}

	public override void OnAssign(PlayerControl player)
	{
		throw null;
	}

	public override void OnGameStart()
	{
		throw null;
	}

	public override void OnFixedUpdate()
	{
		throw null;
	}

	private void InitializeButton()
	{
		throw null;
	}

	public override void SetHudActive(bool active)
	{
		throw null;
	}

	private void UpdateButtonVisuals()
	{
		throw null;
	}

	private void OnSafeguardClicked()
	{
		throw null;
	}

	private void RpcSafeguard(SystemTypes roomId)
	{
		throw null;
	}

	private void ActivateSafeguard(SystemTypes roomId)
	{
		throw null;
	}

	public override bool CheckMurderGlobal(PlayerControl murderer, PlayerControl target)
	{
		throw null;
	}

	private void RpcNotifyBlocked(PlayerControl murderer)
	{
		throw null;
	}

	private static void ShowBlockedBanner()
	{
		throw null;
	}

	public override void HandleRpc(MessageReader reader, int rpc)
	{
		throw null;
	}

	private static ShipRoom GetRoomAt(Vector2 pos)
	{
		throw null;
	}

	private static ShipRoom GetRoomById(SystemTypes roomId)
	{
		throw null;
	}

	private void ShowShield(SystemTypes roomId)
	{
		throw null;
	}

	private void DestroyShield()
	{
		throw null;
	}

	public WardenRole()
	{
		throw null;
	}

	static WardenRole()
	{
		throw null;
	}
}
