using System;
using System.Collections.Generic;
using UnityEngine;

namespace LevelImposter.Api;

public class GIFFile : IDisposable
{
	public enum FrameDisposalMethod
	{
		NoDisposal,
		DoNotDispose,
		RestoreToBackgroundColor,
		RestoreToPrevious
	}

	public class GIFGraphicsControl
	{
		private float _003CDelay_003Ek__BackingField;

		private FrameDisposalMethod _003CDisposalMethod_003Ek__BackingField;

		private bool _003CTransparentColorFlag_003Ek__BackingField;

		private int _003CTransparentColorIndex_003Ek__BackingField;

		public float Delay => _003CDelay_003Ek__BackingField;

		public FrameDisposalMethod DisposalMethod => _003CDisposalMethod_003Ek__BackingField;

		public bool TransparentColorFlag => _003CTransparentColorFlag_003Ek__BackingField;

		public int TransparentColorIndex => _003CTransparentColorIndex_003Ek__BackingField;
	}

	public class GIFFrame
	{
		private GIFGraphicsControl _003CGraphicsControl_003Ek__BackingField;

		private Color[] _003CLocalColorTable_003Ek__BackingField;

		private bool _003CHasLocalColorTable_003Ek__BackingField;

		private bool _003CInterlaceFlag_003Ek__BackingField;

		private bool _003CSortFlag_003Ek__BackingField;

		private int _003CLeftPosition_003Ek__BackingField;

		private int _003CTopPosition_003Ek__BackingField;

		private int _003CWidth_003Ek__BackingField;

		private int _003CHeight_003Ek__BackingField;

		private List<ushort> _003CIndexStream_003Ek__BackingField;

		private Sprite _003CRenderedSprite_003Ek__BackingField;

		public GIFGraphicsControl GraphicsControl => _003CGraphicsControl_003Ek__BackingField;

		public float Delay => 0f;

		public FrameDisposalMethod DisposalMethod => default(FrameDisposalMethod);

		public bool IsRendered => false;

		public Color[] LocalColorTable => _003CLocalColorTable_003Ek__BackingField;

		public bool HasLocalColorTable => _003CHasLocalColorTable_003Ek__BackingField;

		public int LeftPosition => _003CLeftPosition_003Ek__BackingField;

		public int TopPosition => _003CTopPosition_003Ek__BackingField;

		public int Width => _003CWidth_003Ek__BackingField;

		public int Height => _003CHeight_003Ek__BackingField;

		public List<ushort> IndexStream
		{
			get
			{
				return _003CIndexStream_003Ek__BackingField;
			}
			set
			{
				_003CIndexStream_003Ek__BackingField = value;
			}
		}

		public Sprite RenderedSprite
		{
			get
			{
				return _003CRenderedSprite_003Ek__BackingField;
			}
			set
			{
				_003CRenderedSprite_003Ek__BackingField = value;
			}
		}
	}

	private static readonly Color[] DEFAULT_COLOR_TABLE;

	private static readonly ushort[][] _codeTable;

	private readonly Color _backgroundColor;

	private Color[] _globalColorTable;

	private int _globalColorTableSize;

	private bool _hasGlobalColorTable;

	private Vector2 _pivotPoint;

	private Color[] _pixelBuffer;

	public bool isPixelArt;

	private bool _003CIsLoaded_003Ek__BackingField;

	private string _003CName_003Ek__BackingField;

	private GIFGraphicsControl _003C_lastGraphicsControl_003Ek__BackingField;

	private ushort _003CWidth_003Ek__BackingField;

	private ushort _003CHeight_003Ek__BackingField;

	private List<GIFFrame> _003CFrames_003Ek__BackingField;

	public bool IsLoaded => _003CIsLoaded_003Ek__BackingField;

	private GIFGraphicsControl _lastGraphicsControl
	{
		set
		{
			_003C_lastGraphicsControl_003Ek__BackingField = value;
		}
	}

	public ushort Width => _003CWidth_003Ek__BackingField;

	public ushort Height => _003CHeight_003Ek__BackingField;

	public List<GIFFrame> Frames => _003CFrames_003Ek__BackingField;

	public void Dispose()
	{
	}

	public Sprite GetFrameSprite(int frameIndex)
	{
		return null;
	}

	public void RenderAllFrames()
	{
	}

	public void RenderFrame(int frameIndex)
	{
	}
}
