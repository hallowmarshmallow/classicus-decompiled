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
		throw null;
	}

	public static void Vibrate(float lowFreq, float highFreq, float duration)
	{
		throw null;
	}

	public static void Vibrate(float lowFreq, float highFreq, float duration, VibrationFalloff falloff, AudioClip clip, bool loopClip = false)
	{
		throw null;
	}

	public static void Vibrate(float vibration, Vector2 worldPosition, float maxDistance)
	{
		throw null;
	}

	public static void ClearAllVibration()
	{
		throw null;
	}

	public static void CancelVibration(AudioClip clip)
	{
		throw null;
	}
}
