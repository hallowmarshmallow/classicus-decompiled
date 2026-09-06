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
		throw null;
	}

	public void SetBands(float[] bands, bool active)
	{
		throw null;
	}

	public void SetSilent()
	{
		throw null;
	}

	public void Hide()
	{
		throw null;
	}

	private void EnsureBars()
	{
		throw null;
	}

	private void ClearBars()
	{
		throw null;
	}

	private void LayoutBars()
	{
		throw null;
	}

	private void ApplyBars(bool active)
	{
		throw null;
	}

	public VoiceFftVisualizer()
	{
		throw null;
	}
}
