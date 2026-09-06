using System;

namespace InnerNet;

public static class GameCode
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Func<char, bool> _003C_003E9__0_0;

		public static Func<char, bool> _003C_003E9__1_0;

		public static Func<char, bool> _003C_003E9__3_0;

		public static Func<char, bool> _003C_003E9__4_0;

		internal bool _003CIntToGameName_003Eb__0_0(char c)
		{
			return false;
		}

		internal bool _003CGameNameToInt_003Eb__1_0(char c)
		{
			return false;
		}

		internal bool _003CIntToGameNameV2_003Eb__3_0(char c)
		{
			return false;
		}

		internal bool _003CGameNameToIntV2_003Eb__4_0(char c)
		{
			return false;
		}

		internal int _003C_002Ecctor_003Eb__10_0(int v)
		{
			return 0;
		}
	}

	public static readonly int GameCodeV2MinVersion;

	private static readonly string V2;

	private static readonly int[] V2Map;

	public static string IntToGameName(int gameId)
	{
		return null;
	}

	public static int GameNameToInt(string gameId)
	{
		return 0;
	}

	public static int CreateGameId(int sn, int gn)
	{
		return 0;
	}

	private static string IntToGameNameV2(int gameId)
	{
		return null;
	}

	private static int GameNameToIntV2(string gameId)
	{
		return 0;
	}
}
