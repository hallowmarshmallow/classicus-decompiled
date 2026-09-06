using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using TMPro;
using UnityEngine;

public class ProfilePopup : MonoBehaviour
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Func<long, string> _003C_003E9__39_2;

		static _003C_003Ec()
		{
			throw null;
		}

		public _003C_003Ec()
		{
			throw null;
		}

		internal string _003CCoLoad_003Eb__39_2(long v)
		{
			throw null;
		}
	}

	private sealed class _003C_003Ec__DisplayClass39_0
	{
		public AccountService.ProfilePage page;

		public bool hasStats;

		public _003C_003Ec__DisplayClass39_0()
		{
			throw null;
		}

		internal void _003CCoLoad_003Eb__0(AccountService.ProfilePage p)
		{
			throw null;
		}

		internal string _003CCoLoad_003Eb__1(uint v)
		{
			throw null;
		}
	}

	private sealed class _003C_003Ec__DisplayClass41_0
	{
		public AccountService.ProfileLikeResult res;

		public _003C_003Ec__DisplayClass41_0()
		{
			throw null;
		}

		internal void _003CCoLike_003Eb__0(AccountService.ProfileLikeResult r)
		{
			throw null;
		}
	}

	private sealed class _003C_003Ec__DisplayClass49_0
	{
		public Action onClick;

		public _003C_003Ec__DisplayClass49_0()
		{
			throw null;
		}

		internal void _003CWireButton_003Eb__0()
		{
			throw null;
		}
	}

	private sealed class _003CCoLike_003Ed__41 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ProfilePopup _003C_003E4__this;

		public string profileId;

		private _003C_003Ec__DisplayClass41_0 _003C_003E8__1;

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

		public _003CCoLike_003Ed__41(int _003C_003E1__state)
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

	private sealed class _003CCoLoad_003Ed__39 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ProfilePopup _003C_003E4__this;

		public string profileId;

		private _003C_003Ec__DisplayClass39_0 _003C_003E8__1;

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

		public _003CCoLoad_003Ed__39(int _003C_003E1__state)
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

	private const float ClassicColorMax = 500f;

	private const float RunnerColorMaxSeconds = 3600f;

	private Transform _root;

	private TMP_Text _name;

	private TMP_Text _classicStats;

	private TMP_Text _runnerStats;

	private TMP_Text _seen;

	private TMP_Text _likeCount;

	private Transform _thumbUp;

	private Transform _close;

	private GameObject _connectIcon;

	private TMP_Text _connectingText;

	private TMP_FontAsset _connectingFont;

	private string _openId;

	private bool _likeInFlight;

	private bool _003CIsBusy_003Ek__BackingField;

	private readonly List<PassiveUiElement> _maskedButtons;

	private readonly List<Collider2D> _maskedOriginals;

	private Collider2D _nowhereMask;

	private Collider2D _thumbUpCollider;

	private bool _thumbUpHovered;

	private Vector3 _thumbUpBaseScale;

	private const float ThumbHoverScale = 1.18f;

	private const float LikeClickDebounce = 0.35f;

	private float _lastLikeClickTime;

	private const string Unknown = "??";

	public bool IsBusy
	{
		get
		{
			throw null;
		}
		private set
		{
			throw null;
		}
	}

	public bool IsOpen
	{
		get
		{
			throw null;
		}
	}

	private void Awake()
	{
		throw null;
	}

	public void Open(string profileId)
	{
		throw null;
	}

	private void SetBackgroundClicksBlocked(bool blocked)
	{
		throw null;
	}

	private void EnsureNowhereMask()
	{
		throw null;
	}

	private void EnsureClickBlocker()
	{
		throw null;
	}

	private void Update()
	{
		throw null;
	}

	public void Close()
	{
		throw null;
	}

	private void OnDisable()
	{
		throw null;
	}

	private void OnDestroy()
	{
		throw null;
	}

	private IEnumerator CoLoad(string profileId)
	{
		throw null;
	}

	private void OnLikeClicked()
	{
		throw null;
	}

	private IEnumerator CoLike(string profileId)
	{
		throw null;
	}

	private static Color Ramp(float value, float max)
	{
		throw null;
	}

	private void ShowConnecting(bool show)
	{
		throw null;
	}

	private static void SetText(TMP_Text label, string value)
	{
		throw null;
	}

	private static void SetColor(TMP_Text label, Color c)
	{
		throw null;
	}

	private static void Row(StringBuilder sb, StringNames key, string fallback, string value, bool last = false)
	{
		throw null;
	}

	private static void SetAlignment(TMP_Text label, TextAlignmentOptions alignment)
	{
		throw null;
	}

	private static void WireButton(Transform btn, Action onClick)
	{
		throw null;
	}

	private static string GetString(StringNames name, string fallback)
	{
		throw null;
	}

	private static Transform FindInScene(string name)
	{
		throw null;
	}

	private static Transform FindChild(Transform parent, string name)
	{
		throw null;
	}

	private static TMP_Text FindText(Transform parent, string name)
	{
		throw null;
	}

	public ProfilePopup()
	{
		throw null;
	}
}
