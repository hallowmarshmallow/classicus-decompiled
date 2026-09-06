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

	private static string NorthAmericaLabel => null;

	private static string EuropeLabel => null;

	private static string Translate(StringNames key, string fallback, object[] parts)
	{
		return null;
	}

	private void Start()
	{
	}

	private void Update()
	{
	}

	private static string ResolveLabel(out string endpoint)
	{
		endpoint = null;
		return null;
	}

	private void Apply(string label, string endpoint)
	{
	}

	public static void Attach()
	{
	}

	private static bool ShowsForCurrentMode()
	{
		return false;
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
