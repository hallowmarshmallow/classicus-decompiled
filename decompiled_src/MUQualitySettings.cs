using System.Collections.Generic;

public static class MUQualitySettings
{
	public enum QualityPreset
	{
		Low,
		NormalLowLoad,
		Normal,
		High,
		Ultra
	}

	private static readonly List<IQualityElement> RegisteredElements;

	public static bool LowLoad;

	public static bool IgnoreScreenCutoffs;

	public static void Register(IQualityElement element)
	{
		throw null;
	}

	public static void Unregister(IQualityElement element)
	{
		throw null;
	}

	public static void ApplySettings()
	{
		throw null;
	}

	private static void ApplyGlobalQuality(QualityPreset preset)
	{
		throw null;
	}

	static MUQualitySettings()
	{
		throw null;
	}
}
