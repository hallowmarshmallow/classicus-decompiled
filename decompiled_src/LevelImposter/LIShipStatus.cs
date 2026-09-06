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
			throw null;
		}
		set
		{
			throw null;
		}
	}

	public RenameHandler Renames
	{
		get
		{
			throw null;
		}
	}

	public override void AddSystems()
	{
		throw null;
	}

	public override void Awake()
	{
		throw null;
	}

	public override void AddTasksFromList(ref int start, int count, List<byte> tasks, HashSet<TaskTypes> usedTaskTypes, List<NormalPlayerTask> unusedTasks)
	{
		throw null;
	}

	public override bool CheckTaskCompletion()
	{
		throw null;
	}

	public override bool Serialize(MessageWriter writer, bool initialState)
	{
		throw null;
	}

	public override void Deserialize(MessageReader reader, bool initialState)
	{
		throw null;
	}

	public static void AddElement(BuildRouter buildRouter, LIElement element, LIShipStatus parent)
	{
		throw null;
	}

	public static Vector3 ScaleZPositionByY(Vector3 vector)
	{
		throw null;
	}

	public LIShipStatus()
	{
		throw null;
	}
}
