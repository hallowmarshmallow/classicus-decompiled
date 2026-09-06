using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterPlantsGame : Minigame
{
	private sealed class _003CCoGrowPlant_003Ed__16 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public WaterPlantsGame _003C_003E4__this;

		public int num;

		private SpriteRenderer _003Cplant_003E5__2;

		private float _003Ctimer3_003E5__3;

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

		public _003CCoGrowPlant_003Ed__16(int _003C_003E1__state)
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

	private sealed class _003CCoPickWaterCan_003Ed__14 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public WaterPlantsGame _003C_003E4__this;

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

		public _003CCoPickWaterCan_003Ed__14(int _003C_003E1__state)
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

	public GameObject stage1;

	public GameObject stage2;

	public AudioClip CanGrabSound;

	public PassiveButton WaterCan;

	public SpriteRenderer[] Plants;

	public AudioClip WaterPlantSound;

	public AudioClip[] PlantGrowSounds;

	public AudioClip[] PlantFinishedSounds;

	public TextRenderer FloatText;

	public Transform[] Locations;

	private bool Watered(int x)
	{
		throw null;
	}

	private void Watered(int x, bool b)
	{
		throw null;
	}

	public override void Begin(PlayerTask task)
	{
		throw null;
	}

	public void PickWaterCan()
	{
		throw null;
	}

	private IEnumerator CoPickWaterCan()
	{
		throw null;
	}

	public void WaterPlant(int num)
	{
		throw null;
	}

	private IEnumerator CoGrowPlant(int num)
	{
		throw null;
	}

	public WaterPlantsGame()
	{
		throw null;
	}
}
