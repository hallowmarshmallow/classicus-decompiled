using System;
using System.Collections;
using System.Collections.Generic;
using PowerTools;
using UnityEngine;

public class KillAnimation : MonoBehaviour
{
	private sealed class _003CCoPerformKill_003Ed__4 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PlayerControl source;

		public PlayerControl target;

		public KillAnimation _003C_003E4__this;

		private PlayerPhysics _003CsourcePhys_003E5__2;

		private FollowerCamera _003CfollowerCam_003E5__3;

		private bool _003CsourceRestored_003E5__4;

		private bool _003CtargetRestored_003E5__5;

		private SpriteAnim _003CsourceAnim_003E5__6;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CCoPerformKill_003Ed__4(int _003C_003E1__state)
		{
		}

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		private void _003C_003Em__Finally1()
		{
		}

		void IEnumerator.Reset()
		{
		}
	}

	public AnimationClip BlurAnim;

	public DeadBody bodyPrefab;

	public Vector3 BodyOffset;

	private static bool CanSnapTo(PlayerControl source, PlayerControl target)
	{
		return false;
	}

	public IEnumerator CoPerformKill(PlayerControl source, PlayerControl target)
	{
		return null;
	}

	public static void SetMovement(PlayerControl source, bool canMove)
	{
	}
}
