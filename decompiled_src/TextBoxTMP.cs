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

	public static bool AnyFocused
	{
		get
		{
			throw null;
		}
	}

	public bool HasFocus
	{
		get
		{
			throw null;
		}
	}

	public float TextHeight
	{
		get
		{
			throw null;
		}
	}

	private bool SupportsRtl
	{
		get
		{
			throw null;
		}
	}

	private void CaptureDefaultAlignment()
	{
		throw null;
	}

	private bool ShouldRenderRtl(string logicalText)
	{
		throw null;
	}

	private void ApplyDisplayText(string display)
	{
		throw null;
	}

	public void Start()
	{
		throw null;
	}

	public void OnDestroy()
	{
		throw null;
	}

	public void Clear()
	{
		throw null;
	}

	public void Update()
	{
		throw null;
	}

	public void GiveFocus()
	{
		throw null;
	}

	public void ForceKeyboardClose()
	{
		throw null;
	}

	public void LoseFocus()
	{
		throw null;
	}

	public bool CheckCollision(Vector2 pt)
	{
		throw null;
	}

	public void SetText(string input, string inputCompo = "")
	{
		throw null;
	}

	public bool IsCharAllowed(char i)
	{
		throw null;
	}

	private Vector2 GetPipeCursorPosition()
	{
		throw null;
	}

	public void AddText(string text)
	{
		throw null;
	}

	public void Backspace()
	{
		throw null;
	}

	public void ClearLastWord()
	{
		throw null;
	}

	public TextBoxTMP()
	{
		throw null;
	}

	static TextBoxTMP()
	{
		throw null;
	}
}
