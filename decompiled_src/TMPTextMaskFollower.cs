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
		throw null;
	}

	private void OnDestroy()
	{
		throw null;
	}

	private void LateUpdate()
	{
		throw null;
	}

	private void OnDrawGizmos()
	{
		throw null;
	}

	public TMPTextMaskFollower()
	{
		throw null;
	}
}
