using TMPro;
using UnityEngine;

public class DataButtonTranslator : MonoBehaviour, ITranslatedText
{
	public TextMeshPro targetTMP;

	public string English;

	public string Portuguese;

	public string SpanishSpain;

	public string SpanishMexico;

	public string SpanishArgentina;

	public string German;

	public string Dutch;

	public string Swedish;

	public string Italian;

	public string Polish;

	public string Russian;

	public string Turkish;

	public string Vietnamese;

	public string French;

	public string Korean;

	public string Japanese;

	public string Arabic;

	private const string OnlineGameScene = "OnlineGame";

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void OnDestroy()
	{
	}

	public void ResetText()
	{
	}

	public void ApplyTranslation()
	{
	}

	private string Pick(string value)
	{
		return null;
	}

	private static bool IsOnlineGameLoaded()
	{
		return false;
	}
}
