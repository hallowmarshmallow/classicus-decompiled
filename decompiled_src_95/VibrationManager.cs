using UnityEngine;

public static class VibrationManager
{
	public enum VibrationFalloff
	{
		None,
		Linear
	}

	public static void Vibrate(float lowFreq, float highFreq, float duration, VibrationFalloff falloff = VibrationFalloff.None)
	{
	}

	public static void Vibrate(float lowFreq, float highFreq, float duration)
	{
	}

	public static void Vibrate(float lowFreq, float highFreq, float duration, VibrationFalloff falloff, AudioClip clip, bool loopClip = false)
	{
	}

	public static void Vibrate(float vibration, Vector2 worldPosition, float maxDistance)
	{
	}

	public static void ClearAllVibration()
	{
	}

	public static void CancelVibration(AudioClip clip)
	{
	}
}
