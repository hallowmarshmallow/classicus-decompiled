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
	}

	private void Start()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDestroy()
	{
	}

	private void OnClick()
	{
	}

	public void ResetText()
	{
	}
}
