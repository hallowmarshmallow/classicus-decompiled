using System;

namespace AudioProcessingModuleCs.Media.Dsp;

public class ResampleFilterLogger
{
	private string _003CInstanceName_003Ek__BackingField;

	private DateTime firstFrameSubmittedAt;

	private DateTime lastResetAt;

	private long totalMaxSampleLength;

	private long totalMinSamplelength;

	private long recentMaxScaledLength;

	private long recentMinScaledLength;

	private long totalMinCorrectedLength;

	private long totalMaxCorrectedLength;

	private long recentMinCorrectedLength;

	private long recentMaxCorrectedLength;

	private long recentReadsTooFast;

	private long totalReadsTooFast;

	private double minCorrectionFactor;

	private double maxCorrectionFactor;

	private DateTime firstFrameRetrievedAt;

	public string InstanceName
	{
		set
		{
			_003CInstanceName_003Ek__BackingField = value;
		}
	}

	internal void LogReadingTooFast(int unreadBytes)
	{
	}
}
