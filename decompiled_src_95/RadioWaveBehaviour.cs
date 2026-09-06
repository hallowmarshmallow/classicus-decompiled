using UnityEngine;

public class RadioWaveBehaviour : MonoBehaviour
{
	public int NumPoints;

	public FloatRange Width;

	public FloatRange Height;

	private Mesh mesh;

	private Vector3[] vecs;

	public float TickRate;

	private float timer;

	public int Skip;

	public float Frequency;

	private int Tick;

	public bool Random;

	public float NoiseLevel;

	public void Start()
	{
	}

	public void Update()
	{
	}
}
