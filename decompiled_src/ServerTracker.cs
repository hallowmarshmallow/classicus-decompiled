using TMPro;
using UnityEngine;

public class ServerTracker : MonoBehaviour
{
	private const string TargetObjectName = "ServerTracker";

	private const float RefreshSeconds = 1f;

	private static readonly Color NorthAmericaColor;

	private static readonly Color EuropeColor;

	private static readonly Color UnknownColor;

	private static readonly (string, StringNames, string)[] KnownServers;

	private TMP_Text _text;

	private float _nextRefresh;

	private string _lastLabel;

	private string _lastLoggedEndpoint;

	private static string NorthAmericaLabel
	{
		get
		{
			throw null;
		}
	}

	private static string EuropeLabel
	{
		get
		{
			throw null;
		}
	}

	private static string Translate(StringNames key, string fallback, object[] parts)
	{
		throw null;
	}

	private void Start()
	{
		throw null;
	}

	private void Update()
	{
		throw null;
	}

	private static string ResolveLabel(out string endpoint)
	{
		throw null;
	}

	private void Apply(string label, string endpoint)
	{
		throw null;
	}

	public static void Attach()
	{
		throw null;
	}

	private static bool ShowsForCurrentMode()
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

	public ServerTracker()
	{
		throw null;
	}

	static ServerTracker()
	{
		throw null;
	}
}
