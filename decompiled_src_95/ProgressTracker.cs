using UnityEngine;

public class ProgressTracker : MonoBehaviour
{
	public MeshRenderer TileParent;

	private float curValue;

	private int _prevCompleted;

	public void Start()
	{
	}

	public void FixedUpdate()
	{
	}

	private static bool ContributesToTaskBar(GameData.PlayerInfo playerInfo)
	{
		return false;
	}
}
