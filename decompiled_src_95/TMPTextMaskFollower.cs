using TMPro;
using UnityEngine;

public class TMPTextMaskFollower : MonoBehaviour
{
	public enum MaskMode
	{
		VisibleInside,
		VisibleOutside
	}

	public Transform maskObject;

	public Rect maskRect;

	public MaskMode maskMode;

	private TextMeshPro[] tmpTexts;

	private Material[] tmpMaterials;

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	private void LateUpdate()
	{
	}

	private void OnDrawGizmos()
	{
	}
}
