using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiagnoseElevatorsMinigame : Minigame
{
	private sealed class _003CDoorAnimation_003Ed__2 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public DiagnoseElevatorsMinigame _003C_003E4__this;

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

		public _003CDoorAnimation_003Ed__2(int _003C_003E1__state)
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

	private sealed class _003CPrintTicket_003Ed__4 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public DiagnoseElevatorsMinigame _003C_003E4__this;

		private Vector3 _003CinitialPosition_003E5__2;

		private Vector3 _003CfinalPosition_003E5__3;

		private float _003Ct_003E5__4;

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

		public _003CPrintTicket_003Ed__4(int _003C_003E1__state)
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

	private sealed class _003CRipTicket_003Ed__6 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public DiagnoseElevatorsMinigame _003C_003E4__this;

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

		public _003CRipTicket_003Ed__6(int _003C_003E1__state)
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

	public ClickableSprite ticketButton;

	public ClickableSprite doorButton;

	public ClickableSprite diagnoseButton;

	public Sprite Ticket2;

	public AudioClip DoorOpen;

	public AudioClip DiagnoseClick;

	public Animator doorAnimator;

	public Transform ticketTransform;

	public AudioClip PrintSound;

	public Transform ticketFinalTransform;

	public DiagnoseDoorState diagnoseDoorState;

	public bool ticketPrinted;

	public AudioClip TearSound;

	private bool _clickedDiagnose;

	private bool _ticketClicked;

	private void Start()
	{
		throw null;
	}

	public void ClickDoor()
	{
		throw null;
	}

	public IEnumerator DoorAnimation()
	{
		throw null;
	}

	public void ClickDiagnose()
	{
		throw null;
	}

	public IEnumerator PrintTicket()
	{
		throw null;
	}

	public void ClickTicket()
	{
		throw null;
	}

	public IEnumerator RipTicket()
	{
		throw null;
	}

	public DiagnoseElevatorsMinigame()
	{
		throw null;
	}
}
