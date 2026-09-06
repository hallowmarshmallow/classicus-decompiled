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

		internal PuddleBehaviour _003CStart_003Eb__0_0(Transform t)
		{
			return null;
		}
	}

	private sealed class _003CFinishTasks_003Ed__5 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public MopPuddlesMinigame _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CFinishTasks_003Ed__5(int _003C_003E1__state)
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
	}

	private void Update()
	{
	}

	private void UpdatePuddle()
	{
	}

	public void SetMopDirty()
	{
	}

	public void SetMopDry()
	{
	}

	private IEnumerator FinishTasks()
	{
		return null;
	}

	private void TryClose()
	{
	}

	private void _003CStart_003Eb__0_1()
	{
	}

	private void _003CStart_003Eb__0_2()
	{
	}
}
