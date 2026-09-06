using UnityEngine;
using UnityEngine.UI;

public class RoundedCorners : MonoBehaviour
{
	public Shader RoundedShader;

	public float Radius;

	public float Softness;

	public bool MatchAspect;

	private static readonly int RadiusId;

	private static readonly int SoftnessId;

	private static readonly int AspectId;

	private SpriteRenderer _spriteRenderer;

	private Graphic _graphic;

	private Material _material;

	private bool _warned;

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void OnDestroy()
	{
	}

	private void Update()
	{
	}

	public void Apply()
	{
	}

	private void Push()
	{
	}

	private float MeasureAspect()
	{
		return 0f;
	}

	private void DestroyMaterial()
	{
	}
}
