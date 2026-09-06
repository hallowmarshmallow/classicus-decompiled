using System.Collections.Generic;
using Hazel;
using LevelImposter.Api;
using LevelImposter.Builders;
using UnityEngine;

namespace LevelImposter;

public class LIShipStatus : ShipStatus
{
	private LIMap _003Cmap_003Ek__BackingField;

	private readonly RenameHandler _003CRenames_003Ek__BackingField;

	public const float PLAYER_POS = -5f;

	public LIMap map
	{
		get
		{
			return _003Cmap_003Ek__BackingField;
		}
		set
		{
			_003Cmap_003Ek__BackingField = value;
		}
	}

	public RenameHandler Renames => _003CRenames_003Ek__BackingField;

	public override void AddSystems()
	{
	}

	public override void Awake()
	{
	}

	public override void AddTasksFromList(ref int start, int count, List<byte> tasks, HashSet<TaskTypes> usedTaskTypes, List<NormalPlayerTask> unusedTasks)
	{
	}

	public override bool CheckTaskCompletion()
	{
		return false;
	}

	public override bool Serialize(MessageWriter writer, bool initialState)
	{
		return false;
	}

	public override void Deserialize(MessageReader reader, bool initialState)
	{
	}

	public static void AddElement(BuildRouter buildRouter, LIElement element, LIShipStatus parent)
	{
	}

	public static Vector3 ScaleZPositionByY(Vector3 vector)
	{
		return default(Vector3);
	}
}
