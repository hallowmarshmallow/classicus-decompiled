using System.Collections;
using UnityEngine;

namespace PowerTools;

public class WaitForAnimationFinish : IEnumerator
{
	private SpriteAnim animator;

	private AnimationClip clip;

	private bool first;

	public object Current => null;

	public WaitForAnimationFinish(SpriteAnim animator, AnimationClip clip)
	{
	}

	public bool MoveNext()
	{
		return false;
	}

	public void Reset()
	{
	}
}
