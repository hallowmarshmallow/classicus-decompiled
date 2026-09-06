using System;
using System.Collections;
using System.Collections.Generic;

[Serializable]
public class FloatRange
{
	private sealed class _003CSpreadToEdges_003Ed__27 : IEnumerable<float>, IEnumerable, IEnumerator<float>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private float _003C_003E2__current;

		private int _003C_003El__initialThreadId;

		private int stops;

		public int _003C_003E3__stops;

		private float min;

		public float _003C_003E3__min;

		private float max;

		public float _003C_003E3__max;

		private int _003Ci_003E5__2;

		float IEnumerator<float>.Current => 0f;

		object IEnumerator.Current => null;

		public _003CSpreadToEdges_003Ed__27(int _003C_003E1__state)
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

		IEnumerator<float> IEnumerable<float>.GetEnumerator()
		{
			return null;
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	public float min;

	public float max;

	private float _003CLast_003Ek__BackingField;

	public float Last
	{
		get
		{
			return _003CLast_003Ek__BackingField;
		}
		private set
		{
			_003CLast_003Ek__BackingField = value;
		}
	}

	public float Width => 0f;

	public FloatRange(float min, float max)
	{
	}

	public float ChangeRange(float y, float min, float max)
	{
		return 0f;
	}

	public float Clamp(float value)
	{
		return 0f;
	}

	public bool Contains(float t)
	{
		return false;
	}

	public float LerpUnclamped(float v)
	{
		return 0f;
	}

	public float Lerp(float v)
	{
		return 0f;
	}

	public float ExpOutLerp(float v)
	{
		return 0f;
	}

	public static float ExpOutLerp(float v, float min, float max)
	{
		return 0f;
	}

	public static float Next(float min, float max)
	{
		return 0f;
	}

	public float Next()
	{
		return 0f;
	}

	internal float ReverseLerp(float t)
	{
		return 0f;
	}

	public static float ReverseLerp(float t, float min, float max)
	{
		return 0f;
	}

	public float SpreadToEdgesV2(int idx, int stops)
	{
		return 0f;
	}

	public static IEnumerable<float> SpreadToEdges(float min, float max, int stops)
	{
		return null;
	}
}
