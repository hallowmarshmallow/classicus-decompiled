using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmergencyMinigame : Minigame
{
	private sealed class _003CCoAnimateOpen_003Ed__13 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public EmergencyMinigame _003C_003E4__this;

		private Vector3 _003CmeetingPos_003E5__2;

		private float _003Ctimer2_003E5__3;

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

		public _003CCoAnimateOpen_003Ed__13(int _003C_003E1__state)
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

	public SpriteRenderer ClosedLid;

	public SpriteRenderer OpenLid;

	public Transform meetingButton;

	public TextRenderer StatusText;

	public TextRenderer NumberText;

	public bool ButtonActive;

	public AudioClip ButtonSound;

	private int state;

	public const int MinEmergencyTime = 15;

	public override void Begin(PlayerTask task)
	{
		throw null;
	}

	public void Update()
	{
		throw null;
	}

	public void CallMeeting()
	{
		throw null;
	}

	private float easeOutElastic(float t)
	{
		throw null;
	}

	protected override IEnumerator CoAnimateOpen()
	{
		throw null;
	}

	public EmergencyMinigame()
	{
		throw null;
	}
}
