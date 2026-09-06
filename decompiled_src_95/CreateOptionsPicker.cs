using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CreateOptionsPicker : MonoBehaviour
{
	private sealed class _003C_003Ec__DisplayClass46_0
	{
		public int capturedIndex;

		public CreateOptionsPicker _003C_003E4__this;

		internal void _003CCreateMapButtons_003Eb__0()
		{
		}
	}

	private sealed class _003CCoWarmLanguageGlyphs_003Ed__38 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CreateOptionsPicker _003C_003E4__this;

		private int _003Ci_003E5__2;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CCoWarmLanguageGlyphs_003Ed__38(int _003C_003E1__state)
		{
		}

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
		}
	}

	private const string LANGUAGE_PREF_KEY = "LanguageFilter";

	private const string HOST_LANGUAGE_PREF_KEY = "LanguageHost";

	private const int LANGUAGE_UNSET = -1;

	private const int LANGUAGE_ENGLISH = 1;

	private const string LANGUAGE_MIGRATION_PREF_KEY = "LanguagePrefFix";

	private const int LANGUAGE_MIGRATION_VERSION = 2;

	private static readonly Dictionary<int, string> LanguageKeywordNames;

	private static readonly Dictionary<int, string> LanguageDisplayNames;

	private static readonly string[] TranslatedAny;

	private static readonly string[] TranslatedOther;

	private static readonly Color UnselectedColor;

	private static readonly Color SelectedColor;

	private static readonly Color MapSelectedColor;

	public SpriteRenderer[] MaxPlayerButtons;

	public SpriteRenderer[] ImpostorButtons;

	public SpriteRenderer[] LanguageButtons;

	private List<SpriteRenderer> DynamicMapButtons;

	public SpriteRenderer[] MapButtons;

	public SettingsMode mode;

	public CrewVisualizer CrewArea;

	public SpriteRenderer MapButtonPrefab;

	public GameObject MapButtonsHolder;

	public SpriteRenderer CurMap;

	public GameObject MapCountBadge;

	public TextMeshPro MapCountText;

	private int selectedLanguageKeyword;

	private SpriteRenderer anyLanguageButton;

	private int currentNumImpostors;

	public TextMeshPro LangDisplay;

	public GameObject ImpostorsRow;

	public GameObject MapPickerRow;

	public float RunnerMapPickerDrop;

	private const string IMPOSTOR_FILTER_BACKUP_PREF_KEY = "ImpostorFilterPreRunner";

	private bool _runnerLayoutApplied;

	private bool _mapPickerHomeCaptured;

	private Vector3 _mapPickerHome;

	private bool _gameModeObjectsResolved;

	private static bool langGlyphsWarmed;

	private IEnumerator CoWarmLanguageGlyphs()
	{
		return null;
	}

	private static void WarmButtonLabels(SpriteRenderer button)
	{
	}

	public void Start()
	{
	}

	private GameOptionsData GetTargetOptions()
	{
		return null;
	}

	private void SetTargetOptions(GameOptionsData data)
	{
	}

	private static int GetMinPlayersForImpostors(int numImpostors)
	{
		return 0;
	}

	public void SetMaxPlayersButtons(int maxPlayers)
	{
	}

	public void SetMapButtons(bool active)
	{
	}

	private void CreateMapButtons(bool open)
	{
	}

	private void UpdateMaxPlayersButtons(GameOptionsData opts)
	{
	}

	public void SetImpostorButtons(int numImpostors)
	{
	}

	private void UpdateImpostorsButtons(int numImpostors)
	{
	}

	public void SetMap(int mapid)
	{
	}

	private void UpdateMapButtons(int mapid)
	{
	}

	private void UpdateMapCountBadge(int selectedCount)
	{
	}

	private void ApplyMapButtonSelection(SpriteRenderer icon, bool isSelected)
	{
	}

	public void ApplyGameModeLayout()
	{
	}

	private void ResolveGameModeObjects()
	{
	}

	private static void MigrateLanguagePrefs()
	{
	}

	public void SetLanguageFilter()
	{
	}

	public void SetLanguageFilter(int keyword)
	{
	}

	private void LocateAnyLanguageButton()
	{
	}

	private static string GetAnyText()
	{
		return null;
	}

	private static string GetOtherText()
	{
		return null;
	}

	private void UpdateLanguageButtons(int keyword)
	{
	}
}
