using UnityEngine;
using UnityEngine.UI;

public class ButtonBehavior : PassiveUiElement
{
	public bool OnUp;

	public bool OnDown;

	public Button.ButtonClickedEvent OnClick;

	public AudioClip ClickSound;

	protected override void Start()
	{
	}

	public void DoClick()
	{
	}

	protected override void OnDestroy()
	{
	}

	public override void ReceiveClickDown()
	{
	}

	public override void ReceiveClickUp()
	{
	}
}
