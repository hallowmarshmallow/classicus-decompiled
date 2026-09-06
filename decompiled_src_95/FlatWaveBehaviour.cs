using UnityEngine;

public class FlatWaveBehaviour : MonoBehaviour
{
	public int NumPoints;

	public FloatRange Width;

	public FloatRange Delta;

	public float Center;

	private Mesh mesh;

	private Vector3[] vecs;

	public float TickRate;

	private float timer;

	public int Skip;

	public float NoiseP;

	public void Start()
	{
	}

	public void Update()
	{
	}
}
