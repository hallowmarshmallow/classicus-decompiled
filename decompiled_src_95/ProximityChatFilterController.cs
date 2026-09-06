using TMPro;
using UnityEngine;

public class ProximityChatFilterController : MonoBehaviour
{
	private const int FILTER_ANY = 0;

	private const int FILTER_ON = 1;

	private const int FILTER_OFF = 2;

	private const int FILTER_COUNT = 3;

	public TextMeshPro ValueText;

	private int currentFilter;

	private static readonly string[] TranslatedOn;

	private static readonly string[] TranslatedOff;

	private static readonly string[] TranslatedAny;

	private void Start()
	{
	}

	public void Increment()
	{
	}

	public void Decrement()
	{
	}

	private void ApplyFilter()
	{
	}

	private void UpdateValueText()
	{
	}

	private static string GetTranslatedValue(int filter, int langIndex)
	{
		return null;
	}
}
