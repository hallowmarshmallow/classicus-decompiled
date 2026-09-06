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
		throw null;
	}

	private static void UseMaskedEmoji(TMP_Text label)
	{
		throw null;
	}

	internal void SetText(string chatText)
	{
		throw null;
	}

	public void AlignChildren()
	{
		throw null;
	}

	public void SetLeft()
	{
		throw null;
	}

	public void SetNotification()
	{
		throw null;
	}

	public void SetWarning(string text)
	{
		throw null;
	}

	public void SetRight()
	{
		throw null;
	}

	public void SetName(string playerName, bool isDead, bool voted, Color color)
	{
		throw null;
	}

	public override void Reset()
	{
		throw null;
	}

	public ChatBubble()
	{
		throw null;
	}
}
