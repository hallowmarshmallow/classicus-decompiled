using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AuthGame : Minigame
{
	private sealed class _003CAnimate_003Ed__21 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public AuthGame _003C_003E4__this;

		private WaitForSeconds _003Cwait_003E5__2;

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

		public _003CAnimate_003Ed__21(int _003C_003E1__state)
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

	public TextRenderer TargetText;

	public TextRenderer NumberText;

	public TextRenderer OtherStatusText;

	public int number;

	public string numString;

	private bool animating;

	private HqHudSystemType system;

	public SpriteRenderer OurLight;

	public SpriteRenderer TheirLight;

	public SpriteRenderer TimeBar;

	public AudioClip ButtonSound;

	public AudioClip AcceptSound;

	public AudioClip RejectSound;

	private int OtherConsoleId;

	private bool evenColor;

	public override void Begin(PlayerTask task)
	{
		throw null;
	}

	public override void Close()
	{
		throw null;
	}

	public void Update()
	{
		throw null;
	}

	public void ClickNumber(int i)
	{
		throw null;
	}

	public void ClearEntry()
	{
		throw null;
	}

	public void Enter()
	{
		throw null;
	}

	private IEnumerator Animate()
	{
		throw null;
	}

	public AuthGame()
	{
		throw null;
	}
}
