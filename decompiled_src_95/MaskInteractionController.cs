using UnityEngine;

public class MaskInteractionController : MonoBehaviour
{
	public enum MaskMode
	{
		None,
		VisibleInside,
		VisibleOutside
	}

	public MaskMode maskMode;

	public bool includeChildren;

	private void Start()
	{
	}

	public void ApplyMaskInteraction()
	{
	}
}
