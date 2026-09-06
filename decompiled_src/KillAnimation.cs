using System;
using System.Collections;
using System.Collections.Generic;
using PowerTools;
using UnityEngine;

public class KillAnimation : MonoBehaviour
{
	private sealed class _003CCoPerformKill_003Ed__3 : IEnumerator<object>, IEnumerator, IDisposable
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

		object IEnumerator<object>.Current
		{
			get
			{
				throw null;
			}
		}

		object IEnumerator.Current
		{
			get
			{
				throw null;
			}
		}

		public _003CCoPerformKill_003Ed__3(int _003C_003E1__state)
		{
			throw null;
		}

		void IDisposable.Dispose()
		{
			throw null;
		}

		private bool MoveNext()
		{
			throw null;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		private void _003C_003Em__Finally1()
		{
			throw null;
		}

		void IEnumerator.Reset()
		{
			throw null;
		}
	}

	public AnimationClip BlurAnim;

	public DeadBody bodyPrefab;

	public Vector3 BodyOffset;

	public IEnumerator CoPerformKill(PlayerControl source, PlayerControl target)
	{
		throw null;
	}

	public static void SetMovement(PlayerControl source, bool canMove)
	{
		throw null;
	}

	public KillAnimation()
	{
		throw null;
	}
}
