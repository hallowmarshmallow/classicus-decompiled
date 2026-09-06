using System;
using UnityEngine;

public class LazyDestroy : MonoBehaviour
{
	private Action onDestroyCallback;

	public void Setup(Action callback)
	{
	}

	private void OnDestroy()
	{
	}
}
