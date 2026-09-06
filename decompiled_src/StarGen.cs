using System;
using UnityEngine;

public class StarGen : MonoBehaviour
{
	[Serializable]
	private struct Stars
	{
		public float Size;

		public float Rate;

		public float PositionX;

		public float PositionY;
	}

	private const float MaxStarRadius = 0.05f;

	public int NumStars;

	public float Length;

	public float Width;

	public Vector2 Direction;

	private Vector2 NormDir;

	private Vector2 Tangent;

	private float tanLen;

	public FloatRange Rates;

	private Stars[] stars;

	private Vector3[] verts;

	private Mesh mesh;

	public void Start()
	{
		throw null;
	}

	private void Update()
	{
		throw null;
	}

	public void SetDirection(Vector2 dir)
	{
		throw null;
	}

	public void RegenPositions()
	{
		throw null;
	}

	private float OrthoDistance(float pointx, float pointy)
	{
		throw null;
	}

	public StarGen()
	{
		throw null;
	}
}
