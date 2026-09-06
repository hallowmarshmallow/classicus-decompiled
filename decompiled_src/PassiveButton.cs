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

		public GameObjectEntry()
		{
			throw null;
		}
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
		throw null;
	}

	public void DoClick()
	{
		throw null;
	}

	public override void ReceiveClickDown()
	{
		throw null;
	}

	public override void ReceiveRepeatDown()
	{
		throw null;
	}

	private float CurrentRepeatInterval()
	{
		throw null;
	}

	public override void ReleaseButton()
	{
		throw null;
	}

	public override void ReceiveClickUp()
	{
		throw null;
	}

	private void HandleActions()
	{
		throw null;
	}

	private GameObject FindGameObject(string name)
	{
		throw null;
	}

	private void PlayClickSound()
	{
		throw null;
	}

	public PassiveButton()
	{
		throw null;
	}
}
