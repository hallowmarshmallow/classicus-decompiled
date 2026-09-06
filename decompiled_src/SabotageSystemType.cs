using System;
using System.Collections.Generic;
using Hazel;

public class SabotageSystemType : ISystemType
{
	public class DummySab : IActivatable
	{
		public float timer;

		public bool IsActive
		{
			get
			{
				throw null;
			}
		}

		public DummySab()
		{
			throw null;
		}
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Func<IActivatable, bool> _003C_003E9__12_0;

		public static Predicate<IActivatable> _003C_003E9__13_0;

		static _003C_003Ec()
		{
			throw null;
		}

		public _003C_003Ec()
		{
			throw null;
		}

		internal bool _003Cget_AnyActive_003Eb__12_0(IActivatable s)
		{
			throw null;
		}

		internal bool _003C_002Ector_003Eb__13_0(IActivatable d)
		{
			throw null;
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
			throw null;
		}
		set
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

	public bool AnyActive
	{
		get
		{
			throw null;
		}
	}

	public SabotageSystemType(IActivatable[] specials)
	{
		throw null;
	}

	public bool Detoriorate(float deltaTime)
	{
		throw null;
	}

	public void RepairDamage(PlayerControl player, byte amount)
	{
		throw null;
	}

	public void Serialize(MessageWriter writer, bool initialState)
	{
		throw null;
	}

	public void Deserialize(MessageReader reader, bool initialState)
	{
		throw null;
	}
}
