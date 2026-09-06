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
			return _003CLoadingInProgress_003Ek__BackingField;
		}
		private set
		{
			_003CLoadingInProgress_003Ek__BackingField = value;
		}
	}

	public static void Show()
	{
	}

	public static void Hide()
	{
	}

	private void Awake()
	{
	}

	private void Update()
	{
	}

	private void OnDisable()
	{
	}

	public static void NotifyFailedToLoad(string playerName)
	{
	}

	private static GameObject FindInactiveByName(string name)
	{
		return null;
	}

	private static Transform FindDeep(Transform root, string name)
	{
		return null;
	}
}
