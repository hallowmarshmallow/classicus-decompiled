using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillOverlay : MonoBehaviour
{
	private sealed class _003C_003Ec__DisplayClass13_0
	{
		public OverlayKillAnimation killAnimation;

		public KillOverlay _003C_003E4__this;

		public GameData.PlayerInfo killer;

		public GameData.PlayerInfo victim;

		public _003C_003Ec__DisplayClass13_0()
		{
			throw null;
		}

		internal IEnumerator _003CShowKillAnimation_003Eb__0()
		{
			throw null;
		}
	}

	private sealed class _003C_003Ec__DisplayClass14_0
	{
		public OverlayKillAnimation prefab;

		public KillOverlay _003C_003E4__this;

		public GameData.PlayerInfo playerInfo;

		public _003C_003Ec__DisplayClass14_0()
		{
			throw null;
		}

		internal IEnumerator _003CShowMeeting_003Eb__0()
		{
			throw null;
		}
	}

	private sealed class _003CCoShowOne_003Ed__16 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public OverlayAnimation anim;

		public KillOverlay _003C_003E4__this;

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

		public _003CCoShowOne_003Ed__16(int _003C_003E1__state)
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

	private sealed class _003CCoShowOne_003Ed__17 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public OverlayKillAnimation anim;

		public KillOverlay _003C_003E4__this;

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

		public _003CCoShowOne_003Ed__17(int _003C_003E1__state)
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

	private sealed class _003CShowAll_003Ed__15 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public KillOverlay _003C_003E4__this;

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

		public _003CShowAll_003Ed__15(int _003C_003E1__state)
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

	private sealed class _003CWaitForFinish_003Ed__11 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public KillOverlay _003C_003E4__this;

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

		public _003CWaitForFinish_003Ed__11(int _003C_003E1__state)
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

	public SpriteRenderer background;

	public GameObject flameParent;

	public OverlayKillAnimation[] KillAnims;

	public float FadeTime;

	public OverlayKillAnimation EmergencyOverlay;

	public OverlayKillAnimation ReportOverlay;

	private Queue<Func<IEnumerator>> queue;

	private Coroutine showAll;

	private Coroutine showOne;

	public bool IsOpen
	{
		get
		{
			throw null;
		}
	}

	public IEnumerator WaitForFinish()
	{
		throw null;
	}

	public void ShowKillAnimation(GameData.PlayerInfo killer, GameData.PlayerInfo victim)
	{
		throw null;
	}

	public void ShowKillAnimation(OverlayKillAnimation killAnimation, GameData.PlayerInfo killer, GameData.PlayerInfo victim)
	{
		throw null;
	}

	public void ShowMeeting(OverlayKillAnimation prefab, GameData.PlayerInfo playerInfo)
	{
		throw null;
	}

	private IEnumerator ShowAll()
	{
		throw null;
	}

	private IEnumerator CoShowOne(OverlayAnimation anim)
	{
		throw null;
	}

	private IEnumerator CoShowOne(OverlayKillAnimation anim)
	{
		throw null;
	}

	public KillOverlay()
	{
		throw null;
	}
}
