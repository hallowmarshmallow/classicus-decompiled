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

		internal bool _003CPopulateButtons_003Eb__2_0(PlayerControl pc)
		{
			return false;
		}

		internal int _003CSortButtons_003Eb__4_0(PPMButton p)
		{
			return 0;
		}

		internal byte _003CSortButtons_003Eb__4_1(PPMButton p)
		{
			return 0;
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
	}

	public static void Create(List<PlayerPickOption> opts)
	{
	}

	public void PopulateButtons(Action action)
	{
	}

	public void PopulateButtons(List<PlayerPickOption> opts)
	{
	}

	private void SortButtons()
	{
	}
}
