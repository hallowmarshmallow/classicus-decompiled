using System;
using System.Collections.Generic;
using InnerNet;
using UnityEngine;

public class BanMenu : MonoBehaviour
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Func<int, bool> _003C_003E9__12_0;

		static _003C_003Ec()
		{
			throw null;
		}

		public _003C_003Ec()
		{
			throw null;
		}

		internal bool _003CUpdate_003Eb__12_0(int c)
		{
			throw null;
		}
	}

	private sealed class _003C_003Ec__DisplayClass12_0
	{
		public ClientData client;

		public _003C_003Ec__DisplayClass12_0()
		{
			throw null;
		}

		internal bool _003CUpdate_003Eb__1(BanButton b)
		{
			throw null;
		}
	}

	public BanButton BanButtonPrefab;

	public SpriteRenderer Background;

	public SpriteRenderer BanButton;

	public SpriteRenderer KickButton;

	public SpriteRenderer ReportButton;

	public GameObject ContentParent;

	public int selected;

	public List<BanButton> allButtons;

	private int _reportTarget;

	private static readonly Color DisabledKickColor;

	private bool IsInMatch
	{
		get
		{
			throw null;
		}
	}

	public void SetVisible(bool show)
	{
		throw null;
	}

	private void Update()
	{
		throw null;
	}

	public void Show()
	{
		throw null;
	}

	public void Hide()
	{
		throw null;
	}

	public void Select(int client)
	{
		throw null;
	}

	public void Kick(bool ban)
	{
		throw null;
	}

	public void Report()
	{
		throw null;
	}

	public BanMenu()
	{
		throw null;
	}

	static BanMenu()
	{
		throw null;
	}
}
