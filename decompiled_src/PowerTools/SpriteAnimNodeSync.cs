using System.Collections.Generic;
using UnityEngine;

namespace PowerTools;

public class SpriteAnimNodeSync : MonoBehaviour
{
	private sealed class ClipBob
	{
		public float BaseY;

		public float Lo;

		public float Hi;

		public bool Learned;

		public float StartNorm;

		public float PrevNorm;

		public float SampleTime;

		public ClipBob()
		{
			throw null;
		}
	}

	private static readonly Dictionary<(AnimationClip, int), ClipBob> s_clipBob;

	public int NodeId;

	public bool lockAngle;

	public SpriteAnimNodes Parent;

	public SpriteRenderer ParentRenderer;

	public SpriteRenderer Renderer;

	public Vector3 flipOffset;

	public Vector3 normalOffset;

	public float nodeScale;

	public float bobAmplify;

	public float bobTiltDegrees;

	public bool bobInvert;

	public float bobUpScale;

	public float bobDownScale;

	public float bobPivot;

	public float idleBobSpeed;

	public float idleBobAmount;

	public bool idleBobSyncToAnim;

	public float idleNodAmplify;

	public AnimationClip idleClip;

	public AnimationClip runClip;

	private SpriteAnimNodes _lastParent;

	private SpriteAnim _spriteAnim;

	private AnimationClip _lastClip;

	private ClipBob _entry;

	private int _clipFrames;

	private float _idleBobPhase;

	public void SetSyncParent(Transform parent)
	{
		throw null;
	}

	public void LateUpdate()
	{
		throw null;
	}

	public void ResetBobBaseline()
	{
		throw null;
	}

	public SpriteAnimNodeSync()
	{
		throw null;
	}

	static SpriteAnimNodeSync()
	{
		throw null;
	}
}
