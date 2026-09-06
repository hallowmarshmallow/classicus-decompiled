using System;
using System.Collections;
using System.Collections.Generic;
using Hazel;
using InnerNet;
using UnityEngine;

public class LobbyBehaviour : InnerNetObject
{
	private sealed class _003CDelayPlayDropshipAmbience_003Ed__13 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public LobbyBehaviour _003C_003E4__this;

		private AudioSource _003CintroSource_003E5__2;

		private float _003Celapsed_003E5__3;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CDelayPlayDropshipAmbience_003Ed__13(int _003C_003E1__state)
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

	public static LobbyBehaviour Instance;

	public AudioClip SpawnSound;

	public Color CameraColor;

	public Vector2[] SpawnPositions;

	public AudioClip DropShipSound;

	public SoundManager.MixerTypes DropShipMixer;

	public AudioClip MapTheme;

	public AudioClip MapThemeIntro;

	public float MapThemeIntroFadeIn;

	public SoundManager.MixerTypes MapThemeMixer;

	public ShipRoom[] AllRooms;

	private float timer;

	private const float MapThemeBaseVolume = 0.2f;

	private AudioSource mapThemeIntroSource;

	private AudioSource mapThemeLoopSource;

	private bool mapThemeIntroFadeDone;

	private static float MapThemeGain => 0f;

	public void Start()
	{
	}

	public IEnumerator DelayPlayDropshipAmbience()
	{
		return null;
	}

	public void Update()
	{
	}

	public void FixedUpdate()
	{
	}

	public override void OnDestroy()
	{
	}

	public override void HandleRpc(byte callId, MessageReader reader)
	{
	}

	public override bool Serialize(MessageWriter writer, bool initialState)
	{
		return false;
	}

	public override void Deserialize(MessageReader reader, bool initialState)
	{
	}
}
