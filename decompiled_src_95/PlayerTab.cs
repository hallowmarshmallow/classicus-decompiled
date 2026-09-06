using System.Collections.Generic;
using UnityEngine;

public class PlayerTab : MonoBehaviour
{
	private sealed class _003C_003Ec__DisplayClass9_0
	{
		public int i;

		public PlayerTab _003C_003E4__this;

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

	public FloatRange YRange;

	private List<ColorChip> ColorChips;

	private const int Columns = 3;

	public void OnEnable()
	{
	}

	public void OnDisable()
	{
	}

	public void Update()
	{
	}

	private void SelectColor(int colorId)
	{
	}
}
