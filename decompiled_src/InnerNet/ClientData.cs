using System;

namespace InnerNet;

[Serializable]
public class ClientData
{
	public int Id;

	public bool InScene;

	public bool IsReady;

	public bool IsBeingCreated;

	public PlayerControl Character;

	public ClientData(int id)
	{
		throw null;
	}
}
