using System;
using System.Collections.Generic;
using Hazel;
using InnerNet;

public class GameData : InnerNetObject, IDisconnectHandler
{
	public class TaskInfo
	{
		public uint Id;

		public bool Complete;

		public void Serialize(MessageWriter writer)
		{
			throw null;
		}

		public void Deserialize(MessageReader reader)
		{
			throw null;
		}

		public TaskInfo()
		{
			throw null;
		}
	}

	public class PlayerInfo
	{
		public readonly byte PlayerId;

		public string PlayerName;

		public int ColorId;

		public string HatId;

		public string PetId;

		public string SkinId;

		public bool Disconnected;

		public List<TaskInfo> Tasks;

		public RoleBehaviour myRole;

		private byte[] pendingTaskTypeIds;

		public bool IsDead;

		private DateTimeOffset _003CLastMurder_003Ek__BackingField;

		public string roleWhenAliveName;

		private WinnerMessage _003CWinnerMessage_003Ek__BackingField;

		private PlayerControl _object;

		public DateTimeOffset LastMurder
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

		public WinnerMessage WinnerMessage
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

		public PlayerControl Object
		{
			get
			{
				throw null;
			}
		}

		public bool Incomplete
		{
			get
			{
				throw null;
			}
		}

		public bool HasPendingTaskTypeIds
		{
			get
			{
				throw null;
			}
		}

		public PlayerInfo(byte playerId)
		{
			throw null;
		}

		public PlayerInfo(PlayerControl pc)
		{
			throw null;
		}

		public void Serialize(MessageWriter writer)
		{
			throw null;
		}

		public void Deserialize(MessageReader reader)
		{
			throw null;
		}

		public TaskInfo FindTaskById(uint taskId)
		{
			throw null;
		}

		public void SetTaskTypeIds(byte[] taskTypeIds)
		{
			throw null;
		}

		public bool TryApplyPendingTaskTypeIds()
		{
			throw null;
		}

		private bool _003Cget_Object_003Eb__22_0(PlayerControl p)
		{
			throw null;
		}
	}

	private sealed class _003C_003Ec__DisplayClass22_0
	{
		public int i;

		public _003C_003Ec__DisplayClass22_0()
		{
			throw null;
		}

		internal bool _003CGetAvailableId_003Eb__0(PlayerInfo p)
		{
			throw null;
		}
	}

	public static GameData Instance;

	public List<PlayerInfo> AllPlayers;

	public int TotalTasks;

	public int CompletedTasks;

	public const byte InvalidPlayerId = byte.MaxValue;

	public const byte DisconnectedPlayerId = 254;

	private bool hasPendingTaskTypeIds;

	private readonly bool[] _dirtyPlayers;

	private bool _taskCountDirty;

	public int PlayerCount
	{
		get
		{
			throw null;
		}
	}

	public override bool IsDirty
	{
		get
		{
			throw null;
		}
	}

	public override bool Chunked
	{
		get
		{
			throw null;
		}
	}

	private void MarkPlayerDirty(byte playerId)
	{
		throw null;
	}

	public void Awake()
	{
		throw null;
	}

	public override void OnDestroy()
	{
		throw null;
	}

	public void Update()
	{
		throw null;
	}

	internal void SetDirty()
	{
		throw null;
	}

	internal void ResendPlayer(byte playerId)
	{
		throw null;
	}

	public PlayerInfo GetHost()
	{
		throw null;
	}

	public int GetAvailableId()
	{
		throw null;
	}

	public PlayerInfo GetPlayerById(byte id)
	{
		throw null;
	}

	public PlayerControl PlayerControlById(byte id)
	{
		throw null;
	}

	public PlayerControl PlayerControlByOwnerId(int id)
	{
		throw null;
	}

	public void UpdateName(byte playerId, string name)
	{
		throw null;
	}

	public void ChangeFloor(byte playerId, bool name)
	{
		throw null;
	}

	public void UpdateColor(byte playerId, int color)
	{
		throw null;
	}

	public void UpdateHat(byte playerId, string hat)
	{
		throw null;
	}

	public void UpdatePet(byte playerId, string petId)
	{
		throw null;
	}

	public void UpdateSkin(byte playerId, string skin)
	{
		throw null;
	}

	public void AddPlayer(PlayerControl pc)
	{
		throw null;
	}

	public bool RemovePlayer(byte playerId)
	{
		throw null;
	}

	public void MarkTasksDirty()
	{
		throw null;
	}

	public void RecomputeTaskCounts()
	{
		throw null;
	}

	public void TutOnlyRemoveTask(byte playerId, uint taskId)
	{
		throw null;
	}

	public void TutOnlyAddTask(byte playerId, uint taskId)
	{
		throw null;
	}

	private void SetTasks(byte playerId, byte[] taskTypeIds)
	{
		throw null;
	}

	public void CompleteTask(PlayerControl pc, uint taskId)
	{
		throw null;
	}

	public void HandleDisconnect(PlayerControl player, DisconnectReasons reason)
	{
		throw null;
	}

	private string GetBannedText(string player, string host)
	{
		throw null;
	}

	private string GetKickedText(string player, string host)
	{
		throw null;
	}

	private string GetErrorText(string player)
	{
		throw null;
	}

	public void ShowNotification(string playerName, DisconnectReasons reason)
	{
		throw null;
	}

	public void HandleDisconnect()
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

	public void RpcSetTasks(byte playerId, byte[] taskTypeIds)
	{
		throw null;
	}

	public override void HandleRpc(byte callId, MessageReader reader)
	{
		throw null;
	}

	public GameData()
	{
		throw null;
	}
}
