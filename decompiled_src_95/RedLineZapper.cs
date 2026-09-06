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
	}

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void OnDestroy()
	{
	}

	private void BindWallCollider()
	{
	}

	private void CreateOverlay()
	{
	}

	private void TickFlash()
	{
	}

	private void SetOverlayAlpha(float alpha)
	{
	}

	private void StartAmbience()
	{
	}

	private void SoundDynamics(AudioSource source, float dt)
	{
	}
}
