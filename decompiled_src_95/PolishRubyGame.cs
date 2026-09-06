using System;
using UnityEngine;

public class PolishRubyGame : Minigame
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Action<PassiveButton> _003C_003E9__0_0;

		public static Func<PassiveButton, bool> _003C_003E9__0_1;

		internal void _003CStart_003Eb__0_0(PassiveButton b)
		{
		}

		internal bool _003CStart_003Eb__0_1(PassiveButton t)
		{
			return false;
		}
	}

	public PassiveButton[] Buttons;

	public SpriteRenderer[] Sparkles;

	public int[] swipes;

	public Vector2[] directions;

	public int swipesToClean;

	public AudioClip[] rubSounds;

	public AudioClip sparkleSound;

	public Transform cursorObject;

	public Transform handWipeObject;

	public SpriteRenderer[] handSprites;

	public BoxCollider2D rubyCursorBounds;

	private Controller cont;

	private bool oldCursorOverlapsSmudge;

	public void Start()
	{
	}

	private void UpdateSpriteColor(bool cursorOverlapsSmudge)
	{
	}

	public void RemoveSmudge()
	{
	}

	public void PlaySparkleSound()
	{
	}

	public void Update()
	{
	}
}
