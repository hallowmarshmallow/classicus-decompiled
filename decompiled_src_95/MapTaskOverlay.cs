using System.Collections.Generic;
using UnityEngine;

public class MapTaskOverlay : MonoBehaviour
{
	public ObjectPoolBehavior icons;

	private Dictionary<PlayerTask, List<PooledMapIcon>> data;

	private readonly Dictionary<byte, PooledMapIcon> runnerOrbs;

	private readonly List<RunnerPowerupPickup> runnerScratch;

	private readonly List<byte> runnerStale;

	public void Show()
	{
	}

	public void Update()
	{
	}

	private void PlaceIcons(PlayerTask task)
	{
	}

	private void ReclaimIcons(PlayerTask task)
	{
	}

	private void RefreshRunnerOrbs()
	{
	}

	private void ReclaimRunnerOrbs()
	{
	}

	private void ReclaimTaskIcons()
	{
	}

	public void Hide()
	{
	}
}
