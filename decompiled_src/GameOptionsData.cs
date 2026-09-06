using System;
using System.IO;

public class GameOptionsData : IBytesSerializable
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Func<RoleBehaviour, bool> _003C_003E9__66_0;

		public static Func<RoleBehaviour, bool> _003C_003E9__66_1;

		public static Func<RoleBehaviour, bool> _003C_003E9__66_2;

		public static Func<RoleBehaviour, bool> _003C_003E9__66_3;

		static _003C_003Ec()
		{
			throw null;
		}

		public _003C_003Ec()
		{
			throw null;
		}

		internal bool _003CToHudString_003Eb__66_0(RoleBehaviour r)
		{
			throw null;
		}

		internal bool _003CToHudString_003Eb__66_1(RoleBehaviour r)
		{
			throw null;
		}

		internal bool _003CToHudString_003Eb__66_2(RoleBehaviour r)
		{
			throw null;
		}

		internal bool _003CToHudString_003Eb__66_3(RoleBehaviour r)
		{
			throw null;
		}
	}

	private const byte GameDataVersion = 6;

	public static readonly float[] KillDistances;

	public static readonly string[] KillDistanceStrings;

	public int MaxPlayers;

	public uint Keywords;

	public byte MapId;

	public bool ConfirmEjections;

	public bool AnonymousVotes;

	public float PlayerSpeedMod;

	public float CrewLightMod;

	public float ImpostorLightMod;

	public float KillCooldown;

	public int NumCommonTasks;

	public int NumLongTasks;

	public int NumShortTasks;

	public int NumEmergencyMeetings;

	public int EmergencyCooldown;

	public int NumImpostors;

	public int NumNeutrals;

	public bool GhostsDoTasks;

	public bool VisualTasks;

	public TaskBarMode TaskBarMode;

	public int KillDistance;

	public int DiscussionTime;

	public int VotingTime;

	public byte GameModeId;

	public bool ProximityChat;

	public int ProximityChatFilter;

	public byte RunnerPowerUpSpawnRate;

	public bool BossMode;

	public byte RunnerReviveChance;

	public byte RunnerFreezeChance;

	public byte RunnerSpeedChance;

	public byte RunnerShieldChance;

	public const byte MaxRunnerReviveChance = 35;

	public const byte MaxRunnerFreezeChance = 50;

	public const byte MaxRunnerSpeedChance = 30;

	public const byte MaxRunnerShieldChance = 50;

	public bool RoleSwapMode;

	private static readonly int[] RecommendedKillCooldown;

	private static readonly int[] RecommendedImpostors;

	public static readonly int[] MinPlayers;

	public float HnSEscapeTime;

	public float HnSHuntTime;

	public float HnSCrewVentDuration;

	public float HnSFinalHuntTime;

	public float HnSPingInterval;

	public float HnSSeekerSpeed;

	public float HnSSeekerFinalSpeed;

	public float HnSVentCooldown;

	public float HnSVentAmount;

	public float HnSPreferredSeeker;

	public int currentPage;

	public HnSModeManagerAccessor ModeManager
	{
		get
		{
			throw null;
		}
	}

	private static void ClampRunnerChances(GameOptionsData opts)
	{
		throw null;
	}

	public void ToggleMapFilter(byte newId)
	{
		throw null;
	}

	public bool FilterContainsMap(byte newId)
	{
		throw null;
	}

	public void Serialize(BinaryWriter writer)
	{
		throw null;
	}

	public static GameOptionsData Deserialize(BinaryReader reader)
	{
		throw null;
	}

	public byte[] ToBytes()
	{
		throw null;
	}

	public static GameOptionsData FromBytes(byte[] bytes)
	{
		throw null;
	}

	public override string ToString()
	{
		throw null;
	}

	public void SyncAllRoleOptions()
	{
		throw null;
	}

	public string ToHudString()
	{
		throw null;
	}

	public GameOptionsData()
	{
		throw null;
	}

	static GameOptionsData()
	{
		throw null;
	}
}
