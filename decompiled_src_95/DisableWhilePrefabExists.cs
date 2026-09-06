using UnityEngine;

public class DisableWhilePrefabExists : MonoBehaviour
{
	public GameObject prefabToCheck;

	private float checkInterval;

	private string cloneName;

	private float nextCheckTime;
}
