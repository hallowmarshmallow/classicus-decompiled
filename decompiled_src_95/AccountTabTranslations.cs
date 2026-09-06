using UnityEngine;

public class AccountTabTranslations : MonoBehaviour, ITranslatedText
{
	private TranslationController _registeredController;

	private bool _translationsApplied;

	private float _nextTranslationProbeAt;

	private void Start()
	{
	}

	private bool EnsureRegistered()
	{
		return false;
	}

	private void Update()
	{
	}

	private void OnDestroy()
	{
	}

	public void ResetText()
	{
	}

	private void Apply(string goName, string childName, StringNames id, string fallback)
	{
	}
}
