using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

public abstract class PlayerTask : MonoBehaviour
{
	public SystemTypes StartAt;

	public TaskTypes TaskType;

	public Minigame MinigamePrefab;

	public bool HasLocation;

	public bool LocationDirty;

	private int _003CIndex_003Ek__BackingField;

	private uint _003CId_003Ek__BackingField;

	private PlayerControl _003COwner_003Ek__BackingField;

	public int Index
	{
		get
		{
			return _003CIndex_003Ek__BackingField;
		}
		internal set
		{
			_003CIndex_003Ek__BackingField = value;
		}
	}

	public uint Id
	{
		get
		{
			return _003CId_003Ek__BackingField;
		}
		internal set
		{
			_003CId_003Ek__BackingField = value;
		}
	}

	public PlayerControl Owner
	{
		get
		{
			return _003COwner_003Ek__BackingField;
		}
		internal set
		{
			_003COwner_003Ek__BackingField = value;
		}
	}

	public abstract int TaskStep { get; }

	public abstract bool IsComplete { get; }

	public Vector2 Location => default(Vector2);

	public virtual List<Vector2> GetLocations()
	{
		return null;
	}

	public abstract void Initialize();

	public virtual void OnRemove()
	{
	}

	public virtual Minigame GetMinigamePrefab()
	{
		return null;
	}

	public abstract bool ValidConsole(Console console);

	public abstract void Complete();

	public abstract void AppendTaskText(StringBuilder sb);

	internal static bool TaskIsEmergency(PlayerTask arg)
	{
		return false;
	}

	protected List<Console> FindConsoles()
	{
		return null;
	}

	public static bool PlayerHasTaskOfType<T>(PlayerControl localPlayer)
	{
		return false;
	}

	protected List<Vector2> FindObjectsPos()
	{
		return null;
	}

	protected Console FindSpecialConsole(Func<Console, bool> func)
	{
		return null;
	}

	protected virtual Console FindObjectPos()
	{
		return null;
	}

	protected static bool AllTasksCompleted(PlayerControl player)
	{
		return false;
	}
}
