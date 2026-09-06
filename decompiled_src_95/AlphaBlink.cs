using UnityEngine;

public class AlphaBlink : MonoBehaviour
{
	public float Period;

	public float Ratio;

	private SpriteRenderer rend;

	private MeshRenderer mesh;

	private Material cachedMeshMaterial;

	public FloatRange AlphaRange;

	public Color baseColor;

	public void SetColor(Color c)
	{
	}

	private void Start()
	{
	}

	public void Update()
	{
	}
}
