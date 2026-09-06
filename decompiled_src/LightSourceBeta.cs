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
			throw null;
		}

		public VertInfo()
		{
			throw null;
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

	public MeshFilter LightChildMeshFilter
	{
		get
		{
			throw null;
		}
	}

	public Vector3 LightOffset
	{
		get
		{
			throw null;
		}
	}

	public Material LightCutawayMaterial
	{
		get
		{
			throw null;
		}
	}

	public GameObject LightChild
	{
		get
		{
			throw null;
		}
	}

	public Mesh LightChildMesh
	{
		get
		{
			throw null;
		}
	}

	public RenderTextureFormat GpuPreferredRTFormat
	{
		get
		{
			throw null;
		}
	}

	public int GpuShadowmapResolution
	{
		get
		{
			throw null;
		}
	}

	public Material GpuShadowCasterMaterial
	{
		get
		{
			throw null;
		}
	}

	public void Initialize(Vector3 lightOffset)
	{
		throw null;
	}

	private void Awake()
	{
		throw null;
	}

	private void UpdateShadowType()
	{
		throw null;
	}

	public void Update()
	{
		throw null;
	}

	private void TestBothSides(Vector2 myPos)
	{
		throw null;
	}

	private void CreateVert(Vector2 myPos, ref Vector2 del)
	{
		throw null;
	}

	private VertInfo GetEmptyVert()
	{
		throw null;
	}

	private static float length(float x, float y)
	{
		throw null;
	}

	public static float pseudoAngle(float dx, float dy)
	{
		throw null;
	}

	public LightSourceBeta()
	{
		throw null;
	}

	static LightSourceBeta()
	{
		throw null;
	}
}
