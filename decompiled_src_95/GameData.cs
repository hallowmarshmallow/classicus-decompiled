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
		}

		public void Deserialize(MessageReader reader)
		{
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
				return _003CLastMurder_003Ek__BackingField;
			}
			set
			{
				_003CLastMurder_003Ek__BackingField = value;
			}
		}

		public WinnerMessage WinnerMessage
		{
			get
			{
				return _003CWinnerMessage_003Ek__BackingField;
			}
			set
			{
				_003CWinnerMessage_003Ek__BackingField = value;
			}
		}

		public PlayerControl Object => null;

		public bool Incomplete => false;

		public bool HasPendingTaskTypeIds => false;

		public PlayerInfo(byte playerId)
		{
		}

		public PlayerInfo(PlayerControl pc)
		{
		}

		public void Serialize(MessageWriter writer)
		{
		}

		public void Deserialize(MessageReader reader)
		{
		}

		public TaskInfo FindTaskById(uint taskId)
		{
			return null;
		}

		public void SetTaskTypeIds(byte[] taskTypeIds)
		{
		}

		public bool TryApplyPendingTaskTypeIds()
		{
			return false;
		}

		private bool _003Cget_Object_003Eb__22_0(PlayerControl p)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass22_0
	{
		public int i;

		internal bool _003CGetAvailableId_003Eb__0(PlayerInfo p)
		{
			return false;
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

	public int PlayerCount => 0;

	public override bool IsDirty => false;

	public override bool Chunked => false;

	private void MarkPlayerDirty(byte playerId)
	{
	}

	public void Awake()
	{
	}

	public override void OnDestroy()
	{
	}

	public void Update()
	{
	}

	internal void SetDirty()
	{
	}

	internal void ResendPlayer(byte playerId)
	{
	}

	public PlayerInfo GetHost()
	{
		return null;
	}

	public int GetAvailableId()
	{
		return 0;
	}

	public PlayerInfo GetPlayerById(byte id)
	{
		return null;
	}

	public PlayerControl PlayerControlById(byte id)
	{
		return null;
	}

	public PlayerControl PlayerControlByOwnerId(int id)
	{
		return null;
	}

	public void UpdateName(byte playerId, string name)
	{
	}

	public void ChangeFloor(byte playerId, bool name)
	{
	}

	public void UpdateColor(byte playerId, int color)
	{
	}

	public void UpdateHat(byte playerId, string hat)
	{
	}

	public void UpdatePet(byte playerId, string petId)
	{
	}

	public void UpdateSkin(byte playerId, string skin)
	{
	}

	public void AddPlayer(PlayerControl pc)
	{
	}

	public bool RemovePlayer(byte playerId)
	{
		return false;
	}

	public void MarkTasksDirty()
	{
	}

	public void RecomputeTaskCounts()
	{
	}

	public void TutOnlyRemoveTask(byte playerId, uint taskId)
	{
	}

	public void TutOnlyAddTask(byte playerId, uint taskId)
	{
	}

	private void SetTasks(byte playerId, byte[] taskTypeIds)
	{
	}

	public void CompleteTask(PlayerControl pc, uint taskId)
	{
	}

	public void HandleDisconnect(PlayerControl player, DisconnectReasons reason)
	{
	}

	private string GetBannedText(string player, string host)
	{
		return null;
	}

	private string GetKickedText(string player, string host)
	{
		return null;
	}

	private string GetErrorText(string player)
	{
		return null;
	}

	public void ShowNotification(string playerName, DisconnectReasons reason)
	{
	}

	public void HandleDisconnect()
	{
	}

	public override bool Serialize(MessageWriter writer, bool initialState)
	{
		return false;
	}

	public override void Deserialize(MessageReader reader, bool initialState)
	{
	}

	public void RpcSetTasks(byte playerId, byte[] taskTypeIds)
	{
	}

	public override void HandleRpc(byte callId, MessageReader reader)
	{
	}
}
