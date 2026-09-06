using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElevatorTransition : MonoBehaviour
{
	private sealed class _003CCloseDoors_003Ed__26 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ElevatorTransition _003C_003E4__this;

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

		public _003CCloseDoors_003Ed__26(int _003C_003E1__state)
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

	private sealed class _003CTeleportCoroutine_003Ed__25 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ElevatorTransition _003C_003E4__this;

		private Vector2 _003CentryPosition_003E5__2;

		private int _003CorigPlayerOrder_003E5__3;

		private int _003CorigSkinOrder_003E5__4;

		private int _003CorigHatFrontOrder_003E5__5;

		private int _003CorigHatBackOrder_003E5__6;

		private bool _003Ccompleted_003E5__7;

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

		public _003CTeleportCoroutine_003Ed__25(int _003C_003E1__state)
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

		private void _003C_003Em__Finally1()
		{
			throw null;
		}

		void IEnumerator.Reset()
		{
			throw null;
		}
	}

	public bool canDo;

	private float seconds;

	public AudioClip UseSound;

	private FollowerCamera ShakeyCamera;

	public ElevatorTransition TargetElevator;

	public GameObject Blackout;

	public PlainDoor thisDoor;

	private SpriteRenderer blackoutRend;

	public int Id;

	private float checkTimer;

	private bool isUpper
	{
		get
		{
			throw null;
		}
	}

	public bool Animating
	{
		get
		{
			throw null;
		}
	}

	public bool IsInside
	{
		get
		{
			throw null;
		}
	}

	public bool CanMove
	{
		get
		{
			throw null;
		}
	}

	public SpriteRenderer playerSprite
	{
		get
		{
			throw null;
		}
	}

	public void Awake()
	{
		throw null;
	}

	public void RpcSetDoorStatus(ElevatorTransition elevator, bool status)
	{
		throw null;
	}

	public void Start()
	{
		throw null;
	}

	public void TeleportToElevator()
	{
		throw null;
	}

	public void Update()
	{
		throw null;
	}

	public IEnumerator TeleportCoroutine()
	{
		throw null;
	}

	public IEnumerator CloseDoors()
	{
		throw null;
	}

	public ElevatorTransition()
	{
		throw null;
	}
}
