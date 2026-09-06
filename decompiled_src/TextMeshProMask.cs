using UnityEngine;

public class TextMeshProMask : MonoBehaviour
{
	public enum MaskMode
	{
		VisibleInside,
		VisibleOutside
	}

	public MaskMode maskMode;

	public Rect maskArea;

	public Vector3 maskScale;

	private void LateUpdate()
	{
		throw null;
	}

	private void ApplyMask()
	{
		throw null;
	}

	private void OnDrawGizmos()
	{
		throw null;
	}

	public TextMeshProMask()
	{
		throw null;
	}
}
