using UnityEngine;

public class MinecraftBlock : MonoBehaviour
{
	public string Id;

	public bool IsSolid;

	public int Resistance;

	public SpriteRenderer rend;

	public void Start()
	{
		throw null;
	}

	public virtual void Interact(string interactionName)
	{
		throw null;
	}

	public void Break()
	{
		throw null;
	}

	public MinecraftBlock()
	{
		throw null;
	}
}
