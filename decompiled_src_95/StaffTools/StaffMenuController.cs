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

		internal string _003CListCommandsInBand_003Eb__53_1(CommandDescriptor d)
		{
			return null;
		}

		internal string _003CRefreshSuggestions_003Eb__69_1(CommandDescriptor d)
		{
			return null;
		}
	}

	private sealed class _003C_003Ec__DisplayClass53_0
	{
		public bool devBand;

		public int modLevel;

		public StaffMenuController _003C_003E4__this;

		internal bool _003CListCommandsInBand_003Eb__0(CommandDescriptor d)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass69_0
	{
		public StaffMenuController _003C_003E4__this;

		public string prefix;

		internal bool _003CRefreshSuggestions_003Eb__0(CommandDescriptor d)
		{
			return false;
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
			return _003CInstance_003Ek__BackingField;
		}
		private set
		{
			_003CInstance_003Ek__BackingField = value;
		}
	}

	private static void Bootstrap()
	{
	}

	private void Awake()
	{
	}

	private static void EnsureSystem()
	{
	}

	private void LoadIcon()
	{
	}

	private void RefreshRole()
	{
	}

	private static string SafeHwid()
	{
		return null;
	}

	private void Update()
	{
	}

	private void Toggle()
	{
	}

	private void Submit(string raw)
	{
	}

	private void PrintHelp()
	{
	}

	private void ListCommandsInBand(bool devBand)
	{
	}

	private void Write(string line)
	{
	}

	private void OnGUI()
	{
	}

	private void EnsureStyles()
	{
	}

	private void DrawIcon()
	{
	}

	private static Rect IconRect()
	{
		return default(Rect);
	}

	private static void LoadIconPos()
	{
	}

	private static void SaveIconPos()
	{
	}

	private void DrawConsole()
	{
	}

	private void DrawConsoleWindow(int id)
	{
	}

	private void ApplyQueuedFocus()
	{
	}

	private void RefreshSuggestions()
	{
	}

	private void DrawSuggestions()
	{
	}

	private void Complete(CommandDescriptor d)
	{
	}

	private void RecallHistory(int dir)
	{
	}

	private static Texture2D SolidTexture(Color color)
	{
		return null;
	}

	private void OnDestroy()
	{
	}
}
