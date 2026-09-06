using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace KlassicHideNSeek;

public sealed class HnSIntroController : MonoBehaviour
{
	private sealed class _003CCoPlayClipDelayed_003Ed__35 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public float delay;

		public AudioClip clip;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CCoPlayClipDelayed_003Ed__35(int _003C_003E1__state)
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

	private sealed class _003CRunIntro_003Ed__23 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public HnSIntroController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CRunIntro_003Ed__23(int _003C_003E1__state)
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

	private sealed class _003CShowSeekerReveal_003Ed__24 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public HnSIntroController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CShowSeekerReveal_003Ed__24(int _003C_003E1__state)
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

	private sealed class _003CShowTransformOrWait_003Ed__25 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public HnSIntroController _003C_003E4__this;

		private float _003Ctimer_003E5__2;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CShowTransformOrWait_003Ed__25(int _003C_003E1__state)
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

	public HnSThemeSettings Theme;

	public GameObject SeekerRevealPanel;

	public TextMeshProUGUI SeekerNameText;

	public TextMeshProUGUI SeekerRoleLabel;

	public PoolablePlayer SeekerPlayerPrefab;

	public Transform SeekerPlayerHolder;

	public Image ObjectiveCard01;

	public Image ObjectiveCard02;

	public Image ObjectiveCard03;

	public TextMeshProUGUI ObjectiveDesc01;

	public TextMeshProUGUI ObjectiveDesc02;

	public TextMeshProUGUI ObjectiveDesc03;

	public Image RevealBackground;

	public GameObject TransformPanel;

	public Transform TransformPlayerHolder;

	public Animator TransformAnimator;

	public TextMeshProUGUI TransformCountdownText;

	public Image TransformBackground;

	public float SeekerRevealDuration;

	public float SeekerTransformDuration;

	public string Card01Description;

	public string Card02Description;

	public string Card03Description;

	public IEnumerator RunIntro()
	{
		return null;
	}

	private IEnumerator ShowSeekerReveal()
	{
		return null;
	}

	private IEnumerator ShowTransformOrWait()
	{
		return null;
	}

	private void SetPanelsInactive()
	{
	}

	private static bool IsLocalPlayerSeeker()
	{
		return false;
	}

	private static PlayerControl FindSeeker()
	{
		return null;
	}

	private static List<PlayerControl> FindAllSeekers()
	{
		return null;
	}

	private void SpawnSeekerLineup(List<PlayerControl> seekers, Transform holder, PoolablePlayer prefab)
	{
	}

	public static PoolablePlayer SpawnPlayerPreview(PlayerControl source, Transform holder, PoolablePlayer prefab, bool applySeeker, float scale = 1.4f, Vector3 localOffset = default(Vector3), bool clearHolder = true)
	{
		return null;
	}

	private static void ApplyObjectiveCard(Image img, TextMeshProUGUI desc, Sprite sprite, string fallback)
	{
	}

	private static void PlayClip(AudioClip clip)
	{
	}

	private void PlayClipAfter(AudioClip clip, float delay)
	{
	}

	private IEnumerator CoPlayClipDelayed(AudioClip clip, float delay)
	{
		return null;
	}

	private static void PlayMusicClip(AudioClip clip)
	{
	}
}
