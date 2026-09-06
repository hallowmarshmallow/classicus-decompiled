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

		public RegionButton()
		{
			throw null;
		}
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

			public _003CMeasure_003Ed__3(int _003C_003E1__state)
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

			private void _003C_003Em__Finally1()
			{
				throw null;
			}

			void IEnumerator.Reset()
			{
				throw null;
			}
		}

		private sealed class _003CStart_003Ed__2 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

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

			public _003CStart_003Ed__2(int _003C_003E1__state)
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

		private static RegionPingProbe _instance;

		public static void Run()
		{
			throw null;
		}

		private IEnumerator Start()
		{
			throw null;
		}

		private static IEnumerator Measure(string ip, bool northAmerica)
		{
			throw null;
		}

		public RegionPingProbe()
		{
			throw null;
		}
	}

	private sealed class _003C_003Ec__DisplayClass30_0
	{
		public string target;

		public _003C_003Ec__DisplayClass30_0()
		{
			throw null;
		}

		internal void _003CBindButton_003Eb__0()
		{
			throw null;
		}
	}

	private sealed class _003C_003Ec__DisplayClass32_0
	{
		public string ip;

		public _003C_003Ec__DisplayClass32_0()
		{
			throw null;
		}

		internal bool _003CApplyRegion_003Eb__0(ServerInfo s)
		{
			throw null;
		}
	}

	private sealed class _003C_003Ec__DisplayClass33_0
	{
		public string ip;

		public _003C_003Ec__DisplayClass33_0()
		{
			throw null;
		}

		internal bool _003CChoose_003Eb__0(ServerInfo s)
		{
			throw null;
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

	public static bool RegionPinned
	{
		get
		{
			throw null;
		}
	}

	public static bool NorthAmericaIsHome
	{
		get
		{
			throw null;
		}
	}

	public static void Attach()
	{
		throw null;
	}

	private void OnEnable()
	{
		throw null;
	}

	private void Update()
	{
		throw null;
	}

	private void Bind()
	{
		throw null;
	}

	private RegionButton BindButton(string name, string ip)
	{
		throw null;
	}

	private static void EnforceManualRegion()
	{
		throw null;
	}

	private static void ApplyRegion(string ip)
	{
		throw null;
	}

	private static void Choose(string ip)
	{
		throw null;
	}

	private void Apply()
	{
		throw null;
	}

	private static string RegionName(string ip)
	{
		throw null;
	}

	private static int EffectivePing(int estimated, string ip)
	{
		throw null;
	}

	private static void ApplyButton(RegionButton button, StringNames id, string fallback, int ping, bool selected)
	{
		throw null;
	}

	private static string PingLabel(int ms)
	{
		throw null;
	}

	private static string LiveEndpoint()
	{
		throw null;
	}

	private static string Loc(StringNames id, string fallback, object[] parts)
	{
		throw null;
	}

	private static GameObject FindByName(string name)
	{
		throw null;
	}

	private static Transform FindDeep(Transform root, string name)
	{
		throw null;
	}

	public RegionPingMenu()
	{
		throw null;
	}

	static RegionPingMenu()
	{
		throw null;
	}
}
