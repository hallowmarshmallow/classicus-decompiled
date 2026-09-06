using UnityEngine;
using UnityEngine.UI;

namespace Rewired.Demos.GamepadTemplateUI;

public class ControllerUIElement : MonoBehaviour
{
	private Color _highlightColor;

	private ControllerUIEffect _positiveUIEffect;

	private ControllerUIEffect _negativeUIEffect;

	private Text _label;

	private Text _positiveLabel;

	private Text _negativeLabel;

	private ControllerUIElement[] _childElements;

	private Image _image;

	private Color _color;

	private Color _origColor;

	private bool _isActive;

	private float _highlightAmount;

	private bool hasEffects => false;

	private void Awake()
	{
	}

	public void Activate(float amount)
	{
	}

	public void Deactivate()
	{
	}

	public void SetLabel(string text, AxisRange labelType)
	{
	}

	public void ClearLabels()
	{
	}

	private void RedrawImage()
	{
	}
}
