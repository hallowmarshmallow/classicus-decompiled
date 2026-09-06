using UnityEngine;
using UnityEngine.Audio;

public class HyperlinkTrigger : MonoBehaviour
{
	private string url;

	private ClickableHyperlink hyperlinkHandler;

	private AudioSource audioSource;

	public void SetHyperlink(string hyperlink, ClickableHyperlink handler, AudioClip hoverClip, AudioMixerGroup mixerGroup)
	{
	}

	public void SetHighlightState(bool state)
	{
	}

	public void OpenURL()
	{
	}
}
