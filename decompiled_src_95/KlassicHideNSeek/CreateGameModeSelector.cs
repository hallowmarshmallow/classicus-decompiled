using UnityEngine;

namespace KlassicHideNSeek;

public sealed class CreateGameModeSelector : MonoBehaviour
{
	public CreateGameOptions createGameOptions;

	public GameObject classicButton;

	public GameObject hnsButton;

	public Color selectedColor;

	public Color deselectedColor;

	private bool _hnsSelected;

	private void OnEnable()
	{
	}

	public void SelectClassic()
	{
	}

	public void SelectHNS()
	{
	}

	public void ConfirmSelected()
	{
	}

	private void ApplyHighlight()
	{
	}

	private void SetButtonSelected(GameObject btn, bool isSelected)
	{
	}

	private static void PushSettingsIfHost()
	{
	}
}
