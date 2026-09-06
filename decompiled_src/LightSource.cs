using System.Collections.Generic;
using UnityEngine;

public class LightSource : MonoBehaviour, IQualityElement
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

	private class AngleComparer : IComparer<VertInfo>
	{
		public static readonly AngleComparer Instance;

		public int Compare(VertInfo x, VertInfo y)
		{
			throw null;
		}

		public AngleComparer()
		{
			throw null;
		}

		static AngleComparer()
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

	public float MinRefreshInterval;

	public float RefreshMoveThreshold;

	private Vector2 del;

	private Vector2 tan;

	private Vector2 side;

	private List<RaycastHit2D> lightHits;

	public Camera camera;

	private Vector3 lastRefreshPosition;

	private float lastRefreshRadius;

	private float lastRefreshViewDistance;

	private float nextRefreshTime;

	private float currentViewDistance;

	private float currentRayDistance;

	private float currentRayDistanceSqr;

	public RenderTexture MinRenderTexture;

	public RenderTexture NormalRenderTexture;

	public RenderTexture HighRenderTexture;

	public RenderTexture UltraRenderTexture;

	private static readonly int LightRadiusId;

	public void ApplySettings(MUQualitySettings.QualityPreset preset)
	{
		throw null;
	}

	private void Start()
	{
		throw null;
	}

	private float GetValidViewDistance()
	{
		throw null;
	}

	public void Update()
	{
		throw null;
	}

	public void FixedUpdate()
	{
		throw null;
	}

	public void Refresh()
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

	public LightSource()
	{
		throw null;
	}

	static LightSource()
	{
		throw null;
	}
}
