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
			return _003CBaseWorldPos_003Ek__BackingField;
		}
		internal set
		{
			_003CBaseWorldPos_003Ek__BackingField = value;
		}
	}

	private SpriteRenderer FindBaseSymbol()
	{
		return null;
	}

	public void Start()
	{
	}

	public void ResetLine(Vector3 targetWorldPos, bool reset = false)
	{
	}

	public void ConnectRight(WireNode node)
	{
	}

	public void SetColor(Color color)
	{
	}

	public void SetColor(Color color, Sprite symbol)
	{
	}
}
