using System;
using System.Collections.Generic;
using UnityEngine;

namespace GoogleMobileAds.Common;

public class MobileAdsEventExecutor : MonoBehaviour
{
	public static MobileAdsEventExecutor instance;

	private static List<Action> adEventsQueue;

	private static bool adEventsQueueEmpty;

	public static void Initialize()
	{
		throw null;
	}

	public static bool IsActive()
	{
		throw null;
	}

	public void Awake()
	{
		throw null;
	}

	public static void ExecuteInUpdate(Action action)
	{
		throw null;
	}

	public void Update()
	{
		throw null;
	}

	public void OnDisable()
	{
		throw null;
	}

	public MobileAdsEventExecutor()
	{
		throw null;
	}

	static MobileAdsEventExecutor()
	{
		throw null;
	}
}
