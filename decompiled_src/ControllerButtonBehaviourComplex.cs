using System;
using Rewired;
using UnityEngine;

public class ControllerButtonBehaviourComplex : MonoBehaviour
{
	public enum ActionTriggerType
	{
		Any,
		All
	}

	[Serializable]
	public struct ActionTrigger
	{
		public enum ActionType
		{
			Axis_GEqual,
			Axis_LEqual,
			Button_Down
		}

		public RewiredConstsEnum.Action action;

		public ActionType actionType;

		public float axisComparisonValue;

		public bool ConditionMet(Player player)
		{
			throw null;
		}
	}

	public ActionTriggerType actionTriggerType;

	public ActionTrigger[] actionTriggers;

	public GameObject requiredMenuObject;

	private Player player;

	private void Start()
	{
		throw null;
	}

	private bool ConditionMet()
	{
		throw null;
	}

	private void Update()
	{
		throw null;
	}

	public ControllerButtonBehaviourComplex()
	{
		throw null;
	}
}
