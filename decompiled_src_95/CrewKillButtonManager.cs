using TMPro;
using UnityEngine;

public class CrewKillButtonManager : MonoBehaviour
{
	public PlayerControl CurrentTarget;

	public SpriteRenderer renderer;

	public TextMeshPro TimerText;

	public bool isCoolingDown;

	public bool LastTime;

	public bool isActive;

	public GameObject OnlyAfterFinish;

	private Vector2 uv;

	public void Start()
	{
	}

	public void PerformKill()
	{
	}

	public void OnEnable()
	{
	}

	public void SetTarget(PlayerControl target)
	{
	}

	public void SetCoolDown(float timer, float maxTimer)
	{
	}
}
