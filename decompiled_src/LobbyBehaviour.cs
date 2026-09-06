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

		public _003CDelayPlayDropshipAmbience_003Ed__13(int _003C_003E1__state)
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

	private static float MapThemeGain
	{
		get
		{
			throw null;
		}
	}

	public void Start()
	{
		throw null;
	}

	public IEnumerator DelayPlayDropshipAmbience()
	{
		throw null;
	}

	public void Update()
	{
		throw null;
	}

	public void FixedUpdate()
	{
		throw null;
	}

	public override void OnDestroy()
	{
		throw null;
	}

	public override void HandleRpc(byte callId, MessageReader reader)
	{
		throw null;
	}

	public override bool Serialize(MessageWriter writer, bool initialState)
	{
		throw null;
	}

	public override void Deserialize(MessageReader reader, bool initialState)
	{
		throw null;
	}

	public LobbyBehaviour()
	{
		throw null;
	}
}
