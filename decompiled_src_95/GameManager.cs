using UnityEngine;

public class GameManager : MonoBehaviour
{
	public virtual PlayerPhysics.BodyTypes GetBodyType(PlayerControl p)
	{
		return default(PlayerPhysics.BodyTypes);
	}

	public virtual bool CanReportBodies()
	{
		return false;
	}

	public virtual bool SabotagesEnabled()
	{
		return false;
	}
}
