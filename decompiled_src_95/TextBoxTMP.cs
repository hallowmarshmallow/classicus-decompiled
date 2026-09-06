using System.Collections.Generic;
using System.Text;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TextBoxTMP : MonoBehaviour, IFocusHolder
{
	public static readonly HashSet<char> SymbolChars;

	public static readonly HashSet<char> EmailChars;

	public static readonly HashSet<char> ArabicPunctuationChars;

	private const int ArabicLanguageIndex = 16;

	public const char HiddenChar = '*';

	public bool allowAllCharacters;

	public string text;

	private string compoText;

	public int characterLimit;

	public TextMeshPro outputText;

	public SpriteRenderer Background;

	public MeshRenderer Pipe;

	private float pipeBlinkTimer;

	public bool ClearOnFocus;

	public bool ForceUppercase;

	public Button.ButtonClickedEvent OnEnter;

	public Button.ButtonClickedEvent OnChange;

	public Button.ButtonClickedEvent OnFocusLost;

	private TouchScreenKeyboard keyboard;

	public bool AllowSymbols;

	public bool AllowEmoji;

	public bool AllowEmail;

	public bool IpMode;

	public bool PasswordMode;

	public bool AllowPaste;

	public bool Hidden;

	private Collider2D[] colliders;

	private bool hasFocus;

	public static TextBoxTMP FocusedBox;

	private StringBuilder tempTxt;

	public SpriteRenderer sendButtonGlyph;

	public bool KeepRtlCentered;

	private HorizontalAlignmentOptions defaultHorizontalAlignment;

	private bool capturedDefaultAlignment;

	private bool displayIsRtl;

	public static bool AnyFocused => false;

	public bool HasFocus => false;

	public float TextHeight => 0f;

	private bool SupportsRtl => false;

	private void CaptureDefaultAlignment()
	{
	}

	private bool ShouldRenderRtl(string logicalText)
	{
		return false;
	}

	private void ApplyDisplayText(string display)
	{
	}

	public void Start()
	{
	}

	public void OnDestroy()
	{
	}

	public void Clear()
	{
	}

	public void Update()
	{
	}

	public void GiveFocus()
	{
	}

	public void ForceKeyboardClose()
	{
	}

	public void LoseFocus()
	{
	}

	public bool CheckCollision(Vector2 pt)
	{
		return false;
	}

	public void SetText(string input, string inputCompo = "")
	{
	}

	public bool IsCharAllowed(char i)
	{
		return false;
	}

	private Vector2 GetPipeCursorPosition()
	{
		return default(Vector2);
	}

	public void AddText(string text)
	{
	}

	public void Backspace()
	{
	}

	public void ClearLastWord()
	{
	}
}
