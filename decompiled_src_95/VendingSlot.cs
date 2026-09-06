using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VendingSlot : MonoBehaviour
{
	private sealed class _003CCloseSlider_003Ed__4 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public AudioClip sliderOpen;

		public VendingSlot _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CCloseSlider_003Ed__4(int _003C_003E1__state)
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

	private sealed class _003CCoBuy_003Ed__3 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public AudioClip sliderOpen;

		public VendingSlot _003C_003E4__this;

		public AudioClip drinkShake;

		public AudioClip drinkLand;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CCoBuy_003Ed__3(int _003C_003E1__state)
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

	private sealed class _003CPlayLand_003Ed__5 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public AudioClip drinkLand;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CPlayLand_003Ed__5(int _003C_003E1__state)
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

	public SpriteRenderer DrinkImage;

	public SpriteRenderer GlassImage;

	private const float SlideDuration = 0.75f;

	public IEnumerator CoBuy(AudioClip sliderOpen, AudioClip drinkShake, AudioClip drinkLand)
	{
		return null;
	}

	public IEnumerator CloseSlider(AudioClip sliderOpen)
	{
		return null;
	}

	private IEnumerator PlayLand(AudioClip drinkLand)
	{
		return null;
	}

	private void _003CCoBuy_003Eb__3_0(float v)
	{
	}

	private void _003CCloseSlider_003Eb__4_0(float v)
	{
	}
}
