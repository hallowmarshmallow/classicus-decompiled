using PowerTools;
using UnityEngine;

public class SkinLayer : MonoBehaviour
{
	public SpriteRenderer layer;

	public SpriteAnim animator;

	public SkinData skin;

	public bool Flipped
	{
		set
		{
		}
	}

	public bool Visible
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public void SetRun()
	{
	}

	public void SetSpawn(float time = 0f)
	{
	}

	public void SetExitVent()
	{
	}

	public void SetEnterVent()
	{
	}

	internal void SetClimb(bool down)
	{
	}

	public void SetIdle()
	{
	}

	public void SetGhost()
	{
	}

	internal void SetSkin(string skinId)
	{
	}

	internal void SetSkinOut(string skinId, out SkinData skinOut)
	{
		skinOut = null;
	}
}
