using UnityEngine;

public class MatchMaker : DestroyableSingleton<MatchMaker>
{
	public TextBox NameText;

	public TextBox GameIdText;

	private MonoBehaviour Connecter;

	public void Start()
	{
	}

	public bool Connecting(MonoBehaviour button)
	{
		return false;
	}

	public void NotConnecting()
	{
	}
}
