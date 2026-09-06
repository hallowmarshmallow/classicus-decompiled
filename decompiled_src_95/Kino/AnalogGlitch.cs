using UnityEngine;

namespace Kino;

public class AnalogGlitch : MonoBehaviour
{
	private float _scanLineJitter;

	private float _verticalJump;

	private float _horizontalShake;

	private float _colorDrift;

	private Shader _shader;

	private Material _material;

	private float _verticalJumpTime;

	public float scanLineJitter
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public float verticalJump
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public float horizontalShake
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public float colorDrift
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}
}
