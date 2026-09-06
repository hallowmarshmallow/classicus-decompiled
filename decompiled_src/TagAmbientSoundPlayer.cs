using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TagAmbientSoundPlayer : MonoBehaviour
{
	private sealed class _003CRun_003Ed__7 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public TagAmbientSoundPlayer _003C_003E4__this;

		private ContactFilter2D _003Cfilter_003E5__2;

		private Collider2D[] _003Cbuffer_003E5__3;

		private WaitForSeconds _003Cwait_003E5__4;

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

		public _003CRun_003Ed__7(int _003C_003E1__state)
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

	public AudioClip AmbientSound;

	public float MaxVolume;

	public string TargetTag;

	private float targetVolume;

	public void Start()
	{
		throw null;
	}

	private void Dynamics(AudioSource source, float dt)
	{
		throw null;
	}

	public void OnDestroy()
	{
		throw null;
	}

	private IEnumerator Run()
	{
		throw null;
	}

	public TagAmbientSoundPlayer()
	{
		throw null;
	}
}
