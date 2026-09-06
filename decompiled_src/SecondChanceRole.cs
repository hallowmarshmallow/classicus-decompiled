using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public sealed class SecondChanceRole : RoleBehaviour
{
	private struct Sample
	{
		public float Time;

		public Vector2 Pos;
	}

	private sealed class _003C_003Ec__DisplayClass23_0
	{
		public GameData.PlayerInfo target;

		public SecondChanceRole _003C_003E4__this;

		public _003C_003Ec__DisplayClass23_0()
		{
			throw null;
		}

		internal void _003COnClicked_003Eb__0()
		{
			throw null;
		}
	}

	private sealed class _003CCoPlayReplay_003Ed__25 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public byte targetId;

		private List<GameObject> _003Cghosts_003E5__2;

		private float _003CperStep_003E5__3;

		private float _003Cfade_003E5__4;

		private int _003Ci_003E5__5;

		object IEnumerator<object>.Current
		{
			get
			{
				throw null;
			}
		}

		object IEnumerator.Current
		{
			get
			{
				throw null;
			}
		}

		public _003CCoPlayReplay_003Ed__25(int _003C_003E1__state)
		{
			throw null;
		}

		void IDisposable.Dispose()
		{
			throw null;
		}

		private bool MoveNext()
		{
			throw null;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
			throw null;
		}
	}

	private const float HistorySeconds = 5f;

	private const float SampleInterval = 0.12f;

	private static readonly Dictionary<byte, List<Sample>> _history;

	private static float _nextSampleAt;

	private static float _cooldownUntil;

	private float _cooldown;

	private VanillaButtonManager _button;

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

	public override void OnFixedUpdate()
	{
		throw null;
	}

	private void RecordHistory()
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

	private void UpdateCooldown()
	{
		throw null;
	}

	private void OnClicked()
	{
		throw null;
	}

	private void StartReplay(byte targetId)
	{
		throw null;
	}

	private IEnumerator CoPlayReplay(byte targetId)
	{
		throw null;
	}

	private static ShipRoom GetRoomAt(Vector2 pos)
	{
		throw null;
	}

	public override void OnGameStart()
	{
		throw null;
	}

	public SecondChanceRole()
	{
		throw null;
	}

	static SecondChanceRole()
	{
		throw null;
	}
}
