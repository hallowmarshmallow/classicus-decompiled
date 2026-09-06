using System;
using System.Collections;
using System.Collections.Generic;
using PowerTools;
using UnityEngine;

public class OverlayKillAnimation : OverlayAnimation
{
	private sealed class _003C_003Ec__DisplayClass12_0
	{
		public GameData.PlayerInfo kInfo;

		internal void _003CInitialize_003Eb__0(SpriteRenderer b)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass20_0
	{
		public KillOverlay parent;

		internal void _003CCoShow_003Eb__0(float t)
		{
		}
	}

	private sealed class _003CCoPlayKillSoundDelayed_003Ed__19 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public float delay;

		public OverlayKillAnimation _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CCoPlayKillSoundDelayed_003Ed__19(int _003C_003E1__state)
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

	private sealed class _003CCoShow_003Ed__20 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public KillOverlay parent;

		public OverlayKillAnimation _003C_003E4__this;

		private _003C_003Ec__DisplayClass20_0 _003C_003E8__1;

		private WaitForSeconds _003Cwait_003E5__2;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CCoShow_003Ed__20(int _003C_003E1__state)
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

	private sealed class _003CWaitForFinish_003Ed__21 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public OverlayKillAnimation _003C_003E4__this;

		private SpriteAnim[] _003Canims_003E5__2;

		private Animator[] _003Canimators_003E5__3;

		private float _003Cdeadline_003E5__4;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CWaitForFinish_003Ed__21(int _003C_003E1__state)
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

	public KillAnimType KillType;

	public PoolablePlayer killerParts;

	public PoolablePlayer victimParts;

	private string victimHatId;

	public AudioClip Stinger;

	public AudioClip Sfx;

	public float StingerVolume;

	public bool PlaySfxFromCode;

	public float SfxFromCodeDelay;

	[NonSerialized]
	public bool isMeetingOverlay;

	private const float PunchShootSfxDelay = 7f / 24f;

	private const float MaxOverlaySeconds = 6f;

	public virtual void Initialize(GameData.PlayerInfo kInfo, GameData.PlayerInfo vInfo)
	{
	}

	private void SetKillSkin(SpriteRenderer skinSlot, string skinId, int colorId, bool isKiller)
	{
	}

	private AnimationClip GetKillSkinClip(SkinData skin, bool isKiller)
	{
		return null;
	}

	private void SetKillPet(SpriteRenderer petSlot, string petId, int colorId, bool isKiller)
	{
	}

	private static void ApplyHatMaterial(HatParent hatSlot, int colorId)
	{
	}

	public void SetHatFloor()
	{
	}

	public void PlayKillSound()
	{
	}

	private IEnumerator CoPlayKillSoundDelayed(float delay)
	{
		return null;
	}

	public override IEnumerator CoShow(KillOverlay parent)
	{
		return null;
	}

	public IEnumerator WaitForFinish()
	{
		return null;
	}
}
