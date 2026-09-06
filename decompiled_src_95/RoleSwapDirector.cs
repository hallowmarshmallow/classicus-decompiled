using System;
using UnityEngine;

public sealed class RoleSwapDirector : MonoBehaviour
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Func<PlayerControl, bool> _003C_003E9__7_0;

		internal bool _003COnPlayerExiled_003Eb__7_0(PlayerControl p)
		{
			return false;
		}
	}

	public const float ShuffleInterval = 60f;

	private static float _nextShuffleAt;

	private static bool _running;

	public static float TimeUntilNextShuffle => 0f;

	public static bool IsActive()
	{
		return false;
	}

	private void Update()
	{
	}

	public static void OnPlayerExiled(GameData.PlayerInfo exiled)
	{
	}

	private static void ShuffleRoles()
	{
	}
}
