using System;
using UnityEngine;

public class DoorBreakerGame : Minigame
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Func<SpriteRenderer, bool> _003C_003E9__5_0;

		internal bool _003CFlipSwitch_003Eb__5_0(SpriteRenderer s)
		{
			return false;
		}
	}

	public OpenableDoor MyDoor;

	public SpriteRenderer[] Buttons;

	public AudioClip FlipSound;

	public void SetDoor(OpenableDoor door)
	{
	}

	public void Start()
	{
	}

	public void FlipSwitch(SpriteRenderer button)
	{
	}
}
