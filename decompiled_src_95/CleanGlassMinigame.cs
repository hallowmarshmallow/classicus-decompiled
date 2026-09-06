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

		internal GameObject _003CStart_003Eb__0_0(Transform t)
		{
			return null;
		}
	}

	private sealed class _003CSparkle_003Ed__2 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CleanGlassMinigame _003C_003E4__this;

		private Animator _003Canim_003E5__2;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CSparkle_003Ed__2(int _003C_003E1__state)
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

	public GameObject[] smudges;

	public Draggable cloth;

	public List<GameObject> activeSmudges;

	public List<Smudge> activeSmudgeBehaviours;

	private bool _finished;

	public AudioClip[] windowAudios;

	private bool _hovering;

	private void Start()
	{
	}

	private void Update()
	{
	}

	private IEnumerator Sparkle()
	{
		return null;
	}

	private bool CheckComplete()
	{
		return false;
	}

	public void PlaySparkle()
	{
	}

	public void TryClose()
	{
	}

	private void _003CStart_003Eb__0_1()
	{
	}

	private void _003CStart_003Eb__0_2()
	{
	}
}
