using UnityEngine;

public class BodyShadow : MonoBehaviour
{
	public DeadBody target;

	public SpriteRenderer shadowRend;

	private SpriteRenderer bodyRend;

	public Sprite[] sprites;

	public Color shadowColor;

	private float checkTimer;

	private float randomTimer;

	private bool isInsideCache;

	private Sprite lastSprite;

	public void Start()
	{
	}

	private void FixedUpdate()
	{
	}
}
