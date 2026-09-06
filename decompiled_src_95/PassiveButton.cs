using System;
using UnityEngine;
using UnityEngine.UI;

public class PassiveButton : PassiveUiElement
{
	[Serializable]
	public class GameObjectEntry
	{
		public string GameObjectName;

		public GameObjectAction ActionType;
	}

	public enum GameObjectAction
	{
		None,
		SetActive,
		SetInactive,
		Toggle,
		DestroyObject,
		DestroyChildren,
		EnableComponent,
		DisableComponent
	}

	public bool OnUp;

	public bool OnDown;

	public bool OnRepeat;

	public float RepeatDuration;

	private float repeatTimer;

	public bool RepeatAccelerates;

	public float RepeatRampDelay;

	public float RepeatRampTime;

	public float RepeatFastDuration;

	private float repeatHeldTime;

	private bool repeatFired;

	public Button.ButtonClickedEvent OnClick;

	public AudioClip ClickSound;

	public string SceneToLoad;

	public GameObjectEntry[] GameObjectActions;

	protected override void Start()
	{
	}

	public void DoClick()
	{
	}

	public override void ReceiveClickDown()
	{
	}

	public override void ReceiveRepeatDown()
	{
	}

	private float CurrentRepeatInterval()
	{
		return 0f;
	}

	public override void ReleaseButton()
	{
	}

	public override void ReceiveClickUp()
	{
	}

	private void HandleActions()
	{
	}

	private GameObject FindGameObject(string name)
	{
		return null;
	}

	private void PlayClickSound()
	{
	}
}
