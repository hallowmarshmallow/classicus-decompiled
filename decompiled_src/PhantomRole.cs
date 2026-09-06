using System;
using System.Collections;
using System.Collections.Generic;
using Hazel;
using UnityEngine;

public class PhantomRole : RoleBehaviour
{
	private sealed class _003C_003Ec__DisplayClass53_0
	{
		public PhantomRole _003C_003E4__this;

		public bool status;

		public _003C_003Ec__DisplayClass53_0()
		{
			throw null;
		}

		internal void _003CVanishFr_003Eb__0()
		{
			throw null;
		}
	}

	private sealed class _003CShakeForever_003Ed__43 : IEnumerator<object>, IEnumerator, IDisposable
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

		public _003CShakeForever_003Ed__43(int _003C_003E1__state)
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

	private sealed class _003CVanishFr_003Ed__53 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PhantomRole _003C_003E4__this;

		public bool status;

		private _003C_003Ec__DisplayClass53_0 _003C_003E8__1;

		private GameObject _003Cprefab_003E5__2;

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

		public _003CVanishFr_003Ed__53(int _003C_003E1__state)
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

	public VanillaButtonManager placeButton;

	private float _003CVanishTimer_003Ek__BackingField;

	private float _003CVanishDuration_003Ek__BackingField;

	private float _003CVanishCooldown_003Ek__BackingField;

	private bool vanished;

	private Coroutine shake;

	public AbilityButtonSettings abilitySettings;

	public GameObject vanishAnimPrefab;

	public GameObject appearAnimPrefab;

	public Sprite VanishActivate;

	public Sprite VanishDeactivate;

	private bool fading;

	private Renderer cachedPlaceButtonRenderer;

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

	public bool IsCoolingDown
	{
		get
		{
			throw null;
		}
	}

	public float VanishTimer
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

	public float VanishDuration
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

	public float VanishCooldown
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

	public override AudioClip IntroSound
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

	public void Update()
	{
		throw null;
	}

	public virtual void SetTargetV2()
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

	private void UpdateVanishTimer(float deltaTime)
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

	private void UpdatePlayerVisibility()
	{
		throw null;
	}

	public override void OnMeetingCalled()
	{
		throw null;
	}

	private void SetPlayerVisibility(bool visible, float alpha)
	{
		throw null;
	}

	internal bool CanCooldown()
	{
		throw null;
	}

	public VanillaButtonManager CreatePlaceButton(Transform parent)
	{
		throw null;
	}

	public void RpcVanish(bool status)
	{
		throw null;
	}

	public bool CanVanish()
	{
		throw null;
	}

	public void Vanish(bool status)
	{
		throw null;
	}

	public override void SetHudActive(bool isActive)
	{
		throw null;
	}

	private IEnumerator VanishFr(bool status)
	{
		throw null;
	}

	public override void HandleRpc(MessageReader reader, int rpc)
	{
		throw null;
	}

	public override void OnAssign(PlayerControl player)
	{
		throw null;
	}

	public PhantomRole()
	{
		throw null;
	}

	private void _003CCreatePlaceButton_003Eb__48_0()
	{
		throw null;
	}
}
