using System;
using TMPro;
using UnityEngine;

public class SafeMinigame : Minigame
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Predicate<bool> _003C_003E9__32_0;

		public static Func<int, int> _003C_003E9__32_1;

		public static Func<bool, bool> _003C_003E9__33_0;

		public static Predicate<bool> _003C_003E9__33_1;

		public static Func<bool, bool> _003C_003E9__33_2;

		static _003C_003Ec()
		{
			throw null;
		}

		public _003C_003Ec()
		{
			throw null;
		}

		internal bool _003CUpdateComboInstructions_003Eb__32_0(bool b)
		{
			throw null;
		}

		internal int _003CUpdateComboInstructions_003Eb__32_1(int c)
		{
			throw null;
		}

		internal bool _003CUpdate_003Eb__33_0(bool result)
		{
			throw null;
		}

		internal bool _003CUpdate_003Eb__33_1(bool flag3)
		{
			throw null;
		}

		internal bool _003CUpdate_003Eb__33_2(bool result)
		{
			throw null;
		}
	}

	private const float LowTumblerThreshold = 5f;

	private const float HighTumblerThreshold = 7f;

	private const float ReverseDirThreshold = 0.15f;

	public TextMeshPro ComboText;

	public Collider2D Tumbler;

	public SpriteRenderer TumblerBehind;

	public Collider2D Spinner;

	public SpriteRenderer[] Arrows;

	private int[] combo;

	private bool[] latched;

	private bool[] vibration;

	private Controller controller;

	private float lastTumDir;

	private Vector2 lastMouseVec;

	private float spinTime;

	private float spinDel;

	private float spinVel;

	private float reversalBuffer;

	public AudioClip DialTurnSound;

	public AudioClip DialGoodSound;

	public AudioClip SpinnerStartSound;

	public AudioClip SpinnerFreeSound;

	public AudioClip SpinnerStopSound;

	private AudioSource loopSound;

	private bool prevHadLeftInput;

	private bool prevHadRightInput;

	private Vector2 prevLeftInput;

	private Vector2 prevRightInput;

	private float leftStickStartAngle;

	public float TopSpinRate;

	public void OnEnable()
	{
		throw null;
	}

	public override void Begin(PlayerTask task)
	{
		throw null;
	}

	private void UpdateComboInstructions()
	{
		throw null;
	}

	private void Update()
	{
		throw null;
	}

	private void CheckTumblr(float delta, float tumRotZ, int unlatched, int expected)
	{
		throw null;
	}

	public override void Close()
	{
		throw null;
	}

	private bool AngleNear(float actual, float dir, float expected, float Threshold)
	{
		throw null;
	}

	public SafeMinigame()
	{
		throw null;
	}
}
