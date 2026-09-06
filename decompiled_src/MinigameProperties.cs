using System.Collections.Generic;
using UnityEngine;

public class MinigameProperties : MonoBehaviour
{
	public string @string;

	public AudioClip[] audioClips;

	public Collider2D[] colliders;

	public GameObject[] gameObjects;

	public int[] integers;

	public Sprite[] sprites;

	public List<Transform> transforms;

	public Vector2[] vector2S;

	public string playerTaskName;

	public string minigameName;

	public bool dontCloseOnBgClick;

	public void Awake()
	{
		throw null;
	}

	public void CloseTask()
	{
		throw null;
	}

	public (string, string) GetCustomTypes()
	{
		throw null;
	}

	public MinigameProperties()
	{
		throw null;
	}
}
