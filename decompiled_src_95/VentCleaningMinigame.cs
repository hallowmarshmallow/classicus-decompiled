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

		internal void _003CBegin_003Eb__19_0(SpriteRenderer s)
		{
		}

		internal void _003CBegin_003Eb__19_1(SpriteRenderer s)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass26_0
	{
		public VentCleaningMinigame _003C_003E4__this;

		public VentDirt dirt;

		internal void _003CSpawnDirt_003Eb__0()
		{
		}
	}

	private sealed class _003CCoOpenVent_003Ed__24 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public VentCleaningMinigame _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CCoOpenVent_003Ed__24(int _003C_003E1__state)
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

	private int VentId => 0;

	public override void Begin(PlayerTask task)
	{
	}

	public override void Close()
	{
	}

	public void OpenVent()
	{
	}

	private void FixedUpdate()
	{
	}

	private void HandleJoystick()
	{
	}

	private IEnumerator CoOpenVent()
	{
		return null;
	}

	private void CleanUp(VentDirt ventDirt)
	{
	}

	private void SpawnDirt()
	{
	}

	private void _003CCoOpenVent_003Eb__24_0(float t)
	{
	}
}
