using UnityEngine;

public class RedLineZapper : MonoBehaviour
{
	public enum MixerTarget
	{
		SFX,
		Music
	}

	private enum FlashState
	{
		Idle,
		Hold,
		Out
	}

	public float FlashHoldDuration;

	public float FlashOutDuration;

	public float FlashInterval;

	public AudioClip AmbienceClip;

	public MixerTarget SoundMixer;

	public float VolumeScale;

	public float FalloffStartDistance;

	public float FalloffEndDistance;

	private SpriteRenderer _baseRenderer;

	private SpriteRenderer _flashOverlay;

	private Material _overlayMaterial;

	private string _soundKey;

	private Collider2D _wallCollider;

	private FlashState _state;

	private float _stateTimer;

	private void Awake()
	{
		throw null;
	}

	private void Start()
	{
		throw null;
	}

	private void Update()
	{
		throw null;
	}

	private void OnDestroy()
	{
		throw null;
	}

	private void BindWallCollider()
	{
		throw null;
	}

	private void CreateOverlay()
	{
		throw null;
	}

	private void TickFlash()
	{
		throw null;
	}

	private void SetOverlayAlpha(float alpha)
	{
		throw null;
	}

	private void StartAmbience()
	{
		throw null;
	}

	private void SoundDynamics(AudioSource source, float dt)
	{
		throw null;
	}

	public RedLineZapper()
	{
		throw null;
	}
}
