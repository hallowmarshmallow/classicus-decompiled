using System.Collections.Generic;
using UnityEngine;

public class LightSourceBeta : MonoBehaviour
{
	private class VertInfo
	{
		public float Angle;

		public Vector3 Position;

		internal void Complete(float x, float y)
		{
		}
	}

	public static Dictionary<GameObject, NoShadowBehaviour> NoShadows;

	public static Dictionary<GameObject, OneWayShadows> OneWayShadows;

	private GameObject child;

	private Vector2[] requiredDels;

	private Mesh myMesh;

	public int MinRays;

	public float LightRadius;

	public Material Material;

	private List<VertInfo> verts;

	private int vertCount;

	private RaycastHit2D[] buffer;

	private Collider2D[] hits;

	private ContactFilter2D filter;

	private Vector3[] vec;

	private Vector2[] uvs;

	private int[] triangles;

	public float tol;

	private Vector2 del;

	private LightSourceRenderer renderer;

	private Vector2 tan;

	private Vector2 side;

	public List<RaycastHit2D> lightHits;

	public MeshFilter lightChildMeshFilter;

	private RenderTextureFormat gpuPreferredRTFormat;

	private int gpuShadowmapResolution;

	private LightSourceRendererType rendererType;

	private Vector3 lightOffset;

	public Material gpuShadowCasterMaterial;

	public MeshFilter LightChildMeshFilter => null;

	public Vector3 LightOffset => default(Vector3);

	public Material LightCutawayMaterial => null;

	public GameObject LightChild => null;

	public Mesh LightChildMesh => null;

	public RenderTextureFormat GpuPreferredRTFormat => default(RenderTextureFormat);

	public int GpuShadowmapResolution => 0;

	public Material GpuShadowCasterMaterial => null;

	public void Initialize(Vector3 lightOffset)
	{
	}

	private void Awake()
	{
	}

	private void UpdateShadowType()
	{
	}

	public void Update()
	{
	}

	private void TestBothSides(Vector2 myPos)
	{
	}

	private void CreateVert(Vector2 myPos, ref Vector2 del)
	{
	}

	private VertInfo GetEmptyVert()
	{
		return null;
	}

	private static float length(float x, float y)
	{
		return 0f;
	}

	public static float pseudoAngle(float dx, float dy)
	{
		return 0f;
	}
}
