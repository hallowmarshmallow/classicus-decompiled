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

		static _003C_003Ec()
		{
			throw null;
		}

		public _003C_003Ec()
		{
			throw null;
		}

		internal bool _003CBegin_003Eb__19_0(GameData.PlayerInfo p)
		{
			throw null;
		}
	}

	private sealed class _003C_003Ec__DisplayClass19_0
	{
		public Dictionary<byte, bool> vitalDisconnected;

		public _003C_003Ec__DisplayClass19_0()
		{
			throw null;
		}

		internal int _003CBegin_003Eb__1(GameData.PlayerInfo a, GameData.PlayerInfo b)
		{
			throw null;
		}
	}

	private sealed class _003C_003Ec__DisplayClass19_1
	{
		public GameData.PlayerInfo player;

		public _003C_003Ec__DisplayClass19_1()
		{
			throw null;
		}

		internal bool _003CBegin_003Eb__2(DeadBody b)
		{
			throw null;
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

	private int PerPage
	{
		get
		{
			throw null;
		}
	}

	private int MaxPages
	{
		get
		{
			throw null;
		}
	}

	public override void Begin(PlayerTask task)
	{
		throw null;
	}

	private void ApplyPage()
	{
		throw null;
	}

	private static string BuildPageLabel(int page, int total)
	{
		throw null;
	}

	public void AdvancePage()
	{
		throw null;
	}

	public void RecedePage()
	{
		throw null;
	}

	private void Update()
	{
		throw null;
	}

	public VitalsMinigame()
	{
		throw null;
	}
}
