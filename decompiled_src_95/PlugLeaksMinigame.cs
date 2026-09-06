using System;
using System.Collections.Generic;
using UnityEngine;

public class PlugLeaksMinigame : Minigame
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Func<Transform, GameObject> _003C_003E9__0_0;

		internal GameObject _003CStart_003Eb__0_0(Transform t)
		{
			return null;
		}
	}

	private const float ANGLE_OFFSET = 24.65f;

	private const float POINT_SPACING = 0.05f;

	private int _totalPoints;

	private static readonly int _redColor;

	public Color[] redColors;

	public GameObject[] backgrounds;

	public SpriteRenderer redRip;

	public Transform tapeTransform;

	public Transform[] sussytransforms;

	public Draggable tapeDraggable;

	public Transform tapeStrip;

	public PolygonCollider2D crackCollider;

	public List<Vector2> colliderPoints;

	public List<BoxCollider2D> tapeStripColliders;

	private bool _blockClose;

	private int _count;

	private Transform _currentTape;

	private float _delta;

	private float _lastTapeAngle;

	public PolishRubyGame _minigameProperties;

	private void Start()
	{
	}

	private void LateUpdate()
	{
	}

	private void UpdateRollAndStripRotation()
	{
	}

	private void CompleteTask()
	{
	}

	private void TryClose()
	{
	}

	private void _003CStart_003Eb__0_1()
	{
	}

	private void _003CStart_003Eb__0_2()
	{
	}

	private void _003CStart_003Eb__0_3()
	{
	}
}
