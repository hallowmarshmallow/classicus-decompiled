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
			throw null;
		}
		internal set
		{
			throw null;
		}
	}

	public uint Id
	{
		get
		{
			throw null;
		}
		internal set
		{
			throw null;
		}
	}

	public PlayerControl Owner
	{
		get
		{
			throw null;
		}
		internal set
		{
			throw null;
		}
	}

	public abstract int TaskStep { get; }

	public abstract bool IsComplete { get; }

	public Vector2 Location
	{
		get
		{
			throw null;
		}
	}

	public abstract void Initialize();

	public virtual void OnRemove()
	{
		throw null;
	}

	public virtual Minigame GetMinigamePrefab()
	{
		throw null;
	}

	public abstract bool ValidConsole(Console console);

	public abstract void Complete();

	public abstract void AppendTaskText(StringBuilder sb);

	internal static bool TaskIsEmergency(PlayerTask arg)
	{
		throw null;
	}

	protected List<Console> FindConsoles()
	{
		throw null;
	}

	public static bool PlayerHasTaskOfType<T>(PlayerControl localPlayer)
	{
		throw null;
	}

	protected List<Vector2> FindObjectsPos()
	{
		throw null;
	}

	protected Console FindSpecialConsole(Func<Console, bool> func)
	{
		throw null;
	}

	protected virtual Console FindObjectPos()
	{
		throw null;
	}

	protected static bool AllTasksCompleted(PlayerControl player)
	{
		throw null;
	}

	protected PlayerTask()
	{
		throw null;
	}
}
