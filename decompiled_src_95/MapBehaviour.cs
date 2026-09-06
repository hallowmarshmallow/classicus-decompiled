using System.Collections.Generic;
using UnityEngine;

public class MapBehaviour : MonoBehaviour
{
	public static MapBehaviour Instance;

	private readonly List<SpriteRenderer> _botDots;

	private const int BotDotColorId = 0;

	public AlphaPulse ColorControl;

	public SpriteRenderer HerePoint;

	public MapCountOverlay countOverlay;

	public InfectedOverlay infectedOverlay;

	public MapTaskOverlay taskOverlay;

	private Vector3? preMeetingPosition;

	public bool IsOpen => false;

	public bool IsOpenStopped => false;

	private void Awake()
	{
	}

	public void SetPreMeetingPosition(Vector3 position)
	{
	}

	private void GenericShow()
	{
	}

	public void ShowInfectedMap()
	{
	}

	public void ShowNormalMap()
	{
	}

	public void ShowCountOverlay()
	{
	}

	public void FixedUpdate()
	{
	}

	private void UpdateBotDots()
	{
	}

	private SpriteRenderer GetOrCreateBotDot(int index)
	{
		return null;
	}

	private void HideBotDots(int fromIndex)
	{
	}

	public void Close()
	{
	}
}
