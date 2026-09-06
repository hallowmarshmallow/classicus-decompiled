using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FeedPetFishMinigame : Minigame
{
	private sealed class _003C_003Ec__DisplayClass1_0
	{
		public System.Random random;

		public _003C_003Ec__DisplayClass1_0()
		{
			throw null;
		}

		internal int _003CStart_003Eb__0(int x)
		{
			throw null;
		}
	}

	private sealed class _003CRandomBob_003Ed__3 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Transform trans;

		public FeedPetFishMinigame _003C_003E4__this;

		private Vector3 _003CinitialPosition_003E5__2;

		private float _003Crng_003E5__3;

		private float _003Cduration_003E5__4;

		private float _003Ct_003E5__5;

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

		public _003CRandomBob_003Ed__3(int _003C_003E1__state)
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

	public AudioClip Pump;

	private readonly bool[] _completedSpecies;

	private readonly List<DraggableFeeder> _fishFood;

	private List<Transform> _fishGroup;

	private int[] _selectedSpecies;

	private void Start()
	{
		throw null;
	}

	public void UpdateCompletedStep(int index)
	{
		throw null;
	}

	public IEnumerator RandomBob(Transform trans)
	{
		throw null;
	}

	public override void Close()
	{
		throw null;
	}

	public FeedPetFishMinigame()
	{
		throw null;
	}
}
