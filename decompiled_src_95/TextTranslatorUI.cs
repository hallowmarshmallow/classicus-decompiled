using UnityEngine;

public class TextTranslatorUI : MonoBehaviour, ITranslatedText
{
	public StringNames TargetText;

	public string defaultStr;

	public bool ResetOnlyWhenNoDefault;

	public bool ToUpper;

	public void Start()
	{
	}

	public void OnDestroy()
	{
	}

	public void ResetText()
	{
	}
}
