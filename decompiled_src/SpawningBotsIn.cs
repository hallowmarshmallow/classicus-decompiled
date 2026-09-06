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
		throw null;
	}

	private void Bind()
	{
		throw null;
	}

	private void LateUpdate()
	{
		throw null;
	}

	private void Hide()
	{
		throw null;
	}

	private static bool TryGetNextWave(float elapsed, out float remaining, out int incoming)
	{
		throw null;
	}

	private static bool TryGetUltimateWave(float elapsed, out float remaining, out int incoming)
	{
		throw null;
	}

	private static string Localize(int incoming, int seconds)
	{
		throw null;
	}

	private static GameObject FindByName(string name)
	{
		throw null;
	}

	private static Transform FindDeep(Transform root, string name)
	{
		throw null;
	}

	public SpawningBotsIn()
	{
		throw null;
	}

	static SpawningBotsIn()
	{
		throw null;
	}
}
