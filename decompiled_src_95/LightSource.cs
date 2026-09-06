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
		}
	}

	private class AngleComparer : IComparer<VertInfo>
	{
		public static readonly AngleComparer Instance;

		public int Compare(VertInfo x, VertInfo y)
		{
			return 0;
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
	}

	private void Start()
	{
	}

	private float GetValidViewDistance()
	{
		return 0f;
	}

	public void Update()
	{
	}

	public void FixedUpdate()
	{
	}

	public void Refresh()
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
