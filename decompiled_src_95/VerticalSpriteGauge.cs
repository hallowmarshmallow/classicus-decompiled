using UnityEngine;

public class VerticalSpriteGauge : MonoBehaviour
{
	public float Value;

	public float MaxValue;

	public FloatRange YRange;

	public SpriteRenderer Mask;

	private float lastValue;

	private float _003CTopY_003Ek__BackingField;

	public float TopY
	{
		get
		{
			return _003CTopY_003Ek__BackingField;
		}
		private set
		{
			_003CTopY_003Ek__BackingField = value;
		}
	}

	public void Update()
	{
	}
}
