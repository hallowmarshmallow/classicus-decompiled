using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RandomEventPersistence : MonoBehaviour
{
	private sealed class _003COverrideMusicNextFrame_003Ed__27 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public RandomEventPersistence _003C_003E4__this;

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

		public _003COverrideMusicNextFrame_003Ed__27(int _003C_003E1__state)
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

	private const string LOG_TAG = "[RandomEventPersistence]";

	private static RandomEventPersistence _003CInstance_003Ek__BackingField;

	public bool cameraBeatEnabled;

	public float beatBPM;

	public float beatBounceStrength;

	public float beatSmoothSpeed;

	public AudioClip replacementMusic;

	public string replacementMusicName;

	public float replacementMusicVolume;

	public string originalMusicChannelName;

	public string[] menuScenes;

	public bool neverStopTheParty;

	private Camera mainCamera;

	private float baseCameraOrthoSize;

	private float nextBeatTime;

	private float currentZoomOffset;

	private bool effectsRunning;

	private bool projectionOverridden;

	public static RandomEventPersistence Instance
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

	private void OnDestroy()
	{
		throw null;
	}

	public void Activate()
	{
		throw null;
	}

	private void SilenceStaffMusic(bool silence)
	{
		throw null;
	}

	private void LateUpdate()
	{
		throw null;
	}

	private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
	{
		throw null;
	}

	private IEnumerator OverrideMusicNextFrame()
	{
		throw null;
	}

	private bool IsMenuScene(string sceneName)
	{
		throw null;
	}

	private void SetupCameraBeat()
	{
		throw null;
	}

	private void UpdateCameraBeat()
	{
		throw null;
	}

	private void RestoreCamera()
	{
		throw null;
	}

	private void HandleMusicSwap()
	{
		throw null;
	}

	public void StopAndCleanup()
	{
		throw null;
	}

	public RandomEventPersistence()
	{
		throw null;
	}
}
