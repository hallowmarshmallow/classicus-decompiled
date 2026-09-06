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

	private bool IsListening => false;

	public void Start()
	{
	}

	public void OnDestroy()
	{
	}

	private void OnDisable()
	{
	}

	private void WireClick()
	{
	}

	private void OnPointerEnter()
	{
	}

	private void OnPointerExit()
	{
	}

	public void BeginListening()
	{
	}

	private void Update()
	{
	}

	private void UpdateHoldToReset()
	{
	}

	private void CancelHold()
	{
	}

	private static void RefreshAll()
	{
	}

	public void ResetText()
	{
	}

	private static string GetString(StringNames id)
	{
		return null;
	}

	private static string FormatCountdown(int seconds)
	{
		return null;
	}
}
