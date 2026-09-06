using TMPro;
using UnityEngine;

public class StreamerModeButton : MonoBehaviour, ITranslatedText
{
	public TextMeshPro Text;

	public SpriteRenderer Background;

	public ButtonRolloverHandler Rollover;

	private static readonly Color OnColor;

	private static readonly Color OffColor;

	private bool _resolved;

	public void Start()
	{
	}

	public void OnDestroy()
	{
	}

	private void OnEnable()
	{
	}

	public void Toggle()
	{
	}

	private void Resolve()
	{
	}

	public void ResetText()
	{
	}

	private static string GetString(StringNames id, string fallback)
	{
		return null;
	}
}
