using UnityEngine;

public class AspectPosition : MonoBehaviour
{
	public enum EdgeAlignments
	{
		RightBottom = 6,
		LeftBottom = 5,
		RightTop = 10,
		Left = 1,
		Right = 2,
		Top = 8,
		Bottom = 4,
		LeftTop = 9,
		Center = 16
	}

	public Camera parentCam;

	public bool updateAlways;

	public Vector2 anchorPoint;

	private static Rect fullArea;

	public Vector3 DistanceFromEdge;

	public EdgeAlignments Alignment;

	private Vector2 lastScreenSize;

	public void Update()
	{
		throw null;
	}

	private void OnEnable()
	{
		throw null;
	}

	internal void SetNormalizedX(float nx, float widthPadding)
	{
		throw null;
	}

	private void OnDisable()
	{
		throw null;
	}

	public void AdjustPosition()
	{
		throw null;
	}

	private void OnResolutionChanged(float aspectRatio, int width, int height, bool fullscreen)
	{
		throw null;
	}

	public void AdjustPosition(float aspect)
	{
		throw null;
	}

	public static Vector3 ComputeWorldPosition(Camera cam, EdgeAlignments alignment, Vector3 relativePos)
	{
		throw null;
	}

	public static Vector3 ComputePosition(EdgeAlignments alignment, Vector3 relativePos)
	{
		throw null;
	}

	public static Vector3 ComputePosition(EdgeAlignments alignment, Vector3 relativePos, float cHeight, float aspect)
	{
		throw null;
	}

	public static Vector3 ComputePositionSafeArea(EdgeAlignments alignment, Vector3 relativePos, float cHeight, float aspect, Camera cam)
	{
		throw null;
	}

	public Vector3 ComputePositionAnchor(Camera cam, Vector3 relativePos, Vector2 anchor, float aspect)
	{
		throw null;
	}

	public AspectPosition()
	{
		throw null;
	}

	static AspectPosition()
	{
		throw null;
	}
}
