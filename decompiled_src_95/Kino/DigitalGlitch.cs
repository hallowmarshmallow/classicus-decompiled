using UnityEngine;

namespace Kino;

public class DigitalGlitch : MonoBehaviour
{
	private float _intensity;

	private Shader _shader;

	private Material _material;

	private Texture2D _noiseTexture;

	private RenderTexture _trashFrame1;

	private RenderTexture _trashFrame2;

	public float intensity
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	private static Color RandomColor()
	{
		return default(Color);
	}

	private void SetUpResources()
	{
	}

	private void UpdateNoiseTexture()
	{
	}

	private void Update()
	{
	}

	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}
}
