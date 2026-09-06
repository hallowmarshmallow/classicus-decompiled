using UnityEngine;

public class MapRoom : MonoBehaviour
{
	public SystemTypes room;

	public SpriteRenderer door;

	public SpriteRenderer special;

	private InfectedOverlay _003CParent_003Ek__BackingField;

	public InfectedOverlay Parent
	{
		get
		{
			return _003CParent_003Ek__BackingField;
		}
		set
		{
			_003CParent_003Ek__BackingField = value;
		}
	}

	public void Start()
	{
	}

	public void OOBUpdate()
	{
	}

	internal void SetSpecialActive(float perc)
	{
	}

	public void SabotageReactor()
	{
	}

	public void SabotageSeismic()
	{
	}

	public void SabotageHeli()
	{
	}

	public void SabotageComms()
	{
	}

	public void SabotageOxygen()
	{
	}

	public void SabotageMask()
	{
	}

	public void SabotageLights()
	{
	}

	public void SabotageDoors()
	{
	}
}
