using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneChanger : MonoBehaviour
{
	public string TargetScene;

	public Button.ButtonClickedEvent BeforeSceneChange;

	public void Click()
	{
	}

	public static void ChangeScene(string target)
	{
	}

	public static void RestartAll(int sceneId)
	{
	}

	public static void RestartOrExit()
	{
	}

	public void ExitGame()
	{
	}

	public void BeginLoadingSceneAdditive()
	{
	}

	public void BeginLoadingScene()
	{
	}

	private void BeginLoadingSceneInternal(LoadSceneMode mode)
	{
	}
}
