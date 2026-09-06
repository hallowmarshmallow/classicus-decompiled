using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CleanGlassMinigame : Minigame
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Func<Transform, GameObject> _003C_003E9__0_0;

		static _003C_003Ec()
		{
			throw null;
		}

		public _003C_003Ec()
		{
			throw null;
		}

		internal GameObject _003CStart_003Eb__0_0(Transform t)
		{
			throw null;
		}
	}

	private sealed class _003CSparkle_003Ed__2 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CleanGlassMinigame _003C_003E4__this;

		private Animator _003Canim_003E5__2;

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

		public _003CSparkle_003Ed__2(int _003C_003E1__state)
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

	public GameObject[] smudges;

	public Draggable cloth;

	public List<GameObject> activeSmudges;

	public List<Smudge> activeSmudgeBehaviours;

	private bool _finished;

	public AudioClip[] windowAudios;

	private bool _hovering;

	private void Start()
	{
		throw null;
	}

	private void Update()
	{
		throw null;
	}

	private IEnumerator Sparkle()
	{
		throw null;
	}

	private bool CheckComplete()
	{
		throw null;
	}

	public void PlaySparkle()
	{
		throw null;
	}

	public void TryClose()
	{
		throw null;
	}

	public CleanGlassMinigame()
	{
		throw null;
	}

	private void _003CStart_003Eb__0_1()
	{
		throw null;
	}

	private void _003CStart_003Eb__0_2()
	{
		throw null;
	}
}
