using UnityEngine;

public class NoShadowBehaviour : MonoBehaviour
{
	public Renderer rend;

	public bool didHit;

	public Renderer shadowChild;

	public float HitHoldSeconds;

	private float lastHitTime;

	public void Start()
	{
	}

	public void OnDestroy()
	{
	}

	private void Update()
	{
	}

	private void FixedUpdate()
	{
	}

	private void Refresh()
	{
	}

	public void SetMaskFunction(int func)
	{
	}

	public void MarkHit()
	{
	}
}
