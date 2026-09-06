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

	private bool IsArabic => false;

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void Update()
	{
	}

	private void UpdateStatsText(int langIndex)
	{
	}

	private void Append(StringBuilder sb, string label, object value)
	{
	}

	private void InitializeLabels()
	{
	}
}
