using System.Collections.Generic;
using Hazel.Udp;
using UnityEngine;

public class GameDiscovery : MonoBehaviour
{
	public JoinGameButton ButtonPrefab;

	public Transform ItemLocation;

	public float YStart;

	public float YOffset;

	private Dictionary<string, JoinGameButton> received;

	public void Start()
	{
		throw null;
	}

	public void Update()
	{
		throw null;
	}

	private void Receive(BroadcastPacket packet)
	{
		throw null;
	}

	private void CreateButtonForAddess(string fromAddress, string[] gameNameParts)
	{
		throw null;
	}

	public GameDiscovery()
	{
		throw null;
	}
}
