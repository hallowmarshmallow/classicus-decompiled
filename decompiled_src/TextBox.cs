using System.Collections.Generic;
using System.Text;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TextBox : MonoBehaviour, IFocusHolder
{
	public static readonly HashSet<char> SymbolChars;

	public string text;

	private string compoText;

	public int characterLimit;

	private TextRenderer outputText;

	public SpriteRenderer Background;

	public TMP_InputField Inputter;

	public MeshRenderer Pipe;

	private float pipeBlinkTimer;

	public bool ClearOnFocus;

	public bool ForceUppercase;

	public Button.ButtonClickedEvent OnEnter;

	public Button.ButtonClickedEvent OnChange;

	public Button.ButtonClickedEvent OnFocusLost;

	public bool AllowSymbols;

	public bool IpMode;

	private Collider2D[] colliders;

	private bool hasFocus;

	private StringBuilder tempTxt;

	private const char PIPE_CHAR = '|';

	private bool isUpdatingInputter;

	private HorizontalAlignmentOptions defaultHorizontalAlignment;

	private bool capturedDefaultAlignment;

	public float TextHeight
	{
		get
		{
			throw null;
		}
	}

	private static string StripPipe(string raw)
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

	private void OnInputterValueChanged(string newValue)
	{
		throw null;
	}

	private void ApplyRtlDisplay(string clean)
	{
		throw null;
	}

	private void SetInputterText(string value)
	{
		throw null;
	}

	public void GiveFocus()
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

	public TextBox()
	{
		throw null;
	}

	static TextBox()
	{
		throw null;
	}
}
