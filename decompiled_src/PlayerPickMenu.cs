using System;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPickMenu : Minigame
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Func<PlayerControl, bool> _003C_003E9__2_0;

		public static Func<PPMButton, int> _003C_003E9__4_0;

		public static Func<PPMButton, byte> _003C_003E9__4_1;

		static _003C_003Ec()
		{
			throw null;
		}

		public _003C_003Ec()
		{
			throw null;
		}

		internal bool _003CPopulateButtons_003Eb__2_0(PlayerControl pc)
		{
			throw null;
		}

		internal int _003CSortButtons_003Eb__4_0(PPMButton p)
		{
			throw null;
		}

		internal byte _003CSortButtons_003Eb__4_1(PPMButton p)
		{
			throw null;
		}
	}

	public Action OnClick;

	public float XStart;

	public float YStart;

	public float XOffset;

	public float YOffset;

	public PPMButton Prefab;

	public List<PPMButton> potentialVictims;

	public Vector3 VoteOrigin;

	public Vector3 VoteButtonOffsets;

	public static void Create(Action act)
	{
		throw null;
	}

	public static void Create(List<PlayerPickOption> opts)
	{
		throw null;
	}

	public void PopulateButtons(Action action)
	{
		throw null;
	}

	public void PopulateButtons(List<PlayerPickOption> opts)
	{
		throw null;
	}

	private void SortButtons()
	{
		throw null;
	}

	public PlayerPickMenu()
	{
		throw null;
	}
}
