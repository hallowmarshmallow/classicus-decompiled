public static class LowEndDeviceOptimizer
{
	private static bool _003CIsLowEndDevice_003Ek__BackingField;

	public static bool IsLowEndDevice
	{
		get
		{
			return _003CIsLowEndDevice_003Ek__BackingField;
		}
		private set
		{
			_003CIsLowEndDevice_003Ek__BackingField = value;
		}
	}

	private static void Detect()
	{
	}

	public static void EnforceLowEndLimits()
	{
	}
}
