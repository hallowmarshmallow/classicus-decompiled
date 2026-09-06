using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NavigationMinigame : Minigame
{
	private sealed class _003CCompleteGame_003Ed__8 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public NavigationMinigame _003C_003E4__this;

		private WaitForSeconds _003Cwait_003E5__2;

		private Color _003Cgreen_003E5__3;

		private Color32 _003Cyellow_003E5__4;

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

		public _003CCompleteGame_003Ed__8(int _003C_003E1__state)
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

	public MeshRenderer TwoAxisImage;

	public SpriteRenderer CrossHairImage;

	public Collider2D hitbox;

	private Controller myController;

	private Vector2 crossHair;

	private Vector2 half;

	public override void Begin(PlayerTask task)
	{
		throw null;
	}

	public void FixedUpdate()
	{
		throw null;
	}

	private IEnumerator CompleteGame()
	{
		throw null;
	}

	public NavigationMinigame()
	{
		throw null;
	}
}
