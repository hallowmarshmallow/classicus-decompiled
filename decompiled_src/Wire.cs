using UnityEngine;

public class Wire : MonoBehaviour
{
	private const int WireDepth = -14;

	public SpriteRenderer Liner;

	public SpriteRenderer ColorBase;

	public SpriteRenderer ColorEnd;

	public Collider2D hitbox;

	public SpriteRenderer WireTip;

	public sbyte WireId;

	private Vector2 _003CBaseWorldPos_003Ek__BackingField;

	public Vector2 BaseWorldPos
	{
		get
		{
			throw null;
		}
		internal set
		{
			throw null;
		}
	}

	private SpriteRenderer FindBaseSymbol()
	{
		throw null;
	}

	public void Start()
	{
		throw null;
	}

	public void ResetLine(Vector3 targetWorldPos, bool reset = false)
	{
		throw null;
	}

	public void ConnectRight(WireNode node)
	{
		throw null;
	}

	public void SetColor(Color color)
	{
		throw null;
	}

	public void SetColor(Color color, Sprite symbol)
	{
		throw null;
	}

	public Wire()
	{
		throw null;
	}
}
