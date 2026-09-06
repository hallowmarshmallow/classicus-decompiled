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

		public float Delay
		{
			get
			{
				throw null;
			}
		}

		public FrameDisposalMethod DisposalMethod
		{
			get
			{
				throw null;
			}
		}

		public bool TransparentColorFlag
		{
			get
			{
				throw null;
			}
		}

		public int TransparentColorIndex
		{
			get
			{
				throw null;
			}
		}

		public GIFGraphicsControl()
		{
			throw null;
		}
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

		public GIFGraphicsControl GraphicsControl
		{
			get
			{
				throw null;
			}
		}

		public float Delay
		{
			get
			{
				throw null;
			}
		}

		public FrameDisposalMethod DisposalMethod
		{
			get
			{
				throw null;
			}
		}

		public bool IsRendered
		{
			get
			{
				throw null;
			}
		}

		public Color[] LocalColorTable
		{
			get
			{
				throw null;
			}
		}

		public bool HasLocalColorTable
		{
			get
			{
				throw null;
			}
		}

		public int LeftPosition
		{
			get
			{
				throw null;
			}
		}

		public int TopPosition
		{
			get
			{
				throw null;
			}
		}

		public int Width
		{
			get
			{
				throw null;
			}
		}

		public int Height
		{
			get
			{
				throw null;
			}
		}

		public List<ushort> IndexStream
		{
			get
			{
				throw null;
			}
			set
			{
				throw null;
			}
		}

		public Sprite RenderedSprite
		{
			get
			{
				throw null;
			}
			set
			{
				throw null;
			}
		}

		public GIFFrame()
		{
			throw null;
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

	public bool IsLoaded
	{
		get
		{
			throw null;
		}
	}

	private GIFGraphicsControl _lastGraphicsControl
	{
		set
		{
			throw null;
		}
	}

	public ushort Width
	{
		get
		{
			throw null;
		}
	}

	public ushort Height
	{
		get
		{
			throw null;
		}
	}

	public List<GIFFrame> Frames
	{
		get
		{
			throw null;
		}
	}

	public void Dispose()
	{
		throw null;
	}

	public Sprite GetFrameSprite(int frameIndex)
	{
		throw null;
	}

	public void RenderAllFrames()
	{
		throw null;
	}

	public void RenderFrame(int frameIndex)
	{
		throw null;
	}

	static GIFFile()
	{
		throw null;
	}
}
