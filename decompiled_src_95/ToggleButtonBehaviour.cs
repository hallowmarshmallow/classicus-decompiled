using TMPro;
using UnityEngine;

public class ToggleButtonBehaviour : MonoBehaviour, ITranslatedText
{
	public StringNames BaseText;

	public TextMeshPro Text;

	public SpriteRenderer Background;

	public ButtonRolloverHandler Rollover;

	private bool onState;

	public void Start()
	{
	}

	public void OnDestroy()
	{
	}

	public void ResetText()
	{
	}

	public void UpdateText(bool on)
	{
	}
}
