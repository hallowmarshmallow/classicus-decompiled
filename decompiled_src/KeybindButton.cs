using TMPro;
using UnityEngine;

public class KeybindButton : MonoBehaviour, ITranslatedText
{
	public KeybindAction Action;

	public StringNames BaseText;

	public TextMeshPro Text;

	public SpriteRenderer Background;

	public ButtonRolloverHandler Rollover;

	private static readonly Color IdleColor;

	private static readonly Color ListeningColor;

	private static readonly Color ResettingColor;

	private const float HoldBeforeCountdown = 1.5f;

	private const float ResetCountdown = 2f;

	private bool _pointerOver;

	private float _holdTime;

	private int _shownCountdown;

	private bool _suppressNextClick;

	private static KeybindButton _listening;

	private int _armedFrame;

	private bool IsListening
	{
		get
		{
			throw null;
		}
	}

	public void Start()
	{
		throw null;
	}

	public void OnDestroy()
	{
		throw null;
	}

	private void OnDisable()
	{
		throw null;
	}

	private void WireClick()
	{
		throw null;
	}

	private void OnPointerEnter()
	{
		throw null;
	}

	private void OnPointerExit()
	{
		throw null;
	}

	public void BeginListening()
	{
		throw null;
	}

	private void Update()
	{
		throw null;
	}

	private void UpdateHoldToReset()
	{
		throw null;
	}

	private void CancelHold()
	{
		throw null;
	}

	private static void RefreshAll()
	{
		throw null;
	}

	public void ResetText()
	{
		throw null;
	}

	private static string GetString(StringNames id)
	{
		throw null;
	}

	private static string FormatCountdown(int seconds)
	{
		throw null;
	}

	public KeybindButton()
	{
		throw null;
	}

	static KeybindButton()
	{
		throw null;
	}
}
