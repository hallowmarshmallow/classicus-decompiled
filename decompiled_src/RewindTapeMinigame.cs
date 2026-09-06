using TMPro;
using UnityEngine;

public class RewindTapeMinigame : Minigame
{
	private const float MaxTime = 83544f;

	private float targetTime;

	private float currentTime;

	public SpriteRenderer LeftWheel;

	public SpriteRenderer LeftTape;

	public SpriteRenderer RightWheel;

	public SpriteRenderer RightTape;

	public TextMeshPro TargetText;

	public TextMeshPro CurrentText;

	public SpriteRenderer RewindButton;

	public Sprite RewindNormal;

	public Sprite RewindDown;

	public SpriteRenderer FastFwdButton;

	public Sprite FastFwdNormal;

	public Sprite FastFwdDown;

	public SpriteRenderer PlayButton;

	public Sprite PlayNormal;

	public Sprite PlayDown;

	public SpriteRenderer PauseButton;

	public Sprite PauseNormal;

	public Sprite PauseDown;

	public SpriteRenderer RewindGlyph;

	public SpriteRenderer FastFwdGlyph;

	public SpriteRenderer PlayGlyph;

	public SpriteRenderer PauseGlyph;

	public float upGlyphYPos;

	public float pressedGlyphYPos;

	public Color upGlyphColor;

	public Color pressedGlyphColor;

	private float direction;

	public AudioClip buttonSound;

	public AudioClip playStartSound;

	public AudioClip playLoopSound;

	public AudioClip playStopSound;

	private AudioSource loopSound;

	public override void Begin(PlayerTask task)
	{
		throw null;
	}

	private void UpdateText(TextMeshPro targetText, float targetTime)
	{
		throw null;
	}

	public void Update()
	{
		throw null;
	}

	private void SetYPos(Transform t, float newYPos)
	{
		throw null;
	}

	private void SetGlyphState(SpriteRenderer glyph, bool pressed)
	{
		throw null;
	}

	public void Rewind()
	{
		throw null;
	}

	public void FastForward()
	{
		throw null;
	}

	public void Pause()
	{
		throw null;
	}

	public void Play()
	{
		throw null;
	}

	public override void Close()
	{
		throw null;
	}

	public RewindTapeMinigame()
	{
		throw null;
	}
}
