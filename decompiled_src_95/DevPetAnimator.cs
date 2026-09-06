using UnityEngine;

public class DevPetAnimator : MonoBehaviour
{
	public Sprite[] Frames;

	public float SecondsPerFrame;

	private SpriteRenderer _rend;

	private float _timer;

	private int _index;

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void LateUpdate()
	{
	}
}
