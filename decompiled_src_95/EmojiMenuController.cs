using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class EmojiMenuController : MonoBehaviour
{
	private sealed class _003C_003Ec__DisplayClass14_0
	{
		public int spriteIndex;

		public EmojiMenuController _003C_003E4__this;

		internal void _003CWireCells_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass15_0
	{
		public EmojiMenuController _003C_003E4__this;

		public int step;

		internal void _003CWireArrow_003Eb__0()
		{
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
	}

	private void OnEnable()
	{
	}

	private void WireOnce()
	{
	}

	private GameObject Child(string path)
	{
		return null;
	}

	private void WireCells(Transform page, List<string> unresolved)
	{
	}

	private void WireArrow(GameObject arrow, int step)
	{
	}

	private static PassiveButton MakeButton(GameObject go)
	{
		return null;
	}

	private void RefreshPage()
	{
	}

	private void Insert(int spriteIndex)
	{
	}

	private static Dictionary<string, int> SpriteIndexByName()
	{
		return null;
	}
}
