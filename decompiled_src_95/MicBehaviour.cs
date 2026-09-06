using TMPro;
using UnityEngine;

public class MicBehaviour : MonoBehaviour
{
	public SpriteRenderer rend;

	public TextMeshPro PushToTalk;

	public Sprite MicEnabledSprite;

	public Sprite MicDisabledSprite;

	private readonly Color TCyan;

	private readonly Color TGreen;

	private void OnDisable()
	{
	}

	private void Update()
	{
	}

	private void ApplyKeyHint()
	{
	}

	private void SetPttVisible(bool visible)
	{
	}

	public void TogglePTT()
	{
	}

	private static void ForceKeyToTalk(string reason)
	{
	}
}
