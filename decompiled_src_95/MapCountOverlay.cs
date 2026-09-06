using System.Collections.Generic;
using UnityEngine;

public class MapCountOverlay : MonoBehaviour
{
	public AlphaPulse BackgroundColor;

	public TextRenderer SabotageText;

	public CounterArea[] CountAreas;

	private Collider2D[] buffer;

	private readonly HashSet<byte> countedPlayers;

	private ContactFilter2D filter;

	private float timer;

	private bool isSab;

	public void Awake()
	{
	}

	public void OnEnable()
	{
	}

	public void OnDisable()
	{
	}

	public void Update()
	{
	}
}
