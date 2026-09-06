using TMPro;
using UnityEngine;

public sealed class UninstallManager : DestroyableSingleton<UninstallManager>
{
	private string curPath;

	private GameObject toBeDestroyed;

	private GameObject PopUp;

	private TextMeshPro wh;

	public void ShowPopup(string name, string path, GameObject toDestroy)
	{
	}

	public void DeleteFile()
	{
	}

	public void Cancel()
	{
	}
}
