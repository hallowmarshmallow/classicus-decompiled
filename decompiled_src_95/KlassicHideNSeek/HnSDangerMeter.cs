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

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CShakeForever_003Ed__17(int _003C_003E1__state)
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
			return _003CInstance_003Ek__BackingField;
		}
		private set
		{
			_003CInstance_003Ek__BackingField = value;
		}
	}

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDestroy()
	{
	}

	public void SetDangerValue(float dangerLevel1, float dangerLevel2)
	{
	}

	private void SetFirstNBarColors(int numBars, Color color)
	{
	}

	private IEnumerator ShakeForever()
	{
		return null;
	}
}
