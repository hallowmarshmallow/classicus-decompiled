using UnityEngine;

public class SubmersibleSlider : MonoBehaviour
{
	public bool complete;

	public SpriteRenderer targetLine;

	public GameObject sliderHandle;

	public Collider2D handleCollider;

	public Transform max;

	public Transform min;

	private readonly Controller _controller;

	private bool _active;

	private Vector3 _mouseOffset;

	private void Awake()
	{
	}

	private void Update()
	{
	}
}
