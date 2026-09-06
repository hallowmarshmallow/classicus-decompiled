using System;
using System.Collections.Generic;
using Hazel;

public class SabotageSystemType : ISystemType
{
	public class DummySab : IActivatable
	{
		public float timer;

		public bool IsActive => false;
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Func<IActivatable, bool> _003C_003E9__12_0;

		public static Predicate<IActivatable> _003C_003E9__13_0;

		internal bool _003Cget_AnyActive_003Eb__12_0(IActivatable s)
		{
			return false;
		}

		internal bool _003C_002Ector_003Eb__13_0(IActivatable d)
		{
			return false;
		}
	}

	public const float SpecialSabDelay = 30f;

	private List<IActivatable> specials;

	private bool dirty;

	private DummySab dummy;

	private float _003CTimer_003Ek__BackingField;

	public float Timer
	{
		get
		{
			return _003CTimer_003Ek__BackingField;
		}
		set
		{
			_003CTimer_003Ek__BackingField = value;
		}
	}

	public float PercentCool => 0f;

	public bool AnyActive => false;

	public SabotageSystemType(IActivatable[] specials)
	{
	}

	public bool Detoriorate(float deltaTime)
	{
		return false;
	}

	public void RepairDamage(PlayerControl player, byte amount)
	{
	}

	public void Serialize(MessageWriter writer, bool initialState)
	{
	}

	public void Deserialize(MessageReader reader, bool initialState)
	{
	}
}
