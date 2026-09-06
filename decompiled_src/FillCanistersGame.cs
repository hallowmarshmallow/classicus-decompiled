using System;
using System.Collections;
using System.Collections.Generic;
using Rewired;
using UnityEngine;

public class FillCanistersGame : Minigame
{
	private sealed class _003CRun_003Ed__17 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public FillCanistersGame _003C_003E4__this;

		private AudioSource _003CfillSound_003E5__2;

		private Player _003Cplayer_003E5__3;

		private float _003CstickInput_003E5__4;

		private bool _003ChasNoRemoveInput_003E5__5;

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

		public _003CRun_003Ed__17(int _003C_003E1__state)
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

	private Vector3 CanisterAppearPosition;

	private Vector3 CanisterStartPosition;

	private Vector3 CanisterDragPosition;

	private Vector3 CanisterSnapPosition;

	private Vector3 CanisterAwayPosition;

	public float FillTime;

	public CanisterBehaviour Canister;

	private Controller controller;

	public AudioClip FillLoop;

	public AudioClip DropSound;

	public AudioClip GrabSound;

	public AudioClip PlugInSound;

	public AudioClip PlugOutSound;

	private TouchpadBehavior touchpad;

	private bool prevHadInput;

	public void Start()
	{
		throw null;
	}

	public override void Close()
	{
		throw null;
	}

	private IEnumerator Run()
	{
		throw null;
	}

	public FillCanistersGame()
	{
		throw null;
	}

	private void _003CRun_003Eb__17_0(float value)
	{
		throw null;
	}
}
