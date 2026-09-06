using System.Text;
using TMPro;
using UnityEngine;

public class NotificationPopper : MonoBehaviour
{
	private sealed class TextTarget
	{
		internal TextRenderer Renderer;

		internal TMP_Text Tmp;

		internal bool Valid => false;

		internal void SetText(string value)
		{
		}

		internal void SetColor(Color value)
		{
		}

		internal bool Is(TextTarget other)
		{
			return false;
		}
	}

	public TextRenderer TextArea;

	public GameObject LeftTextObject;

	public GameObject RightTextObject;

	public float zPos;

	private float alphaTimer;

	public float ShowDuration;

	public float FadeDuration;

	public Color textColor;

	private StringBuilder builder;

	public AudioClip NotificationSound;

	private TextTarget left;

	private TextTarget right;

	private TextTarget active;

	private bool resolved;

	private const float TaskPanelGap = 0.28f;

	public void Update()
	{
	}

	private float ClearOfTaskPanelY()
	{
		return 0f;
	}

	public void AddItem(string item)
	{
	}

	private void SelectSide()
	{
	}

	private void Resolve()
	{
	}

	private static TextTarget Wrap(GameObject go)
	{
		return null;
	}

	private static TextTarget FindByName(string objectName)
	{
		return null;
	}

	private static TextTarget ScanTransforms(Transform[] transforms, string objectName)
	{
		return null;
	}
}
