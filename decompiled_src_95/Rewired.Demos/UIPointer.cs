using UnityEngine;
using UnityEngine.EventSystems;

namespace Rewired.Demos;

public sealed class UIPointer : UIBehaviour
{
	private bool _hideHardwarePointer;

	private bool _autoSort;

	private Canvas _canvas;

	public bool autoSort
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	protected override void Awake()
	{
	}

	private void Update()
	{
	}

	protected override void OnTransformParentChanged()
	{
	}

	protected override void OnCanvasGroupChanged()
	{
	}

	public void OnScreenPositionChanged(Vector2 screenPosition)
	{
	}

	private void GetDependencies()
	{
	}
}
