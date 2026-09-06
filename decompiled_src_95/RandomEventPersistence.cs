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

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003COverrideMusicNextFrame_003Ed__27(int _003C_003E1__state)
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

	private void OnDestroy()
	{
	}

	public void Activate()
	{
	}

	private void SilenceStaffMusic(bool silence)
	{
	}

	private void LateUpdate()
	{
	}

	private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
	{
	}

	private IEnumerator OverrideMusicNextFrame()
	{
		return null;
	}

	private bool IsMenuScene(string sceneName)
	{
		return false;
	}

	private void SetupCameraBeat()
	{
	}

	private void UpdateCameraBeat()
	{
	}

	private void RestoreCamera()
	{
	}

	private void HandleMusicSwap()
	{
	}

	public void StopAndCleanup()
	{
	}
}
