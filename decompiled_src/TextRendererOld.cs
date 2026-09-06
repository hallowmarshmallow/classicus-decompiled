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

		static _003C_003Ec()
		{
			throw null;
		}

		public _003C_003Ec()
		{
			throw null;
		}

		internal bool _003CRefreshMesh_003Eb__31_0(char c)
		{
			throw null;
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
			throw null;
		}
		private set
		{
			throw null;
		}
	}

	public float Height
	{
		get
		{
			throw null;
		}
		private set
		{
			throw null;
		}
	}

	public Vector3 CursorPos
	{
		get
		{
			throw null;
		}
	}

	public void Start()
	{
		throw null;
	}

	public void GenerateMesh()
	{
		throw null;
	}

	private void Update()
	{
		throw null;
	}

	public void RefreshMesh()
	{
		throw null;
	}

	private float GetMaxWidth(FontData data, string lastText)
	{
		throw null;
	}

	private void RightAlignVerts(List<Vector3> verts, float baseX, int lineStart, float scale)
	{
		throw null;
	}

	private void CenterVerts(List<Vector3> verts, float baseX, int lineStart, float scale)
	{
		throw null;
	}

	private int CharToInt(int c)
	{
		throw null;
	}

	public static string WrapText(FontData data, string displayTxt, float maxWidth)
	{
		throw null;
	}

	public TextRendererOld()
	{
		throw null;
	}
}
