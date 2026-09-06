using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class EmojiMenuController : MonoBehaviour
{
	private sealed class _003C_003Ec__DisplayClass14_0
	{
		public int spriteIndex;

		public EmojiMenuController _003C_003E4__this;

		public _003C_003Ec__DisplayClass14_0()
		{
			throw null;
		}

		internal void _003CWireCells_003Eb__0()
		{
			throw null;
		}
	}

	private sealed class _003C_003Ec__DisplayClass15_0
	{
		public EmojiMenuController _003C_003E4__this;

		public int step;

		public _003C_003Ec__DisplayClass15_0()
		{
			throw null;
		}

		internal void _003CWireArrow_003Eb__0()
		{
			throw null;
		}
	}

	private const int TotalPages = 2;

	public ChatController Chat;

	private bool _wired;

	private int _page;

	private Transform _page1;

	private Transform _page2;

	private GameObject _leftArrow;

	private GameObject _rightArrow;

	private TextMeshPro _pageLabel;

	private static Dictionary<string, int> _spriteIndexByName;

	public static void Attach(ChatController chat)
	{
		throw null;
	}

	private void OnEnable()
	{
		throw null;
	}

	private void WireOnce()
	{
		throw null;
	}

	private GameObject Child(string path)
	{
		throw null;
	}

	private void WireCells(Transform page, List<string> unresolved)
	{
		throw null;
	}

	private void WireArrow(GameObject arrow, int step)
	{
		throw null;
	}

	private static PassiveButton MakeButton(GameObject go)
	{
		throw null;
	}

	private void RefreshPage()
	{
		throw null;
	}

	private void Insert(int spriteIndex)
	{
		throw null;
	}

	private static Dictionary<string, int> SpriteIndexByName()
	{
		throw null;
	}

	public EmojiMenuController()
	{
		throw null;
	}
}
