using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class VitalsMinigame : Minigame
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Func<GameData.PlayerInfo, bool> _003C_003E9__19_0;

		internal bool _003CBegin_003Eb__19_0(GameData.PlayerInfo p)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass19_0
	{
		public Dictionary<byte, bool> vitalDisconnected;

		internal int _003CBegin_003Eb__1(GameData.PlayerInfo a, GameData.PlayerInfo b)
		{
			return 0;
		}
	}

	private sealed class _003C_003Ec__DisplayClass19_1
	{
		public GameData.PlayerInfo player;

		internal bool _003CBegin_003Eb__2(DeadBody b)
		{
			return false;
		}
	}

	public TextMeshPro BatteryText;

	public VitalsPanel PanelPrefab;

	public TextMeshPro SabText;

	public float XStart;

	public float YStart;

	public float XOffset;

	public float YOffset;

	public GameObject NextPages;

	public GameObject LeftArrow;

	public GameObject RightArrow;

	public TextMeshPro PageText;

	public int Columns;

	public int Rows;

	private VitalsPanel[] vitals;

	private int currentPage;

	private int PerPage => 0;

	private int MaxPages => 0;

	public override void Begin(PlayerTask task)
	{
	}

	private void ApplyPage()
	{
	}

	private static string BuildPageLabel(int page, int total)
	{
		return null;
	}

	public void AdvancePage()
	{
	}

	public void RecedePage()
	{
	}

	private void Update()
	{
	}
}
