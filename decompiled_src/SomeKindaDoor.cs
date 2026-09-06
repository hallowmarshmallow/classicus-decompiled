using UnityEngine;

public abstract class SomeKindaDoor : MonoBehaviour
{
	public abstract void SetDoorway(bool open);

	protected SomeKindaDoor()
	{
		throw null;
	}
}
