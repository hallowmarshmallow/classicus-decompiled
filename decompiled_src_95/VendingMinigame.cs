using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VendingMinigame : Minigame
{
	private sealed class _003CAnimate_003Ed__25 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public VendingMinigame _003C_003E4__this;

		private int _003CslotId_003E5__2;

		private WaitForSeconds _003Cwait_003E5__3;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CAnimate_003Ed__25(int _003C_003E1__state)
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

	private sealed class _003CBlinkAccept_003Ed__24 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public VendingMinigame _003C_003E4__this;

		private int _003Ci_003E5__2;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CBlinkAccept_003Ed__24(int _003C_003E1__state)
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

	private sealed class _003CCoBlinkVend_003Ed__26 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public VendingMinigame _003C_003E4__this;

		private int _003Ci_003E5__2;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CCoBlinkVend_003Ed__26(int _003C_003E1__state)
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

	public static readonly string[] Letters;

	public TextRenderer NumberText;

	public SpriteRenderer TargetImage;

	public string enteredCode;

	private bool animating;

	private bool done;

	private string targetCode;

	public SpriteRenderer AcceptButton;

	public VendingSlot[] Slots;

	public Sprite[] Drinks;

	public Sprite[] DrawnDrinks;

	public AudioClip Ambience;

	public AudioClip Button;

	public AudioClip Error;

	public AudioClip SliderOpen;

	public AudioClip DrinkShake;

	public AudioClip DrinkLand;

	public override void Begin(PlayerTask task)
	{
	}

	private static int StringToSlotId(string code)
	{
		return 0;
	}

	private static string SlotIdToString(int slotId)
	{
		return null;
	}

	private bool PickARandomSlot(Sprite drink, out int slotId)
	{
		slotId = default(int);
		return false;
	}

	public void EnterDigit(string s)
	{
	}

	public void ClearDigits()
	{
	}

	public void AcceptDigits()
	{
	}

	private IEnumerator BlinkAccept()
	{
		return null;
	}

	private IEnumerator Animate()
	{
		return null;
	}

	private IEnumerator CoBlinkVend()
	{
		return null;
	}
}
