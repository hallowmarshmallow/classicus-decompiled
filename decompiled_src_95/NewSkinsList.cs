using UnityEngine;

public class NewSkinsList : MonoBehaviour
{
	public Sprite[] NewSkins;

	private const float OversizedWorldHeight = 1.4f;

	private const float OversizedScale = 0.5f;

	private const float NormalScale = 1f;

	private SpriteRenderer _renderer;

	private void Awake()
	{
	}

	private void LateUpdate()
	{
	}

	private float ScaleFor(Sprite sprite)
	{
		return 0f;
	}

	private static bool ArrayContainsSprite(Sprite[] array, Sprite sprite)
	{
		return false;
	}
}
