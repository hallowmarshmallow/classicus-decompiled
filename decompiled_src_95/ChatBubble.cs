using TMPro;
using UnityEngine;

internal class ChatBubble : PoolableBehavior
{
	public SpriteRenderer ChatFace;

	public SpriteRenderer Xmark;

	public SpriteRenderer votedMark;

	public TextMeshPro NameText;

	public TextMeshPro TextArea;

	public SpriteRenderer Background;

	public Vector3 textAreaPosLeft;

	public float textAreaWidthLeft;

	public Vector3 textAreaPosRight;

	public float textAreaWidthRight;

	public Vector3 nameTextPosLeft;

	public float nameTextWidthLeft;

	public Vector3 nameTextPosRight;

	public float nameTextWidthRight;

	private bool nameAlignsRight;

	private static TMP_SpriteAsset maskedEmojiAsset;

	private static TMP_SpriteAsset MaskedEmojiAsset()
	{
		return null;
	}

	private static void UseMaskedEmoji(TMP_Text label)
	{
	}

	internal void SetText(string chatText)
	{
	}

	public void AlignChildren()
	{
	}

	public void SetLeft()
	{
	}

	public void SetNotification()
	{
	}

	public void SetWarning(string text)
	{
	}

	public void SetRight()
	{
	}

	public void SetName(string playerName, bool isDead, bool voted, Color color)
	{
	}

	public override void Reset()
	{
	}
}
