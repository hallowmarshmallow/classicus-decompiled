using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrystalBehaviour : MonoBehaviour
{
	private sealed class _003CFlash_003Ed__12 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public float delay;

		public CrystalBehaviour c;

		private Color _003Ccol_003E5__2;

		private float _003Ctime_003E5__3;

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

		public _003CFlash_003Ed__12(int _003C_003E1__state)
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

	public Transform TargetPosition;

	public SpriteRenderer Renderer;

	public BoxCollider2D Collider;

	public bool CanMove;

	public FloatRange Padding;

	private const float Speed = 15f;

	public float XFloatMag;

	private const float FloatMag = 0.05f;

	private const float FloatSpeed = 0.35f;

	public float PieceIndex;

	private void Update()
	{
		throw null;
	}

	public void Flash(float delay = 0f)
	{
		throw null;
	}

	private static IEnumerator Flash(CrystalBehaviour c, float delay)
	{
		throw null;
	}

	public CrystalBehaviour()
	{
		throw null;
	}
}
