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

	public bool IsOpen
	{
		get
		{
			throw null;
		}
	}

	public bool IsOpenStopped
	{
		get
		{
			throw null;
		}
	}

	private void Awake()
	{
		throw null;
	}

	public void SetPreMeetingPosition(Vector3 position)
	{
		throw null;
	}

	private void GenericShow()
	{
		throw null;
	}

	public void ShowInfectedMap()
	{
		throw null;
	}

	public void ShowNormalMap()
	{
		throw null;
	}

	public void ShowCountOverlay()
	{
		throw null;
	}

	public void FixedUpdate()
	{
		throw null;
	}

	private void UpdateBotDots()
	{
		throw null;
	}

	private SpriteRenderer GetOrCreateBotDot(int index)
	{
		throw null;
	}

	private void HideBotDots(int fromIndex)
	{
		throw null;
	}

	public void Close()
	{
		throw null;
	}

	public MapBehaviour()
	{
		throw null;
	}
}
