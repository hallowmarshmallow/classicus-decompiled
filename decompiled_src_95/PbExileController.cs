using System;
using System.Collections;
using System.Collections.Generic;
using PowerTools;
using UnityEngine;

public class PbExileController : ExileController
{
	private sealed class _003CAnimate_003Ed__12 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PbExileController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CAnimate_003Ed__12(int _003C_003E1__state)
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

	private sealed class _003CCoFinalSink_003Ed__16 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PbExileController _003C_003E4__this;

		private Vector2 _003Cbottom_003E5__2;

		private Vector2 _003CpaddedBottom_003E5__3;

		private float _003Cd4_003E5__4;

		private float _003Ct_003E5__5;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CCoFinalSink_003Ed__16(int _003C_003E1__state)
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

	private sealed class _003CHandleText_003Ed__13 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public float waitTime;

		public float textDuration;

		public PbExileController _003C_003E4__this;

		private float _003Ct_003E5__2;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CHandleText_003Ed__13(int _003C_003E1__state)
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

	private sealed class _003CPlayerFall_003Ed__14 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PbExileController _003C_003E4__this;

		private Vector2 _003Ctop_003E5__2;

		private Vector2 _003Cbottom_003E5__3;

		private bool _003Cstarted_003E5__4;

		private float _003Cd1_003E5__5;

		private float _003Ct_003E5__6;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CPlayerFall_003Ed__14(int _003C_003E1__state)
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

	private sealed class _003CPlayerSpin_003Ed__15 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PbExileController _003C_003E4__this;

		private Vector2 _003Cbottom_003E5__2;

		private float _003Cd1_003E5__3;

		private float _003Ct_003E5__4;

		private Vector2 _003Ctop_003E5__5;

		private float _003Cd3_003E5__6;

		private float _003Ct_003E5__7;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CPlayerSpin_003Ed__15(int _003C_003E1__state)
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

	private const float BOTTOM_Y = 2.81f;

	private const float PADDED_BOTTOM_Y = 4f;

	public SpriteRenderer HandSlot;

	public Sprite BadHand;

	public Sprite GoodHand;

	public AudioClip SplashSound;

	public SpriteAnim Sploosher;

	public AnimationClip Sploosh;

	public Transform BodyRoot;

	private IEnumerator finalSinkCoroutine;

	private Transform Mover => null;

	protected override IEnumerator Animate()
	{
		return null;
	}

	private IEnumerator HandleText(float waitTime, float textDuration)
	{
		return null;
	}

	private IEnumerator PlayerFall()
	{
		return null;
	}

	private IEnumerator PlayerSpin()
	{
		return null;
	}

	private IEnumerator CoFinalSink()
	{
		return null;
	}
}
