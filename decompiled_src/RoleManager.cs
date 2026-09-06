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

		public static Func<PlayerControl, bool> _003C_003E9__20_0;

		public static Func<PlayerControl, bool> _003C_003E9__21_0;

		public static Func<GameData.PlayerInfo, bool> _003C_003E9__22_0;

		public static Func<GameData.PlayerInfo, bool> _003C_003E9__23_0;

		static _003C_003Ec()
		{
			throw null;
		}

		public _003C_003Ec()
		{
			throw null;
		}

		internal bool _003CHasActiveNeutralRoles_003Eb__15_0(RoleBehaviour role)
		{
			throw null;
		}

		internal bool _003CGetAllPlayerControls_003Eb__20_0(PlayerControl player)
		{
			throw null;
		}

		internal bool _003CGetAllNotAssignedPlayerControls_003Eb__21_0(PlayerControl player)
		{
			throw null;
		}

		internal bool _003CGetAllPlayers_003Eb__22_0(GameData.PlayerInfo player)
		{
			throw null;
		}

		internal bool _003CGetNotAssignedPlayers_003Eb__23_0(GameData.PlayerInfo player)
		{
			throw null;
		}
	}

	[Serializable]
	private sealed class _003C_003Ec__6<T> where T : RoleBehaviour
	{
		public static readonly _003C_003Ec__6<T> _003C_003E9;

		public static Func<RoleBehaviour, bool> _003C_003E9__6_0;

		static _003C_003Ec__6()
		{
			throw null;
		}

		public _003C_003Ec__6()
		{
			throw null;
		}

		internal bool _003CAddRole_003Eb__6_0(RoleBehaviour r)
		{
			throw null;
		}
	}

	private sealed class _003C_003Ec__DisplayClass16_0
	{
		public string roleName;

		public _003C_003Ec__DisplayClass16_0()
		{
			throw null;
		}

		internal bool _003CAssignRole_003Eb__0(RoleBehaviour r)
		{
			throw null;
		}
	}

	private sealed class _003C_003Ec__DisplayClass17_0
	{
		public string role;

		public _003C_003Ec__DisplayClass17_0()
		{
			throw null;
		}

		internal bool _003CGetPlayersByRole_003Eb__0(GameData.PlayerInfo player)
		{
			throw null;
		}
	}

	private sealed class _003C_003Ec__DisplayClass18_0
	{
		public RoleTeamTypes team;

		public _003C_003Ec__DisplayClass18_0()
		{
			throw null;
		}

		internal bool _003CGetPlayersByTeam_003Eb__0(GameData.PlayerInfo player)
		{
			throw null;
		}
	}

	private sealed class _003C_003Ec__DisplayClass19_0
	{
		public string role;

		public _003C_003Ec__DisplayClass19_0()
		{
			throw null;
		}

		internal bool _003CGetPlayerControlsByRole_003Eb__0(PlayerControl player)
		{
			throw null;
		}
	}

	private sealed class _003C_003Ec__DisplayClass25_0
	{
		public RoleTeamTypes type;

		public _003C_003Ec__DisplayClass25_0()
		{
			throw null;
		}

		internal bool _003CAssignRoleToPlayer_003Eb__0(RoleBehaviour r)
		{
			throw null;
		}
	}

	private sealed class _003C_003Ec__DisplayClass26_0
	{
		public RoleTeamTypes type;

		public _003C_003Ec__DisplayClass26_0()
		{
			throw null;
		}

		internal bool _003CAssignRolesForTeam_003Eb__0(RoleBehaviour r)
		{
			throw null;
		}
	}

	private sealed class _003C_003Ec__DisplayClass7_0
	{
		public Type roleType;

		public _003C_003Ec__DisplayClass7_0()
		{
			throw null;
		}

		internal bool _003CAddRole_003Eb__0(RoleBehaviour r)
		{
			throw null;
		}

		internal bool _003CAddRole_003Eb__1(RoleBehaviour r)
		{
			throw null;
		}
	}

	private sealed class _003C_003Ec__DisplayClass8_0
	{
		public Type type;

		public _003C_003Ec__DisplayClass8_0()
		{
			throw null;
		}

		internal bool _003CGetRoleByType_003Eb__0(RoleBehaviour r)
		{
			throw null;
		}
	}

	public List<RoleBehaviour> allRoles;

	public Dictionary<string, AudioClip> allAudios;

	public Dictionary<string, Sprite> allSprites;

	private Transform RoleHolder;

	private ushort lastRoleId;

	public void Start()
	{
		throw null;
	}

	internal void AddRole<T>() where T : RoleBehaviour
	{
		throw null;
	}

	internal void AddRole(Type roleType, string modName = "")
	{
		throw null;
	}

	public static RoleBehaviour GetRoleByType(Type type)
	{
		throw null;
	}

	public void AddEndGameAudio(string audioName, AudioClip input)
	{
		throw null;
	}

	public void AddSprite(string spriteName, Texture2D input, float pixelsPerUnit = 180f)
	{
		throw null;
	}

	public void AddSprite(string spriteName, Sprite input)
	{
		throw null;
	}

	public static bool CheckRole(GameData.PlayerInfo data, string role)
	{
		throw null;
	}

	public static bool IsSameTeam(GameData.PlayerInfo player1, GameData.PlayerInfo player2)
	{
		throw null;
	}

	public static bool IsTeam(GameData.PlayerInfo player1, RoleTeamTypes team)
	{
		throw null;
	}

	public static bool HasActiveNeutralRoles()
	{
		throw null;
	}

	public void AssignRole(PlayerControl player, string roleName)
	{
		throw null;
	}

	public static List<GameData.PlayerInfo> GetPlayersByRole(string role)
	{
		throw null;
	}

	public static List<GameData.PlayerInfo> GetPlayersByTeam(RoleTeamTypes team)
	{
		throw null;
	}

	public static List<PlayerControl> GetPlayerControlsByRole(string role)
	{
		throw null;
	}

	public static List<PlayerControl> GetAllPlayerControls()
	{
		throw null;
	}

	public static List<PlayerControl> GetAllNotAssignedPlayerControls()
	{
		throw null;
	}

	public static List<GameData.PlayerInfo> GetAllPlayers()
	{
		throw null;
	}

	public static List<GameData.PlayerInfo> GetNotAssignedPlayers()
	{
		throw null;
	}

	public void LogRoles(RoleTeamTypes teamType, List<GameData.PlayerInfo> players, List<RoleBehaviour> roles)
	{
		throw null;
	}

	public bool AssignRoleToPlayer(byte playerId, RoleTeamTypes type)
	{
		throw null;
	}

	public void AssignRolesForTeam(RoleTeamTypes type, int max)
	{
		throw null;
	}

	private void AssignRolesFromList(List<GameData.PlayerInfo> players, int teamMax, List<RoleBehaviour> roleList, ref int rolesAssigned)
	{
		throw null;
	}

	public RoleManager()
	{
		throw null;
	}
}
