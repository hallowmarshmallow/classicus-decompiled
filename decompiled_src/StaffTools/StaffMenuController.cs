using System;
using System.Collections.Generic;
using UnityEngine;

namespace StaffTools;

public class StaffMenuController : MonoBehaviour
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Func<CommandDescriptor, string> _003C_003E9__53_1;

		public static Func<CommandDescriptor, string> _003C_003E9__69_1;

		static _003C_003Ec()
		{
			throw null;
		}

		public _003C_003Ec()
		{
			throw null;
		}

		internal string _003CListCommandsInBand_003Eb__53_1(CommandDescriptor d)
		{
			throw null;
		}

		internal string _003CRefreshSuggestions_003Eb__69_1(CommandDescriptor d)
		{
			throw null;
		}
	}

	private sealed class _003C_003Ec__DisplayClass53_0
	{
		public bool devBand;

		public int modLevel;

		public StaffMenuController _003C_003E4__this;

		public _003C_003Ec__DisplayClass53_0()
		{
			throw null;
		}

		internal bool _003CListCommandsInBand_003Eb__0(CommandDescriptor d)
		{
			throw null;
		}
	}

	private sealed class _003C_003Ec__DisplayClass69_0
	{
		public StaffMenuController _003C_003E4__this;

		public string prefix;

		public _003C_003Ec__DisplayClass69_0()
		{
			throw null;
		}

		internal bool _003CRefreshSuggestions_003Eb__0(CommandDescriptor d)
		{
			throw null;
		}
	}

	private static StaffMenuController _003CInstance_003Ek__BackingField;

	private const string Pepper = "classicus-staff";

	private const KeyCode ToggleKey = KeyCode.F5;

	private const int IconSize = 64;

	private const string IconPosXKey = "StaffTools.IconX";

	private const string IconPosYKey = "StaffTools.IconY";

	private const float DragThreshold = 8f;

	private static Vector2 _iconPos;

	private static bool _iconPosLoaded;

	private static Vector2 _iconGrabOffset;

	private static Vector2 _iconPressStart;

	private static bool _iconWasDragged;

	private const int MaxOutputLines = 400;

	private static StaffSystem _system;

	private string _sessionToken;

	private StaffRole _role;

	private string _hwid;

	private StaffRole _rosterRole;

	private float _nextRoleCheck;

	private bool _welcomed;

	private readonly List<string> _output;

	private readonly List<string> _history;

	private int _historyIndex;

	private string _input;

	private Vector2 _scroll;

	private bool _open;

	private bool _focusQueued;

	private bool _helpAutoShown;

	private Rect _windowRect;

	private bool _windowInit;

	private const int WindowId = 748213;

	private Texture2D _icon;

	private GUIStyle _panelStyle;

	private GUIStyle _outputStyle;

	private GUIStyle _inputStyle;

	private GUIStyle _titleStyle;

	private GUIStyle _suggestionStyle;

	private GUIStyle _suggestionPanelStyle;

	private GUIStyle _suggestionEdgeStyle;

	private bool _stylesReady;

	private const int MaxSuggestions = 8;

	private const float SuggestionRowHeight = 22f;

	private readonly List<CommandDescriptor> _suggestions;

	private Rect _inputRect;

	private bool _caretToEndQueued;

	public static StaffMenuController Instance
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

	private static void Bootstrap()
	{
		throw null;
	}

	private void Awake()
	{
		throw null;
	}

	private static void EnsureSystem()
	{
		throw null;
	}

	private void LoadIcon()
	{
		throw null;
	}

	private void RefreshRole()
	{
		throw null;
	}

	private static string SafeHwid()
	{
		throw null;
	}

	private void Update()
	{
		throw null;
	}

	private void Toggle()
	{
		throw null;
	}

	private void Submit(string raw)
	{
		throw null;
	}

	private void PrintHelp()
	{
		throw null;
	}

	private void ListCommandsInBand(bool devBand)
	{
		throw null;
	}

	private void Write(string line)
	{
		throw null;
	}

	private void OnGUI()
	{
		throw null;
	}

	private void EnsureStyles()
	{
		throw null;
	}

	private void DrawIcon()
	{
		throw null;
	}

	private static Rect IconRect()
	{
		throw null;
	}

	private static void LoadIconPos()
	{
		throw null;
	}

	private static void SaveIconPos()
	{
		throw null;
	}

	private void DrawConsole()
	{
		throw null;
	}

	private void DrawConsoleWindow(int id)
	{
		throw null;
	}

	private void ApplyQueuedFocus()
	{
		throw null;
	}

	private void RefreshSuggestions()
	{
		throw null;
	}

	private void DrawSuggestions()
	{
		throw null;
	}

	private void Complete(CommandDescriptor d)
	{
		throw null;
	}

	private void RecallHistory(int dir)
	{
		throw null;
	}

	private static Texture2D SolidTexture(Color color)
	{
		throw null;
	}

	private void OnDestroy()
	{
		throw null;
	}

	public StaffMenuController()
	{
		throw null;
	}
}
