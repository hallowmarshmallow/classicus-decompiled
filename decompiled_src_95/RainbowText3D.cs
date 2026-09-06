using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class RainbowText3D : MonoBehaviour
{
	public float rainbowSpeed;

	private TextMeshPro tmp;

	private float hue;

	private readonly Dictionary<int, Color32> lockedCharacters;

	private void Awake()
	{
	}

	private void Update()
	{
	}

	public void LockCharacterRange(int startIndex, int endIndex, Color32 color)
	{
	}

	public void UnlockCharacterRange(int startIndex, int endIndex)
	{
	}

	public void ClearAllLocks()
	{
	}
}
