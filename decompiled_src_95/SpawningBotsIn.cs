using TMPro;
using UnityEngine;

public class SpawningBotsIn : MonoBehaviour
{
	private const string TargetObjectName = "SpawningBotsIn";

	private const float WarnLeadSeconds = 10f;

	private static readonly Color StartColor;

	private static readonly Color EndColor;

	private static readonly float[] WaveAtSeconds;

	private static readonly int[] WaveTotal;

	private GameObject _target;

	private TMP_Text _text;

	private int _lastShownSeconds;

	private float _nextRebind;

	public static void Attach()
	{
	}

	private void Bind()
	{
	}

	private void LateUpdate()
	{
	}

	private void Hide()
	{
	}

	private static bool TryGetNextWave(float elapsed, out float remaining, out int incoming)
	{
		remaining = default(float);
		incoming = default(int);
		return false;
	}

	private static bool TryGetUltimateWave(float elapsed, out float remaining, out int incoming)
	{
		remaining = default(float);
		incoming = default(int);
		return false;
	}

	private static string Localize(int incoming, int seconds)
	{
		return null;
	}

	private static GameObject FindByName(string name)
	{
		return null;
	}

	private static Transform FindDeep(Transform root, string name)
	{
		return null;
	}
}
