using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VentCleaningMinigame : Minigame
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Action<SpriteRenderer> _003C_003E9__19_0;

		public static Action<SpriteRenderer> _003C_003E9__19_1;

		static _003C_003Ec()
		{
			throw null;
		}

		public _003C_003Ec()
		{
			throw null;
		}

		internal void _003CBegin_003Eb__19_0(SpriteRenderer s)
		{
			throw null;
		}

		internal void _003CBegin_003Eb__19_1(SpriteRenderer s)
		{
			throw null;
		}
	}

	private sealed class _003C_003Ec__DisplayClass26_0
	{
		public VentCleaningMinigame _003C_003E4__this;

		public VentDirt dirt;

		public _003C_003Ec__DisplayClass26_0()
		{
			throw null;
		}

		internal void _003CSpawnDirt_003Eb__0()
		{
			throw null;
		}
	}

	private sealed class _003CCoOpenVent_003Ed__24 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public VentCleaningMinigame _003C_003E4__this;

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

		public _003CCoOpenVent_003Ed__24(int _003C_003E1__state)
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

	public FloatRange XSpan;

	public FloatRange YSpan;

	public ObjectPoolBehavior dirtPool;

	public GameObject ventLidClosed;

	public GameObject ventLidOpened;

	public UiElement backButton;

	public AudioClip VentOpenSound;

	public AudioClip ImpostorDiscoveredSound;

	public AudioClip CleanedSound;

	public SpriteRenderer[] SpiderWebs;

	public float cleaningDistanceThreshold;

	public Transform selectorObject;

	public SpriteRenderer selectorHand;

	private int numberOfDirts;

	private int numberOfDirtsCleanedUp;

	private bool ventOpen;

	private VentilationSystem ventSystem;

	private int VentId
	{
		get
		{
			throw null;
		}
	}

	public override void Begin(PlayerTask task)
	{
		throw null;
	}

	public override void Close()
	{
		throw null;
	}

	public void OpenVent()
	{
		throw null;
	}

	private void FixedUpdate()
	{
		throw null;
	}

	private void HandleJoystick()
	{
		throw null;
	}

	private IEnumerator CoOpenVent()
	{
		throw null;
	}

	private void CleanUp(VentDirt ventDirt)
	{
		throw null;
	}

	private void SpawnDirt()
	{
		throw null;
	}

	public VentCleaningMinigame()
	{
		throw null;
	}

	private void _003CCoOpenVent_003Eb__24_0(float t)
	{
		throw null;
	}
}
