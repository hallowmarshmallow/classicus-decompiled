using System;
using UnityEngine;

public sealed class RoleSwapDirector : MonoBehaviour
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Func<PlayerControl, bool> _003C_003E9__7_0;

		static _003C_003Ec()
		{
			throw null;
		}

		public _003C_003Ec()
		{
			throw null;
		}

		internal bool _003COnPlayerExiled_003Eb__7_0(PlayerControl p)
		{
			throw null;
		}
	}

	public const float ShuffleInterval = 60f;

	private static float _nextShuffleAt;

	private static bool _running;

	public static float TimeUntilNextShuffle
	{
		get
		{
			throw null;
		}
	}

	public static bool IsActive()
	{
		throw null;
	}

	private void Update()
	{
		throw null;
	}

	public static void OnPlayerExiled(GameData.PlayerInfo exiled)
	{
		throw null;
	}

	private static void ShuffleRoles()
	{
		throw null;
	}

	public RoleSwapDirector()
	{
		throw null;
	}
}
