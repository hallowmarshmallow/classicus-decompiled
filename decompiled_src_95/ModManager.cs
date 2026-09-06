using UnityEngine;

public class ModManager : DestroyableSingleton<ModManager>
{
	private const string BepInExFolderName = "BepInEx";

	public SpriteRenderer ModStamp;

	public Camera localCamera;

	public Sprite LoadError;

	public void Start()
	{
	}

	private static bool IsBepInExInstalled()
	{
		return false;
	}

	public void ShowModStamp()
	{
	}

	private void LateUpdate()
	{
	}
}
