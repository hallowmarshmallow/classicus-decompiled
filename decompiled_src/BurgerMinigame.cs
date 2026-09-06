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

		static _003C_003Ec()
		{
			throw null;
		}

		public _003C_003Ec()
		{
			throw null;
		}

		internal float _003CUpdate_003Eb__24_0(BurgerTopping s)
		{
			throw null;
		}

		internal BurgerToppingTypes _003CUpdate_003Eb__24_1(BurgerTopping tt)
		{
			throw null;
		}
	}

	private sealed class _003C_003Ec__DisplayClass22_0
	{
		public BurgerToppingTypes top;

		public _003C_003Ec__DisplayClass22_0()
		{
			throw null;
		}

		internal bool _003CBegin_003Eb__0(BurgerToppingTypes t)
		{
			throw null;
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
		throw null;
	}

	private void SelectTopping(BurgerTopping topping)
	{
		throw null;
	}

	public void Update()
	{
		throw null;
	}

	public void TogglePaper()
	{
		throw null;
	}

	public BurgerMinigame()
	{
		throw null;
	}
}
