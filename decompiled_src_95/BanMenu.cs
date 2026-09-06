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

		internal bool _003CUpdate_003Eb__12_0(int c)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass12_0
	{
		public ClientData client;

		internal bool _003CUpdate_003Eb__1(BanButton b)
		{
			return false;
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

	private bool IsInMatch => false;

	public void SetVisible(bool show)
	{
	}

	private void Update()
	{
	}

	public void Show()
	{
	}

	public void Hide()
	{
	}

	public void Select(int client)
	{
	}

	public void Kick(bool ban)
	{
	}

	public void Report()
	{
	}
}
