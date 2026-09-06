using System;
using System.Collections.Generic;
using Rewired;
using UnityEngine;

public class ControllerButtonBehavior : MonoBehaviour
{
	public RewiredConstsEnum.Action Action;

	public GameObject requiredMenuObject;

	public List<string> requiredMenuNames;

	public List<string> restrictedMenuNames;

	public UiElement requiredSelectedObject;

	private Player player;

	private Action m_OnPressedEvent;

	public event Action OnPressedEvent
	{
		add
		{
		}
		remove
		{
		}
	}

	private void Start()
	{
	}

	private void Update()
	{
	}
}
