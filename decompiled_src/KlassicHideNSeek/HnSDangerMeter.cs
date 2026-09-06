using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace KlassicHideNSeek;

public class HnSDangerMeter : MonoBehaviour
{
	private sealed class _003CShakeForever_003Ed__17 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public HnSDangerMeter _003C_003E4__this;

		private float _003Cintensity_003E5__2;

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

		public _003CShakeForever_003Ed__17(int _003C_003E1__state)
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

	private SpriteRenderer[] barSprites;

	private SpriteRenderer crewmateSeekerSprite;

	private Color emptyColor;

	private Color safeColor;

	private Color cautionColor;

	private Color dangerColor;

	private Vector3 originalLocalPosition;

	private Coroutine shakeCoroutine;

	private static HnSDangerMeter _003CInstance_003Ek__BackingField;

	internal static HnSDangerMeter Instance
	{
		get
		{
			throw null;
		}
		private set
		{
			throw null;
		}
	}

	private void Awake()
	{
		throw null;
	}

	private void OnEnable()
	{
		throw null;
	}

	private void OnDestroy()
	{
		throw null;
	}

	public void SetDangerValue(float dangerLevel1, float dangerLevel2)
	{
		throw null;
	}

	private void SetFirstNBarColors(int numBars, Color color)
	{
		throw null;
	}

	private IEnumerator ShakeForever()
	{
		throw null;
	}

	public HnSDangerMeter()
	{
		throw null;
	}
}
