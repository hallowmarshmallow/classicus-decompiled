using UnityEngine;

public class TextTranslatorTMP : MonoBehaviour, ITranslatedText
{
	public StringNames TargetText;

	public string defaultStr;

	public bool ResetOnlyWhenNoDefault;

	public bool ToUpper;

	private bool registered;

	public void Start()
	{
	}

	public void OnEnable()
	{
	}

	public void OnDisable()
	{
	}

	public void OnDestroy()
	{
	}

	private void Register()
	{
	}

	private void Unregister()
	{
	}

	public void ResetText()
	{
	}
}
