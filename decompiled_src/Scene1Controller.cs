using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene1Controller : SceneController
{
	private sealed class _003CDoUse_003Ed__8 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Scene1Controller _003C_003E4__this;

		public int idx;

		public int consoleid;

		private PlayerAnimator _003CmyPlayer_003E5__2;

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

		public _003CDoUse_003Ed__8(int _003C_003E1__state)
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

	private sealed class _003CRunPlayer_003Ed__7 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Scene1Controller _003C_003E4__this;

		public int idx;

		private PlayerAnimator _003CmyPlayer_003E5__2;

		private int _003Ci_003E5__3;

		private bool _003CwillInterrupt_003E5__4;

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

		public _003CRunPlayer_003Ed__7(int _003C_003E1__state)
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

	private sealed class _003CWaitForSeconds_003Ed__9 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public float duration;

		private float _003Ctime_003E5__2;

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

		public _003CWaitForSeconds_003Ed__9(int _003C_003E1__state)
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

	public PlayerAnimator[] players;

	public DummyConsole[] Consoles;

	public Vector2[] WayPoints;

	public Camera backupCam;

	public void OnDrawGizmos()
	{
		throw null;
	}

	public void OnEnable()
	{
		throw null;
	}

	public void OnDisable()
	{
		throw null;
	}

	private IEnumerator RunPlayer(int idx)
	{
		throw null;
	}

	private IEnumerator DoUse(int idx, int consoleid)
	{
		throw null;
	}

	public static IEnumerator WaitForSeconds(float duration)
	{
		throw null;
	}

	public Scene1Controller()
	{
		throw null;
	}
}
