using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeetingCalledAnimation : OverlayAnimation
{
	private sealed class _003C_003Ec__DisplayClass6_0
	{
		public AspectPosition playerTransform;

		public MeetingCalledAnimation _003C_003E4__this;

		public _003C_003Ec__DisplayClass6_0()
		{
			throw null;
		}

		internal void _003CCoShow_003Eb__0(float t)
		{
			throw null;
		}
	}

	private sealed class _003CCoShow_003Ed__6 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public MeetingCalledAnimation _003C_003E4__this;

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

		public _003CCoShow_003Ed__6(int _003C_003E1__state)
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

	public AudioClip Stinger;

	public float StingerVolume;

	public PoolablePlayer playerParts;

	public AnimationCurve CrewmateSlide;

	public AspectPosition emergencyText;

	public void Initialize(GameData.PlayerInfo reportInfo)
	{
		throw null;
	}

	public override IEnumerator CoShow(KillOverlay parent)
	{
		throw null;
	}

	public MeetingCalledAnimation()
	{
		throw null;
	}
}
