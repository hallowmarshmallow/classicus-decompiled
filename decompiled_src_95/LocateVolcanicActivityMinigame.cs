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

		internal bool _003CCoClickTarget_003Eb__3_0(SpriteRenderer t)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass2_0
	{
		public SpriteRenderer target;

		public LocateVolcanicActivityMinigame _003C_003E4__this;

		internal void _003CSetupTask_003Eb__0()
		{
		}
	}

	private sealed class _003CCoClickTarget_003Ed__3 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public LocateVolcanicActivityMinigame _003C_003E4__this;

		public SpriteRenderer target;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CCoClickTarget_003Ed__3(int _003C_003E1__state)
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

	private sealed class _003CCoFlashScreen_003Ed__6 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public LocateVolcanicActivityMinigame _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CCoFlashScreen_003Ed__6(int _003C_003E1__state)
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

	private sealed class _003CCoScaleInwards_003Ed__4 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Transform self;

		public float source;

		public float target;

		public float duration;

		private float _003Ct_003E5__2;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CCoScaleInwards_003Ed__4(int _003C_003E1__state)
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

	private sealed class _003CCoWipeScreen_003Ed__5 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public LocateVolcanicActivityMinigame _003C_003E4__this;

		private Vector3 _003CoriginalPosition_003E5__2;

		private float _003Ct_003E5__3;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CCoWipeScreen_003Ed__5(int _003C_003E1__state)
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

	public AudioClip _failClick;

	private int _failures;

	private SpriteRenderer _fullScreen;

	private Transform _mask;

	private int _targetAmount;

	public AudioClip _targetClick;

	private List<SpriteRenderer> _targets;

	public void Reset()
	{
	}

	public override void Begin(PlayerTask task)
	{
	}

	public void SetupTask()
	{
	}

	public IEnumerator CoClickTarget(SpriteRenderer target)
	{
		return null;
	}

	public IEnumerator CoScaleInwards(Transform self, float source, float target, float duration)
	{
		return null;
	}

	public IEnumerator CoWipeScreen()
	{
		return null;
	}

	public IEnumerator CoFlashScreen()
	{
		return null;
	}

	private void _003CBegin_003Eb__1_0()
	{
	}
}
