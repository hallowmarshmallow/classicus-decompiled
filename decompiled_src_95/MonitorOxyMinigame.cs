using System;
using UnityEngine;

public class MonitorOxyMinigame : Minigame
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Func<BoxCollider2D, bool> _003C_003E9__16_0;

		public static Func<BoxCollider2D, bool> _003C_003E9__16_1;

		internal bool _003CUpdate_003Eb__16_0(BoxCollider2D s)
		{
			return false;
		}

		internal bool _003CUpdate_003Eb__16_1(BoxCollider2D s)
		{
			return false;
		}
	}

	public SpriteRenderer[] Targets;

	public BoxCollider2D[] Sliders;

	public VerticalSpriteGauge[] Fills;

	public FloatRange YRange;

	public FloatRange[] RandomRanges;

	private Controller controller;

	public AudioClip[] DragSounds;

	private AudioSource ActiveSound;

	public Transform selectorObject;

	private TouchpadBehavior touchpad;

	private float initialY;

	private int selectedIndex;

	private bool prevHadInput;

	private float selectCooldown;

	private bool isTouchInput;

	public override void Begin(PlayerTask task)
	{
	}

	public void Update()
	{
	}

	public override void Close()
	{
	}
}
