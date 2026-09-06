using System;
using System.Collections;

public class WaitForLerp : IEnumerator
{
	private float duration;

	private float timer;

	private Action<float> act;

	public object Current
	{
		get
		{
			throw null;
		}
	}

	public WaitForLerp(float seconds, Action<float> act)
	{
		throw null;
	}

	public bool MoveNext()
	{
		throw null;
	}

	public void Reset()
	{
		throw null;
	}
}
