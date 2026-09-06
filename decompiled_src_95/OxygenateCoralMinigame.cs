using System;
using System.Collections.Generic;
using UnityEngine;

public class OxygenateCoralMinigame : Minigame
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Func<Transform, (Sprite, PolygonCollider2D)> _003C_003E9__15_0;

		internal (Sprite, PolygonCollider2D) _003CStart_003Eb__15_0(Transform t)
		{
			return default((Sprite, PolygonCollider2D));
		}
	}

	private const float PROBABILITY = 0.25f;

	private const float BUBBLE_FORCE_MODIFIER = 1f;

	private static readonly int _hsvaAdjust;

	public Transform[] colorSpriteSets;

	public Transform mazeCells;

	public Transform endCoral;

	private Rigidbody2D _bubbleBody;

	private Vector3 _bubblePos;

	private Transform _bubbleTransform;

	private int[,] _colorMap;

	private Vector2 _inputDelta;

	private Camera _mainCam;

	public CoralCell[,] cells;

	public Dictionary<int, int> colorTranslations;

	public (Sprite, PolygonCollider2D)[] slugs;

	private void Start()
	{
	}

	public void ResetBubble()
	{
	}

	public CoralCell[,] GetDefaultCells()
	{
		return null;
	}

	public void SetupColors()
	{
	}

	public void GenerateMazeDfsNonRecursive()
	{
	}

	private void Update()
	{
	}

	private void FixedUpdate()
	{
	}

	private static T CopyFrom<T>(Component comp, T other) where T : Component
	{
		return null;
	}

	private static T CopyComponent<T>(GameObject go, T copyFrom) where T : Component
	{
		return null;
	}

	private List<(int, int)> GetNeighbours((int, int) position)
	{
		return null;
	}

	private static bool ValidIndex<T>(T[,] arr, (int, int) pos)
	{
		return false;
	}

	private static (int, int) GeneratePointAroundPoint((int, int) initialPoint, (int, int) range)
	{
		return default((int, int));
	}

	private List<(int, int)> PathfindBfs(int startX, int startY, int endX, int endY)
	{
		return null;
	}

	private static bool CheckBounds<T>(T[,] arr, (int, int) pos)
	{
		return false;
	}
}
