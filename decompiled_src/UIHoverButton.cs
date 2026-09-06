using UnityEngine;
using UnityEngine.Audio;

public class UIHoverButton : MonoBehaviour
{
	public SpriteRenderer targetRenderer;

	public Color outColor;

	public Color hoverColor;

	public float colorLerpSpeed;

	public AudioClip hoverSound;

	public AudioMixerGroup sfxMixerGroup;

	private Collider2D _collider;

	private AudioSource _audioSource;

	private Color _currentColor;

	private bool _isHovering;

	private bool _wasHovering;

	private CircleCollider2D _mouseCollider;

	private GameObject _mouseProbe;

	private void Awake()
	{
		throw null;
	}

	private void OnDestroy()
	{
		throw null;
	}

	private void Update()
	{
		throw null;
	}

	private bool IsPointerOver()
	{
		throw null;
	}

	private void PlayHoverSound()
	{
		throw null;
	}

	private void OnValidate()
	{
		throw null;
	}

	public UIHoverButton()
	{
		throw null;
	}
}
