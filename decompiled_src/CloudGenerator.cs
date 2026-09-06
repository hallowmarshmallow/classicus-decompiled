using UnityEngine;

public class CloudGenerator : MonoBehaviour
{
	private struct Cloud
	{
		public int CloudIdx;

		public float Rate;

		public float Size;

		public float FlipX;

		public float PositionX;

		public float PositionY;

		public float PositionZ;
	}

	public Sprite[] CloudImages;

	private Vector2[] ExtentCache;

	public int NumClouds;

	public float Length;

	public float Width;

	public Vector2 Direction;

	private Vector2 NormDir;

	private Vector2 Tangent;

	private float tanLen;

	public FloatRange Rates;

	public FloatRange Sizes;

	public bool Depth;

	public float MaxDepth;

	public float ParallaxOffset;

	public float ParallaxStrength;

	private Cloud[] clouds;

	private Vector3[] verts;

	private Mesh mesh;

	public void Start()
	{
		throw null;
	}

	private void FixedUpdate()
	{
		throw null;
	}

	public void SetDirection(Vector2 dir)
	{
		throw null;
	}

	private float OrthoDistance(float pointx, float pointy)
	{
		throw null;
	}

	public CloudGenerator()
	{
		throw null;
	}
}
