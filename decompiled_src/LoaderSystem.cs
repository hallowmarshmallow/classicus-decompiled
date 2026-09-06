using System;
using UnityEngine;

public class LoaderSystem : MonoBehaviour
{
	public class Load : IDisposable
	{
		public Load()
		{
			throw null;
		}

		public void Dispose()
		{
			throw null;
		}
	}

	private static LoaderSystem _instance;

	private CanvasGroup _loaderVisual;

	private Transform _spinnerImage;

	private float _fadeSpeed;

	private float _target;

	private void Awake()
	{
		throw null;
	}

	private void ToggleLoader(bool on)
	{
		throw null;
	}

	private void Update()
	{
		throw null;
	}

	public LoaderSystem()
	{
		throw null;
	}
}
