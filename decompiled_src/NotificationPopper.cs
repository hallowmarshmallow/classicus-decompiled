using System.Text;
using TMPro;
using UnityEngine;

public class NotificationPopper : MonoBehaviour
{
	private sealed class TextTarget
	{
		internal TextRenderer Renderer;

		internal TMP_Text Tmp;

		internal bool Valid
		{
			get
			{
				throw null;
			}
		}

		internal void SetText(string value)
		{
			throw null;
		}

		internal void SetColor(Color value)
		{
			throw null;
		}

		internal bool Is(TextTarget other)
		{
			throw null;
		}

		public TextTarget()
		{
			throw null;
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
		throw null;
	}

	private float ClearOfTaskPanelY()
	{
		throw null;
	}

	public void AddItem(string item)
	{
		throw null;
	}

	private void SelectSide()
	{
		throw null;
	}

	private void Resolve()
	{
		throw null;
	}

	private static TextTarget Wrap(GameObject go)
	{
		throw null;
	}

	private static TextTarget FindByName(string objectName)
	{
		throw null;
	}

	private static TextTarget ScanTransforms(Transform[] transforms, string objectName)
	{
		throw null;
	}

	public NotificationPopper()
	{
		throw null;
	}
}
