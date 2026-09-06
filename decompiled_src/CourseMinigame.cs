using System.Runtime.InteropServices;
using UnityEngine;

public class CourseMinigame : Minigame
{
	[StructLayout((LayoutKind)2)]
	private struct UIntFloat
	{
		[FieldOffset(0)]
		public float FloatValue;

		[FieldOffset(0)]
		public int IntValue;

		public float GetFloat(byte[] bytes)
		{
			throw null;
		}

		public void GetBytes(float value, byte[] bytes)
		{
			throw null;
		}
	}

	public CourseStarBehaviour StarPrefab;

	public CourseStarBehaviour[] Stars;

	public SpriteRenderer DotPrefab;

	public Sprite DotLight;

	public SpriteRenderer[] Dots;

	public Collider2D Ship;

	public CourseStarBehaviour Destination;

	public Vector3[] PathPoints;

	public int NumPoints;

	public FloatRange XRange;

	public FloatRange YRange;

	public LineRenderer Path;

	public Controller myController;

	public float lineTimer;

	private UIntFloat Converter;

	public AudioClip SetCourseSound;

	public AudioClip SetCourseLastSound;

	public override void Begin(PlayerTask task)
	{
		throw null;
	}

	public void FixedUpdate()
	{
		throw null;
	}

	private void SetLineDivision(float curVec)
	{
		throw null;
	}

	public CourseMinigame()
	{
		throw null;
	}
}
