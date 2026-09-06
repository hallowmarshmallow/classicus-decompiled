using System;
using UnityEngine;

public sealed class OracleRole : RoleBehaviour
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Action _003C_003E9__31_0;

		static _003C_003Ec()
		{
			throw null;
		}

		public _003C_003Ec()
		{
			throw null;
		}

		internal void _003CShowSuspectVision_003Eb__31_0()
		{
			throw null;
		}
	}

	private static readonly Color VisionColor;

	private static float _nextVisionAt;

	private static float _visionCooldownUntil;

	private static int _missStreak;

	private const float BaseTruthChance = 45f;

	private const float TruthStackStep = 15f;

	private float _minInterval;

	private float _maxInterval;

	private float _visionCooldown;

	private VanillaButtonManager _button;

	private static readonly string[] RoomTemplates;

	private static readonly string[] GenericVisions;

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

	private void OnVisionClicked()
	{
		throw null;
	}

	private static bool RollTruth()
	{
		throw null;
	}

	private void ShowVision()
	{
		throw null;
	}

	private void ShowRoomVision(bool truth)
	{
		throw null;
	}

	private void ShowSuspectVision(bool truth)
	{
		throw null;
	}

	private static PlayerControl FindRandomAliveImpostor()
	{
		throw null;
	}

	private static PlayerControl FindRandomAliveCrewmateExcluding(byte excludeId)
	{
		throw null;
	}

	private static PlayerControl FindNearestAliveCrewmate(Vector2 pos, byte excludeId)
	{
		throw null;
	}

	private static ShipRoom GetRoomAt(Vector2 pos)
	{
		throw null;
	}

	private static bool TryGetRandomRoomName(out string name)
	{
		throw null;
	}

	public OracleRole()
	{
		throw null;
	}

	static OracleRole()
	{
		throw null;
	}
}
