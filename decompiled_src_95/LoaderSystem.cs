using System;
using UnityEngine;

public class LoaderSystem : MonoBehaviour
{
	public class Load : IDisposable
	{
		public void Dispose()
		{
		}
	}

	private static LoaderSystem _instance;

	private CanvasGroup _loaderVisual;

	private Transform _spinnerImage;

	private float _fadeSpeed;

	private float _target;

	private void Awake()
	{
	}

	private void ToggleLoader(bool on)
	{
	}

	private void Update()
	{
	}
}
