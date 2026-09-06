using TMPro;
using UnityEngine;
using UnityEngine.Events;

public class SlideBar : PassiveUiElement
{
	public TextMeshPro Title;

	public SpriteRenderer Bar;

	public SpriteRenderer Dot;

	public FloatRange Range;

	public bool Vertical;

	public float Value;

	public UnityEvent OnValueChange;

	private float sliderSegmentIncrement;

	protected override void OnEnable()
	{
	}

	public void ReEnable()
	{
	}

	protected override void OnDisable()
	{
	}

	public override void ReceiveClickDrag(Vector2 dragDelta)
	{
	}

	public void UpdateValue()
	{
	}

	public void SetValue(float newValue)
	{
	}

	public void ControllerIncrease()
	{
	}

	public void ControllerDecrease()
	{
	}

	private void OnValidate()
	{
	}

	public void SetEnabledColors()
	{
	}

	public void SetDisabledColors()
	{
	}
}
