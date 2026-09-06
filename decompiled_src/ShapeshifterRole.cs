using System;
using System.Collections;
using System.Collections.Generic;
using Hazel;
using UnityEngine;

public class ShapeshifterRole : RoleBehaviour
{
	private sealed class _003C_003Ec__DisplayClass57_0
	{
		public GameData.PlayerInfo target;

		public ShapeshifterRole _003C_003E4__this;

		public _003C_003Ec__DisplayClass57_0()
		{
			throw null;
		}

		internal void _003COpenSSMenu_003Eb__0()
		{
			throw null;
		}
	}

	private sealed class _003C_003Ec__DisplayClass60_0
	{
		public GameData.PlayerInfo target;

		public ShapeshifterRole _003C_003E4__this;

		public bool reverting;

		public Action changeOutfit;

		public _003C_003Ec__DisplayClass60_0()
		{
			throw null;
		}

		internal void _003CShapeshift_003Eb__0()
		{
			throw null;
		}

		internal void _003CShapeshift_003Eb__1()
		{
			throw null;
		}

		internal void _003CShapeshift_003Eb__2()
		{
			throw null;
		}
	}

	private sealed class _003CShakeForever_003Ed__50 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Transform target;

		public float halfWidth;

		private Vector3 _003Corigin_003E5__2;

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

		public _003CShakeForever_003Ed__50(int _003C_003E1__state)
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

	public AbilityButtonSettings abilitySettings;

	public EffectAnimation thing;

	private bool shapeshifting;

	private VanillaButtonManager shapeshiftButton;

	private GameData.PlayerInfo currentShifted;

	private bool _003CLeaveEvidence_003Ek__BackingField;

	public GameObject EvidencePrefab;

	public List<GameObject> EvidenceList;

	private float _003CShiftTimer_003Ek__BackingField;

	private float _003CShiftDuration_003Ek__BackingField;

	private float _003CShiftCooldown_003Ek__BackingField;

	private readonly Vector3 EvidenceOffset;

	private Coroutine shake;

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

	public bool LeaveEvidence
	{
		get
		{
			throw null;
		}
		private set
		{
			throw null;
		}
	}

	public bool IsCoolingDown
	{
		get
		{
			throw null;
		}
	}

	public float ShiftTimer
	{
		get
		{
			throw null;
		}
		private set
		{
			throw null;
		}
	}

	public float ShiftDuration
	{
		get
		{
			throw null;
		}
		private set
		{
			throw null;
		}
	}

	public float ShiftCooldown
	{
		get
		{
			throw null;
		}
		private set
		{
			throw null;
		}
	}

	public bool shifted
	{
		get
		{
			throw null;
		}
	}

	public override AudioClip IntroSound
	{
		get
		{
			throw null;
		}
	}

	private bool CanShift
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

	public override void OnFixedUpdate()
	{
		throw null;
	}

	public override void SetHudActive(bool active)
	{
		throw null;
	}

	private void InitializeButton()
	{
		throw null;
	}

	public void SetVanishTimer(float time)
	{
		throw null;
	}

	private void UpdateShiftTimer(float deltaTime)
	{
		throw null;
	}

	private void UpdateButton()
	{
		throw null;
	}

	private void UpdateButtonText()
	{
		throw null;
	}

	public static IEnumerator ShakeForever(Transform target, float halfWidth)
	{
		throw null;
	}

	private VanillaButtonManager CreateSSButton(Transform parent)
	{
		throw null;
	}

	public override void OnMeetingCalled()
	{
		throw null;
	}

	public void OnDestroy()
	{
		throw null;
	}

	public void CreateEvidence()
	{
		throw null;
	}

	public void DestroyAllEvidence()
	{
		throw null;
	}

	public DeadBody GetBodyById(int id)
	{
		throw null;
	}

	public void OpenSSMenu()
	{
		throw null;
	}

	public void RpcShapeshift(GameData.PlayerInfo target, bool shouldAnimate)
	{
		throw null;
	}

	public override void HandleRpc(MessageReader reader, int rpc)
	{
		throw null;
	}

	public void Shapeshift(GameData.PlayerInfo target, bool animate)
	{
		throw null;
	}

	public override void OnAssign(PlayerControl player)
	{
		throw null;
	}

	public ShapeshifterRole()
	{
		throw null;
	}
}
