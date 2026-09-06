using UnityEngine;

public class CustomPlayerMenu : MonoBehaviour
{
	public static CustomPlayerMenu Instance;

	public MenuTab[] Tabs;

	public Sprite NormalColor;

	public Sprite SelectedColor;

	public GameObject DefaultMenu;

	private GameObject CurMenu;

	public void Start()
	{
	}

	public void Close()
	{
	}

	public void OpenMenu(GameObject menu)
	{
	}
}
