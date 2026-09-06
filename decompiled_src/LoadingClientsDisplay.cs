using TMPro;
using UnityEngine;

public class LoadingClientsDisplay : MonoBehaviour
{
	private const string TargetObjectName = "loadingclients";

	private const float FailsafeSeconds = 90f;

	private static bool _003CLoadingInProgress_003Ek__BackingField;

	private static LoadingClientsDisplay _active;

	private TMP_Text _text;

	private float _shownAt;

	public static bool LoadingInProgress
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

	public static void Show()
	{
		throw null;
	}

	public static void Hide()
	{
		throw null;
	}

	private void Awake()
	{
		throw null;
	}

	private void Update()
	{
		throw null;
	}

	private void OnDisable()
	{
		throw null;
	}

	public static void NotifyFailedToLoad(string playerName)
	{
		throw null;
	}

	private static GameObject FindInactiveByName(string name)
	{
		throw null;
	}

	private static Transform FindDeep(Transform root, string name)
	{
		throw null;
	}

	public LoadingClientsDisplay()
	{
		throw null;
	}
}
