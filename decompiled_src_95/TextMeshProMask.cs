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
	}

	private void ApplyMask()
	{
	}

	private void OnDrawGizmos()
	{
	}
}
