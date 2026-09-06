using UnityEngine;

public class HatParent : MonoBehaviour
{
	private HatBehaviour _003CHat_003Ek__BackingField;

	private const float ClimbHatRaise = 0.12f;

	private bool climbRaiseApplied;

	public SpriteRenderer BackLayer;

	public SpriteRenderer FrontLayer;

	public SpriteRenderer Parent;

	public HatBehaviour Hat
	{
		get
		{
			return _003CHat_003Ek__BackingField;
		}
		set
		{
			_003CHat_003Ek__BackingField = value;
		}
	}

	public Color color
	{
		set
		{
		}
	}

	public bool flipX
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public int sortingOrder
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public Material material
	{
		set
		{
		}
	}

	public SpriteMaskInteraction maskInteraction
	{
		set
		{
		}
	}

	public void SetHat(HatBehaviour hat, int color)
	{
	}

	public void SetHat(int color)
	{
	}

	public void SetIdleAnim()
	{
	}

	public void SetHat(uint hatId, int color)
	{
	}

	public void SetHat(string prodId, int color = 0)
	{
	}

	internal void SetFloorAnim()
	{
	}

	private void ApplyClimbRaise(bool apply)
	{
	}

	internal void SetClimbAnim()
	{
	}

	public void LateUpdate()
	{
	}

	internal void SetColor(int color)
	{
	}

	internal void SetMaskLayer(int layer)
	{
	}

	public void SetEnabled(bool enabled)
	{
	}
}
