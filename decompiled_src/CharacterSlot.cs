using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CharacterSlot : MonoBehaviour
{
	private GameObject _filledObject;

	private GameObject _emptyObject;

	private TMP_Text _nameText;

	private TMP_Text _classText;

	private TMP_Text _levelText;

	private Image _classImage;

	private Image _slotImage;

	private Transform _spinnerImage;

	private Sprite _slotDefaultSprite;

	private Sprite _slotSelectedSprite;

	private bool _selected;

	private SlotData _data;

	private static Action<SlotData> m_SlotSelected;

	public static event Action<SlotData> SlotSelected
	{
		add
		{
			throw null;
		}
		remove
		{
			throw null;
		}
	}

	private void Awake()
	{
		throw null;
	}

	private void OnDestroy()
	{
		throw null;
	}

	public void InitSlot(int index, CharacterData data)
	{
		throw null;
	}

	public void SelectSlot()
	{
		throw null;
	}

	private void ToggleSlot(SlotData data)
	{
		throw null;
	}

	private void DeSelectSlot()
	{
		throw null;
	}

	public CharacterSlot()
	{
		throw null;
	}
}
