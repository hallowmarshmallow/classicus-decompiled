using UnityEngine;

public class DeadBody : MonoBehaviour
{
	public bool Reported;

	public short KillIdx;

	public byte ParentId;

	public Collider2D myCollider;

	public SpriteRenderer MyRend;

	public bool CanReport;

	public Vector2 TruePosition => default(Vector2);

	public void Start()
	{
	}

	public void OnClick()
	{
	}
}
