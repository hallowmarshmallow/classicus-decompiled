using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SteadyHeartbeatMinigame : Minigame
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Func<Vector2, Vector3> _003C_003E9__17_0;

		public static Func<Vector3, bool> _003C_003E9__19_0;

		public static Func<Vector3, bool> _003C_003E9__19_1;

		static _003C_003Ec()
		{
			throw null;
		}

		public _003C_003Ec()
		{
			throw null;
		}

		internal Vector3 _003CStart_003Eb__17_0(Vector2 v)
		{
			throw null;
		}

		internal bool _003CBeatHeart_003Eb__19_0(Vector3 t)
		{
			throw null;
		}

		internal bool _003CBeatHeart_003Eb__19_1(Vector3 v)
		{
			throw null;
		}
	}

	private const float IN_RANGE_TARGET = 5f;

	private readonly Vector3[] _default;

	private Vector3[] _beat;

	private LineRenderer _beatLine;

	private List<float> _beats;

	private float _beatTimer;

	private int _bpmTarget;

	public TextMeshPro _bpmText;

	public TextMeshPro _bpmTextLeft;

	private float _inRangeTimer;

	private MinigameProperties _minigameProperties;

	public List<Vector3> _points;

	public FloatRange _range;

	public TextMeshPro _statusText;

	public TextMeshPro _targetText;

	public AudioClip HeartBeat;

	private float _timer;

	private void Start()
	{
		throw null;
	}

	private void Update()
	{
		throw null;
	}

	private void BeatHeart(int bpm)
	{
		throw null;
	}

	public SteadyHeartbeatMinigame()
	{
		throw null;
	}

	private void _003CStart_003Eb__17_1()
	{
		throw null;
	}

	private bool _003CUpdate_003Eb__18_0(float t)
	{
		throw null;
	}
}
