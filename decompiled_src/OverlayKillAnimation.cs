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

		public _003C_003Ec__DisplayClass12_0()
		{
			throw null;
		}

		internal void _003CInitialize_003Eb__0(SpriteRenderer b)
		{
			throw null;
		}
	}

	private sealed class _003C_003Ec__DisplayClass20_0
	{
		public KillOverlay parent;

		public _003C_003Ec__DisplayClass20_0()
		{
			throw null;
		}

		internal void _003CCoShow_003Eb__0(float t)
		{
			throw null;
		}
	}

	private sealed class _003CCoPlayKillSoundDelayed_003Ed__19 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public float delay;

		public OverlayKillAnimation _003C_003E4__this;

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

		public _003CCoPlayKillSoundDelayed_003Ed__19(int _003C_003E1__state)
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

	private sealed class _003CCoShow_003Ed__20 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public KillOverlay parent;

		public OverlayKillAnimation _003C_003E4__this;

		private _003C_003Ec__DisplayClass20_0 _003C_003E8__1;

		private WaitForSeconds _003Cwait_003E5__2;

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

		public _003CCoShow_003Ed__20(int _003C_003E1__state)
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

	private sealed class _003CWaitForFinish_003Ed__21 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public OverlayKillAnimation _003C_003E4__this;

		private SpriteAnim[] _003Canims_003E5__2;

		private Animator[] _003Canimators_003E5__3;

		private float _003Cdeadline_003E5__4;

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

		public _003CWaitForFinish_003Ed__21(int _003C_003E1__state)
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
		throw null;
	}

	private void SetKillSkin(SpriteRenderer skinSlot, string skinId, int colorId, bool isKiller)
	{
		throw null;
	}

	private AnimationClip GetKillSkinClip(SkinData skin, bool isKiller)
	{
		throw null;
	}

	private void SetKillPet(SpriteRenderer petSlot, string petId, int colorId, bool isKiller)
	{
		throw null;
	}

	private static void ApplyHatMaterial(HatParent hatSlot, int colorId)
	{
		throw null;
	}

	public void SetHatFloor()
	{
		throw null;
	}

	public void PlayKillSound()
	{
		throw null;
	}

	private IEnumerator CoPlayKillSoundDelayed(float delay)
	{
		throw null;
	}

	public override IEnumerator CoShow(KillOverlay parent)
	{
		throw null;
	}

	public IEnumerator WaitForFinish()
	{
		throw null;
	}

	public OverlayKillAnimation()
	{
		throw null;
	}
}
