using System.Collections.Generic;
using System.Text;
using TMPro;
using UnityEngine;

public class StatsPopup : MonoBehaviour
{
	public TMP_Text StatsText;

	public bool AlignNumbers;

	public int LabelWidth;

	public int LanguageIndex;

	private uint lastLanguage;

	private Dictionary<string, string[]> labelsByLanguage;

	private const int ArabicLanguageIndex = 16;

	private bool IsArabic
	{
		get
		{
			throw null;
		}
	}

	private void Awake()
	{
		throw null;
	}

	private void OnEnable()
	{
		throw null;
	}

	private void Update()
	{
		throw null;
	}

	private void UpdateStatsText(int langIndex)
	{
		throw null;
	}

	private void Append(StringBuilder sb, string label, object value)
	{
		throw null;
	}

	private void InitializeLabels()
	{
		throw null;
	}

	public StatsPopup()
	{
		throw null;
	}
}
