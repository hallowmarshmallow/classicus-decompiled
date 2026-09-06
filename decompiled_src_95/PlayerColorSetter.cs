using UnityEngine;

public class PlayerColorSetter : MonoBehaviour
{
	public int playerColorId;

	public bool EnableRainbow;

	public float RainbowSpeed;

	private SpriteRenderer spriteRenderer;

	private float currentHue;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void ApplyPlayerColor(int colorId)
	{
	}

	private void SetPlayerMaterialColors(int colorId, Renderer rend)
	{
	}

	private void ApplyRainbowColor(Color c)
	{
	}

	public void EnableRainbowMode()
	{
	}

	public void DisableRainbowMode()
	{
	}

	public void ToggleRainbow()
	{
	}
}
