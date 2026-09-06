using System;
using System.Collections.Generic;
using UnityEngine;

public class RoleManager : DestroyableSingleton<RoleManager>
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Func<RoleBehaviour, bool> _003C_003E9__15_0;

		public static Func<PlayerControl, bool> _003C_003E9__22_0;

		public static Func<PlayerControl, bool> _003C_003E9__23_0;

		public static Func<GameData.PlayerInfo, bool> _003C_003E9__24_0;

		public static Func<GameData.PlayerInfo, bool> _003C_003E9__25_0;

		internal bool _003CHasActiveNeutralRoles_003Eb__15_0(RoleBehaviour role)
		{
			return false;
		}

		internal bool _003CGetAllPlayerControls_003Eb__22_0(PlayerControl player)
		{
			return false;
		}

		internal bool _003CGetAllNotAssignedPlayerControls_003Eb__23_0(PlayerControl player)
		{
			return false;
		}

		internal bool _003CGetAllPlayers_003Eb__24_0(GameData.PlayerInfo player)
		{
			return false;
		}

		internal bool _003CGetNotAssignedPlayers_003Eb__25_0(GameData.PlayerInfo player)
		{
			return false;
		}
	}

	[Serializable]
	private sealed class _003C_003Ec__6<T> where T : RoleBehaviour
	{
		public static readonly _003C_003Ec__6<T> _003C_003E9;

		public static Func<RoleBehaviour, bool> _003C_003E9__6_0;

		internal bool _003CAddRole_003Eb__6_0(RoleBehaviour r)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass16_0
	{
		public string roleName;

		internal bool _003CAssignRole_003Eb__0(RoleBehaviour r)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass16_1
	{
		public string fallback;

		internal bool _003CAssignRole_003Eb__1(RoleBehaviour r)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass19_0
	{
		public string role;

		internal bool _003CGetPlayersByRole_003Eb__0(GameData.PlayerInfo player)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass20_0
	{
		public RoleTeamTypes team;

		internal bool _003CGetPlayersByTeam_003Eb__0(GameData.PlayerInfo player)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass21_0
	{
		public string role;

		internal bool _003CGetPlayerControlsByRole_003Eb__0(PlayerControl player)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass27_0
	{
		public RoleTeamTypes type;

		internal bool _003CAssignRoleToPlayer_003Eb__0(RoleBehaviour r)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass28_0
	{
		public RoleTeamTypes type;

		internal bool _003CAssignRolesForTeam_003Eb__0(RoleBehaviour r)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass7_0
	{
		public Type roleType;

		internal bool _003CAddRole_003Eb__0(RoleBehaviour r)
		{
			return false;
		}

		internal bool _003CAddRole_003Eb__1(RoleBehaviour r)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass8_0
	{
		public Type type;

		internal bool _003CGetRoleByType_003Eb__0(RoleBehaviour r)
		{
			return false;
		}
	}

	public List<RoleBehaviour> allRoles;

	public Dictionary<string, AudioClip> allAudios;

	public Dictionary<string, Sprite> allSprites;

	private Transform RoleHolder;

	private ushort lastRoleId;

	private static readonly HashSet<string> LegacyImpostorRoles;

	public void Start()
	{
	}

	internal void AddRole<T>() where T : RoleBehaviour
	{
	}

	internal void AddRole(Type roleType, string modName = "")
	{
	}

	public static RoleBehaviour GetRoleByType(Type type)
	{
		return null;
	}

	public void AddEndGameAudio(string audioName, AudioClip input)
	{
	}

	public void AddSprite(string spriteName, Texture2D input, float pixelsPerUnit = 180f)
	{
	}

	public void AddSprite(string spriteName, Sprite input)
	{
	}

	public static bool CheckRole(GameData.PlayerInfo data, string role)
	{
		return false;
	}

	public static bool IsSameTeam(GameData.PlayerInfo player1, GameData.PlayerInfo player2)
	{
		return false;
	}

	public static bool IsTeam(GameData.PlayerInfo player1, RoleTeamTypes team)
	{
		return false;
	}

	public static bool HasActiveNeutralRoles()
	{
		return false;
	}

	public void AssignRole(PlayerControl player, string roleName)
	{
	}

	private static string LegacyFallback(string roleName)
	{
		return null;
	}

	public static List<GameData.PlayerInfo> GetPlayersByRole(string role)
	{
		return null;
	}

	public static List<GameData.PlayerInfo> GetPlayersByTeam(RoleTeamTypes team)
	{
		return null;
	}

	public static List<PlayerControl> GetPlayerControlsByRole(string role)
	{
		return null;
	}

	public static List<PlayerControl> GetAllPlayerControls()
	{
		return null;
	}

	public static List<PlayerControl> GetAllNotAssignedPlayerControls()
	{
		return null;
	}

	public static List<GameData.PlayerInfo> GetAllPlayers()
	{
		return null;
	}

	public static List<GameData.PlayerInfo> GetNotAssignedPlayers()
	{
		return null;
	}

	public void LogRoles(RoleTeamTypes teamType, List<GameData.PlayerInfo> players, List<RoleBehaviour> roles)
	{
	}

	public bool AssignRoleToPlayer(byte playerId, RoleTeamTypes type)
	{
		return false;
	}

	public void AssignRolesForTeam(RoleTeamTypes type, int max)
	{
	}

	private void AssignRolesFromList(List<GameData.PlayerInfo> players, int teamMax, List<RoleBehaviour> roleList, ref int rolesAssigned)
	{
	}
}
