using System;
using System.Collections;
using System.Collections.Generic;
using KlassicHideNSeek;
using UnityEngine;

public class IntroCutsceneHNS : MonoBehaviour
{
	private sealed class _003CCoBeginHnS_003Ed__5 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public IntroCutsceneHNS _003C_003E4__this;

		private HnSIntroController _003Ccontroller_003E5__2;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CCoBeginHnS_003Ed__5(int _003C_003E1__state)
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

	private sealed class _003CFallbackIntro_003Ed__6 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public IntroCutsceneHNS _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CFallbackIntro_003Ed__6(int _003C_003E1__state)
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

	private sealed class _003CFallbackSeekerTransform_003Ed__7 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public IntroCutsceneHNS _003C_003E4__this;

		private float _003Ctimer_003E5__2;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CFallbackSeekerTransform_003Ed__7(int _003C_003E1__state)
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

	public HnSIntroController IntroControllerPrefab;

	public HnSThemeSettings Theme;

	public AudioClip SeekerMusicClip;

	private const float FallbackSeekerReveal = 5f;

	private const float FallbackTransformDuration = 10f;

	public IEnumerator CoBeginHnS()
	{
		return null;
	}

	private IEnumerator FallbackIntro()
	{
		return null;
	}

	private IEnumerator FallbackSeekerTransform()
	{
		return null;
	}

	private static bool IsLocalPlayerSeeker()
	{
		return false;
	}
}
