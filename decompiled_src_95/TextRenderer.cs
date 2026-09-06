using TMPro;
using UnityEngine;

public class TextRenderer : MonoBehaviour
{
	public TextMeshPro TextData;

	public TMP_InputField TextDataInputField;

	public float scale;

	public float TabWidth;

	public bool Centered;

	public bool RightAligned;

	public TextLink textLinkPrefab;

	public float maxWidth;

	public bool scaleToFit;

	public bool paragraphSpacing;

	private float _003CWidth_003Ek__BackingField;

	private float _003CHeight_003Ek__BackingField;

	public float RealHeight;

	public bool CalculateBounds;

	public MeshRenderer render;

	public float Width
	{
		get
		{
			return _003CWidth_003Ek__BackingField;
		}
		private set
		{
			_003CWidth_003Ek__BackingField = value;
		}
	}

	public float Height
	{
		get
		{
			return _003CHeight_003Ek__BackingField;
		}
		private set
		{
			_003CHeight_003Ek__BackingField = value;
		}
	}

	public string Text
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public Color Color
	{
		get
		{
			return default(Color);
		}
		set
		{
		}
	}

	public Vector3 CursorPos => default(Vector3);

	public void RefreshMesh()
	{
	}

	private void Start()
	{
	}

	private void Update()
	{
	}
}
