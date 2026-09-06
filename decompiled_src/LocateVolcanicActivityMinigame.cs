using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LocateVolcanicActivityMinigame : Minigame
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Func<SpriteRenderer, bool> _003C_003E9__3_0;

		static _003C_003Ec()
		{
			throw null;
		}

		public _003C_003Ec()
		{
			throw null;
		}

		internal bool _003CCoClickTarget_003Eb__3_0(SpriteRenderer t)
		{
			throw null;
		}
	}

	private sealed class _003C_003Ec__DisplayClass2_0
	{
		public SpriteRenderer target;

		public LocateVolcanicActivityMinigame _003C_003E4__this;

		public _003C_003Ec__DisplayClass2_0()
		{
			throw null;
		}

		internal void _003CSetupTask_003Eb__0()
		{
			throw null;
		}
	}

	private sealed class _003CCoClickTarget_003Ed__3 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public LocateVolcanicActivityMinigame _003C_003E4__this;

		public SpriteRenderer target;

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

		public _003CCoClickTarget_003Ed__3(int _003C_003E1__state)
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

	private sealed class _003CCoFlashScreen_003Ed__6 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public LocateVolcanicActivityMinigame _003C_003E4__this;

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

		public _003CCoFlashScreen_003Ed__6(int _003C_003E1__state)
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

	private sealed class _003CCoScaleInwards_003Ed__4 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Transform self;

		public float source;

		public float target;

		public float duration;

		private float _003Ct_003E5__2;

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

		public _003CCoScaleInwards_003Ed__4(int _003C_003E1__state)
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

	private sealed class _003CCoWipeScreen_003Ed__5 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public LocateVolcanicActivityMinigame _003C_003E4__this;

		private Vector3 _003CoriginalPosition_003E5__2;

		private float _003Ct_003E5__3;

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

		public _003CCoWipeScreen_003Ed__5(int _003C_003E1__state)
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

	public AudioClip _failClick;

	private int _failures;

	private SpriteRenderer _fullScreen;

	private Transform _mask;

	private int _targetAmount;

	public AudioClip _targetClick;

	private List<SpriteRenderer> _targets;

	public void Reset()
	{
		throw null;
	}

	public override void Begin(PlayerTask task)
	{
		throw null;
	}

	public void SetupTask()
	{
		throw null;
	}

	public IEnumerator CoClickTarget(SpriteRenderer target)
	{
		throw null;
	}

	public IEnumerator CoScaleInwards(Transform self, float source, float target, float duration)
	{
		throw null;
	}

	public IEnumerator CoWipeScreen()
	{
		throw null;
	}

	public IEnumerator CoFlashScreen()
	{
		throw null;
	}

	public LocateVolcanicActivityMinigame()
	{
		throw null;
	}

	private void _003CBegin_003Eb__1_0()
	{
		throw null;
	}
}
