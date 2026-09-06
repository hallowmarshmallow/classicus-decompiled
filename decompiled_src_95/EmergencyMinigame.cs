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

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CCoAnimateOpen_003Ed__13(int _003C_003E1__state)
		{
		}

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
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
	}

	public void Update()
	{
	}

	public void CallMeeting()
	{
	}

	private float easeOutElastic(float t)
	{
		return 0f;
	}

	protected override IEnumerator CoAnimateOpen()
	{
		return null;
	}
}
