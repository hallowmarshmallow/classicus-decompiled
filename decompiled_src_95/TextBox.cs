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

	public float TextHeight => 0f;

	private static string StripPipe(string raw)
	{
		return null;
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

	private void OnInputterValueChanged(string newValue)
	{
	}

	private void ApplyRtlDisplay(string clean)
	{
	}

	private void SetInputterText(string value)
	{
	}

	public void GiveFocus()
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
}
