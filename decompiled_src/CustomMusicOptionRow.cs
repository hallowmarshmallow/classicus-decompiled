using TMPro;
using UnityEngine;

public class CustomMusicOptionRow : MonoBehaviour, ITranslatedText
{
	public enum RowKind
	{
		Toggle,
		FilePicker
	}

	public RowKind Kind;

	public TextMeshPro Text;

	public SpriteRenderer Background;

	public ButtonRolloverHandler Rollover;

	private static readonly Color OnColor;

	private static readonly Color BusyColor;

	private Color _idleBackground;

	private Color _idleOutline;

	private bool _registered;

	private bool _subscribed;

	private void Awake()
	{
		throw null;
	}

	private void Start()
	{
		throw null;
	}

	private void OnEnable()
	{
		throw null;
	}

	private void OnDestroy()
	{
		throw null;
	}

	private void OnClick()
	{
		throw null;
	}

	public void ResetText()
	{
		throw null;
	}

	public CustomMusicOptionRow()
	{
		throw null;
	}

	static CustomMusicOptionRow()
	{
		throw null;
	}
}
