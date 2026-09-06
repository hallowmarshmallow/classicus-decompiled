using UnityEngine;

public class VoiceFftVisualizer : MonoBehaviour
{
	public SpriteRenderer BarPrefab;

	public int BarCount;

	public float BarGap;

	public float MinBarHeight;

	public float AttackSpeed;

	public float ReleaseSpeed;

	public float ActivityHoldSeconds;

	public float NoiseFloor;

	public bool TintBars;

	public Color IdleColor;

	public Color ActiveColor;

	private SpriteRenderer[] bars;

	private float[] values;

	private Vector2 areaSize;

	private float activityHoldTimer;

	public void SetArea(Vector2 size)
	{
	}

	public void SetBands(float[] bands, bool active)
	{
	}

	public void SetSilent()
	{
	}

	public void Hide()
	{
	}

	private void EnsureBars()
	{
	}

	private void ClearBars()
	{
	}

	private void LayoutBars()
	{
	}

	private void ApplyBars(bool active)
	{
	}
}
