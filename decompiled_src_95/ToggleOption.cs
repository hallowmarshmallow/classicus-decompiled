using UnityEngine;

public class ToggleOption : OptionBehaviour
{
	public TextRenderer TitleText;

	public SpriteRenderer CheckMark;

	private bool oldValue;

	public void OnEnable()
	{
	}

	private void FixedUpdate()
	{
	}

	public void Toggle()
	{
	}

	public override bool GetBool()
	{
		return false;
	}
}
