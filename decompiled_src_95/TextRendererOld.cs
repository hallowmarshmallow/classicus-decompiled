using System;
using System.Collections.Generic;
using UnityEngine;

public class TextRendererOld : MonoBehaviour
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Func<char, bool> _003C_003E9__31_0;

		internal bool _003CRefreshMesh_003Eb__31_0(char c)
		{
			return false;
		}
	}

	public TextAsset FontData;

	public float scale;

	public float TabWidth;

	public bool Centered;

	public bool RightAligned;

	public TextLink textLinkPrefab;

	private Mesh mesh;

	public MeshRenderer render;

	public string Text;

	private string lastText;

	public Color Color;

	private Color lastColor;

	public Color OutlineColor;

	private Color lastOutlineColor;

	public float maxWidth;

	public bool scaleToFit;

	public bool paragraphSpacing;

	private Vector2 cursorLocation;

	private float _003CWidth_003Ek__BackingField;

	private float _003CHeight_003Ek__BackingField;

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

	public Vector3 CursorPos => default(Vector3);

	public void Start()
	{
	}

	public void GenerateMesh()
	{
	}

	private void Update()
	{
	}

	public void RefreshMesh()
	{
	}

	private float GetMaxWidth(FontData data, string lastText)
	{
		return 0f;
	}

	private void RightAlignVerts(List<Vector3> verts, float baseX, int lineStart, float scale)
	{
	}

	private void CenterVerts(List<Vector3> verts, float baseX, int lineStart, float scale)
	{
	}

	private int CharToInt(int c)
	{
		return 0;
	}

	public static string WrapText(FontData data, string displayTxt, float maxWidth)
	{
		return null;
	}
}
