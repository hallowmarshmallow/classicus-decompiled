using System.Collections.Generic;
using Rewired.ControllerExtensions;
using UnityEngine;

namespace Rewired.Demos;

public class DualShock4SpecialFeaturesExample : MonoBehaviour
{
	private class Touch
	{
		public GameObject go;

		public int touchId;

		public Touch()
		{
			throw null;
		}
	}

	private sealed class _003C_003Ec__DisplayClass20_0
	{
		public int touchId;

		public _003C_003Ec__DisplayClass20_0()
		{
			throw null;
		}

		internal bool _003CHandleTouchpad_003Eb__0(Touch x)
		{
			throw null;
		}
	}

	private const int maxTouches = 2;

	public int playerId;

	public Transform touchpadTransform;

	public GameObject lightObject;

	public Transform accelerometerTransform;

	private List<Touch> touches;

	private Queue<Touch> unusedTouches;

	private bool isFlashing;

	private GUIStyle textStyle;

	private Player player
	{
		get
		{
			throw null;
		}
	}

	private void Awake()
	{
		throw null;
	}

	private void Update()
	{
		throw null;
	}

	private void OnGUI()
	{
		throw null;
	}

	private void ResetOrientation()
	{
		throw null;
	}

	private void SetRandomLightColor()
	{
		throw null;
	}

	private void StartLightFlash()
	{
		throw null;
	}

	private void StopLightFlash()
	{
		throw null;
	}

	private IDualShock4Extension GetFirstDS4(Player player)
	{
		throw null;
	}

	private void InitializeTouchObjects()
	{
		throw null;
	}

	private void HandleTouchpad(IDualShock4Extension ds4)
	{
		throw null;
	}

	public DualShock4SpecialFeaturesExample()
	{
		throw null;
	}
}
