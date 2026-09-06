using UnityEngine;

public class PlayerShadow : MonoBehaviour
{
	public PlayerControl target;

	public SpriteRenderer shadowRend;

	private SpriteRenderer playerRend;

	public Sprite[] sprites;

	public Color shadowColor;

	private float checkTimer;

	private float randomTimer;

	private bool isInsideCache;

	private Sprite lastSprite;

	private bool lastFlipX;

	public void Start()
	{
	}

	private void FixedUpdate()
	{
	}
}
