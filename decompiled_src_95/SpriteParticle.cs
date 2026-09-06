using System.Collections.Generic;
using UnityEngine;

public class SpriteParticle : MonoBehaviour
{
	private const float FrameRate = 24f;

	public Sprite[] Sprites;

	public ParticleInfo[] Particles;

	public ushort[][] TriangleCache;

	private Vector3[] verts;

	private Vector2[] uvs;

	private List<int> tris;

	private Mesh mesh;

	private int MaxVerts;

	private Dictionary<int, Vector2[]> VertCache;

	private Dictionary<int, Vector2[]> UvCache;

	private int[] _lastFrameIndex;

	private bool _trisDirty;

	public void OnDrawGizmos()
	{
	}

	public void Start()
	{
	}

	public void FixedUpdate()
	{
	}
}
