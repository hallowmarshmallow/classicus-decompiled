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
		throw null;
	}

	public void ReEnable()
	{
		throw null;
	}

	protected override void OnDisable()
	{
		throw null;
	}

	public override void ReceiveClickDrag(Vector2 dragDelta)
	{
		throw null;
	}

	public void UpdateValue()
	{
		throw null;
	}

	public void SetValue(float newValue)
	{
		throw null;
	}

	public void ControllerIncrease()
	{
		throw null;
	}

	public void ControllerDecrease()
	{
		throw null;
	}

	private void OnValidate()
	{
		throw null;
	}

	public void SetEnabledColors()
	{
		throw null;
	}

	public void SetDisabledColors()
	{
		throw null;
	}

	public SlideBar()
	{
		throw null;
	}
}
