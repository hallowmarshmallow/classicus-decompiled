using System.Collections.Generic;
using UnityEngine;

public class SkinsTab : MonoBehaviour
{
	private sealed class _003C_003Ec__DisplayClass11_0
	{
		public SkinData skin;

		public SkinsTab _003C_003E4__this;

		internal void _003COnEnable_003Eb__0()
		{
		}
	}

	public ColorChip ColorTabPrefab;

	public SpriteRenderer DemoImage;

	public HatParent HatImage;

	public SpriteRenderer SkinImage;

	public SpriteRenderer PetImage;

	public FloatRange XRange;

	public float YStart;

	public float YOffset;

	public int NumPerRow;

	public Scroller scroller;

	private List<ColorChip> ColorChips;

	public void OnEnable()
	{
	}

	public void OnDisable()
	{
	}

	public void Update()
	{
	}

	private void SelectHat(SkinData skin)
	{
	}
}
