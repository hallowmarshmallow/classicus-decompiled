using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClearUrchinsMinigame : Minigame
{
	private sealed class _003CShoot_003Ed__3 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ClearUrchinsMinigame _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CShoot_003Ed__3(int _003C_003E1__state)
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

	private sealed class _003CStopAndShrinkPellet_003Ed__4 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ClearUrchinsMinigame _003C_003E4__this;

		private Vector3 _003Cpos_003E5__2;

		private float _003Ct_003E5__3;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CStopAndShrinkPellet_003Ed__4(int _003C_003E1__state)
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

	private const float ANGLE_OFFSET = 137f;

	private const float PELLET_ANGLE_OFFSET = 47.3f;

	private readonly FloatRange _angleRange;

	private readonly List<Urchin> _urchins;

	private Camera _camera;

	private bool _finished;

	private Transform _gun;

	public AudioClip urchinHit;

	public AudioClip shoot;

	private Transform _pellet;

	private Rigidbody2D _pelletBody;

	private bool _shooting;

	private void Start()
	{
	}

	private void Update()
	{
	}

	private bool CheckFinished()
	{
		return false;
	}

	private IEnumerator Shoot()
	{
		return null;
	}

	public IEnumerator StopAndShrinkPellet()
	{
		return null;
	}
}
