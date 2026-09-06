using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AirshipStatus : ShipStatus
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Func<ISystemType, bool> _003C_003E9__8_0;

		static _003C_003Ec()
		{
			throw null;
		}

		public _003C_003Ec()
		{
			throw null;
		}

		internal bool _003CAddSystems_003Eb__8_0(ISystemType i)
		{
			throw null;
		}
	}

	private sealed class _003CPrespawnStep_003Ed__9 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public AirshipStatus _003C_003E4__this;

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

		public _003CPrespawnStep_003Ed__9(int _003C_003E1__state)
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

	public SpawnInMinigame SpawnInGame;

	public MovingPlatformBehaviour GapPlatform;

	public ParticleSystem ShowerParticles;

	public LightAffector[] LightAffectors;

	public GameObject outOfOrderPlat;

	public Minigame UploadGame;

	public AudioClip ReactorSabotageSound;

	public override void Awake()
	{
		throw null;
	}

	public override void AddSystems()
	{
		throw null;
	}

	public override IEnumerator PrespawnStep()
	{
		throw null;
	}

	public override void SetupCustomStrings()
	{
		throw null;
	}

	public AirshipStatus()
	{
		throw null;
	}
}
