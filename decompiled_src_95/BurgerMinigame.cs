using System;
using System.Collections.Generic;
using UnityEngine;

public class BurgerMinigame : Minigame
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Func<BurgerTopping, float> _003C_003E9__24_0;

		public static Func<BurgerTopping, BurgerToppingTypes> _003C_003E9__24_1;

		internal float _003CUpdate_003Eb__24_0(BurgerTopping s)
		{
			return 0f;
		}

		internal BurgerToppingTypes _003CUpdate_003Eb__24_1(BurgerTopping tt)
		{
			return default(BurgerToppingTypes);
		}
	}

	private sealed class _003C_003Ec__DisplayClass22_0
	{
		public BurgerToppingTypes top;

		internal bool _003CBegin_003Eb__0(BurgerToppingTypes t)
		{
			return false;
		}
	}

	public BurgerTopping Plate;

	public BurgerTopping[] Toppings;

	public Sprite[] PaperToppings;

	public SpriteRenderer[] PaperSlots;

	private BurgerToppingTypes[] ExpectedToppings;

	private Stack<BurgerTopping> burger;

	private Controller controller;

	public Transform Paper;

	private const float PaperOpenedY = 0f;

	private const float PaperClosedY = 4.8f;

	private bool PaperClosed;

	public SpriteRenderer Shadow;

	public Transform stickCursor;

	public SpriteRenderer handSprite;

	public BoxCollider2D stickSelectionCenterPoint;

	private Vector3 selectionCenterStart;

	private BurgerTopping stickSelectedTopping;

	private bool grabbedTopping;

	private Vector3 internalCursorPos;

	public float cursorLerpSpeed;

	public float cursorHoverLerpSpeed;

	private float stackHeight;

	public override void Begin(PlayerTask task)
	{
	}

	private void SelectTopping(BurgerTopping topping)
	{
	}

	public void Update()
	{
	}

	public void TogglePaper()
	{
	}
}
