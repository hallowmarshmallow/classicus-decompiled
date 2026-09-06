using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MopPuddlesMinigame : Minigame
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Func<Transform, PuddleBehaviour> _003C_003E9__0_0;

		static _003C_003Ec()
		{
			throw null;
		}

		public _003C_003Ec()
		{
			throw null;
		}

		internal PuddleBehaviour _003CStart_003Eb__0_0(Transform t)
		{
			throw null;
		}
	}

	private sealed class _003CFinishTasks_003Ed__5 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public MopPuddlesMinigame _003C_003E4__this;

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

		public _003CFinishTasks_003Ed__5(int _003C_003E1__state)
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

	public PolishRubyGame minigameProperties;

	public Transform Puddles;

	public Transform[] puddleTransforms;

	public Transform bucketWater;

	public Transform mop;

	public Draggable mopDraggable;

	public Material bucketBackMat;

	public Transform bucketTarget;

	public List<PuddleBehaviour> puddles;

	public int driedPuddles;

	public bool mopDirty;

	public GameObject wetMop;

	public GameObject dryMop;

	public Transform mopHead;

	private bool _blockClose;

	private Vector3 _bucketWaterEndPos;

	private Vector3 _bucketWaterStartPos;

	private void Start()
	{
		throw null;
	}

	private void Update()
	{
		throw null;
	}

	private void UpdatePuddle()
	{
		throw null;
	}

	public void SetMopDirty()
	{
		throw null;
	}

	public void SetMopDry()
	{
		throw null;
	}

	private IEnumerator FinishTasks()
	{
		throw null;
	}

	private void TryClose()
	{
		throw null;
	}

	public MopPuddlesMinigame()
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
