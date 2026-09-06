using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using TMPro;
using UnityEngine;
using UnityEngine.Networking;

public class RegionPingMenu : MonoBehaviour
{
	private sealed class RegionButton
	{
		public GameObject Root;

		public TMP_Text Label;

		public SpriteRenderer Background;

		public ButtonRolloverHandler Rollover;

		public string LastText;

		public int LastSelected;
	}

	private sealed class RegionPingProbe : MonoBehaviour
	{
		private sealed class _003CMeasure_003Ed__3 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public string ip;

			public bool northAmerica;

			private string _003Curl_003E5__2;

			private int _003Cbest_003E5__3;

			private int _003Ci_003E5__4;

			private Stopwatch _003Cclock_003E5__5;

			private UnityWebRequest _003Crequest_003E5__6;

			object IEnumerator<object>.Current => null;

			object IEnumerator.Current => null;

			public _003CMeasure_003Ed__3(int _003C_003E1__state)
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

			private void _003C_003Em__Finally1()
			{
			}

			void IEnumerator.Reset()
			{
			}
		}

		private sealed class _003CStart_003Ed__2 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			object IEnumerator<object>.Current => null;

			object IEnumerator.Current => null;

			public _003CStart_003Ed__2(int _003C_003E1__state)
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

		private static RegionPingProbe _instance;

		public static void Run()
		{
		}

		private IEnumerator Start()
		{
			return null;
		}

		private static IEnumerator Measure(string ip, bool northAmerica)
		{
			return null;
		}
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Func<ServerInfo, bool> _003C_003E9__33_0;

		internal bool _003CChoose_003Eb__33_0(ServerInfo s)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass32_0
	{
		public string target;

		internal void _003CBindButton_003Eb__0()
		{
		}
	}

	private const string MenuName = "RegionMenu";

	private const string DescriptionName = "Description";

	private const string PingEuName = "ServerPingEU";

	private const string PingNaName = "ServerPingNA";

	public const string NorthAmericaIp = "178.156.171.131";

	public const string EuropeIp = "46.62.194.17";

	private const int ServerPort = 22023;

	private const float RefreshSeconds = 15f;

	private const int SamplesPerProbe = 2;

	private const int ProbeTimeoutSeconds = 5;

	private static readonly Color SelectedColor;

	private static readonly Color SelectedHover;

	private static readonly Color DimmedColor;

	private static readonly Color DimmedHover;

	private static int _naPing;

	private static int _euPing;

	private static string _manualIp;

	private TMP_Text _description;

	private RegionButton _europe;

	private RegionButton _northAmerica;

	private float _nextApply;

	public static bool RegionPinned => false;

	public static string PinnedIp => null;

	public static bool NorthAmericaIsHome => false;

	public static void Attach()
	{
	}

	private void OnEnable()
	{
	}

	private void Update()
	{
	}

	private void Bind()
	{
	}

	private RegionButton BindButton(string name, string ip)
	{
		return null;
	}

	private static void Choose(string ip)
	{
	}

	private void Apply()
	{
	}

	private static int EffectivePing(int estimated, string ip)
	{
		return 0;
	}

	private static void ApplyButton(RegionButton button, StringNames id, string fallback, int ping, bool selected)
	{
	}

	private static string PingLabel(int ms)
	{
		return null;
	}

	private static string LiveEndpoint()
	{
		return null;
	}

	private static string Loc(StringNames id, string fallback, object[] parts)
	{
		return null;
	}

	private static GameObject FindByName(string name)
	{
		return null;
	}

	private static Transform FindDeep(Transform root, string name)
	{
		return null;
	}
}
