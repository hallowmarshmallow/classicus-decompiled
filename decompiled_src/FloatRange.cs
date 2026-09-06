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

		float IEnumerator<float>.Current
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

		public _003CSpreadToEdges_003Ed__27(int _003C_003E1__state)
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

		IEnumerator<float> IEnumerable<float>.GetEnumerator()
		{
			throw null;
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			throw null;
		}
	}

	public float min;

	public float max;

	private float _003CLast_003Ek__BackingField;

	public float Last
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

	public float Width
	{
		get
		{
			throw null;
		}
	}

	public FloatRange(float min, float max)
	{
		throw null;
	}

	public float ChangeRange(float y, float min, float max)
	{
		throw null;
	}

	public float Clamp(float value)
	{
		throw null;
	}

	public bool Contains(float t)
	{
		throw null;
	}

	public float LerpUnclamped(float v)
	{
		throw null;
	}

	public float Lerp(float v)
	{
		throw null;
	}

	public float ExpOutLerp(float v)
	{
		throw null;
	}

	public static float ExpOutLerp(float v, float min, float max)
	{
		throw null;
	}

	public static float Next(float min, float max)
	{
		throw null;
	}

	public float Next()
	{
		throw null;
	}

	internal float ReverseLerp(float t)
	{
		throw null;
	}

	public static float ReverseLerp(float t, float min, float max)
	{
		throw null;
	}

	public float SpreadToEdgesV2(int idx, int stops)
	{
		throw null;
	}

	public static IEnumerable<float> SpreadToEdges(float min, float max, int stops)
	{
		throw null;
	}
}
