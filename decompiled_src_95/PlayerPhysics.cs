using System;
using System.Collections;
using System.Collections.Generic;
using Hazel;
using InnerNet;
using PowerTools;
using UnityEngine;

public class PlayerPhysics : InnerNetObject
{
	private enum RpcCalls
	{
		EnterVent,
		ExitVent,
		ClimbLadder
	}

	public enum BodyTypes
	{
		Normal,
		Seeker,
		Horse,
		Invisible,
		Old
	}

	private sealed class _003C_003Ec__DisplayClass36_0
	{
		public PlayerBody body;

		internal void _003CSetBody_003Eb__0(PlayerBody b)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass37_0
	{
		public PlayerBody body;

		internal void _003CSetBodyType_003Eb__0(PlayerBody b)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass56_0
	{
		public int id;

		internal bool _003CCoEnterVent_003Eb__0(Vent v)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass57_0
	{
		public int id;

		internal bool _003CCoExitVent_003Eb__0(Vent v)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass71_0
	{
		public byte ladderId;

		internal bool _003CHandleRpc_003Eb__0(Ladder f)
		{
			return false;
		}
	}

	private sealed class _003CCoClimbLadder_003Ed__62 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PlayerPhysics _003C_003E4__this;

		public Ladder source;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CCoClimbLadder_003Ed__62(int _003C_003E1__state)
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

		void IEnumerator.Reset()
		{
		}
	}

	private sealed class _003CCoEnterVent_003Ed__56 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public int id;

		public PlayerPhysics _003C_003E4__this;

		private Vent _003Cvent_003E5__2;

		private SubmergedVentEffect _003CventEffect_003E5__3;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CCoEnterVent_003Ed__56(int _003C_003E1__state)
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

		void IEnumerator.Reset()
		{
		}
	}

	private sealed class _003CCoExitVent_003Ed__57 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public int id;

		public PlayerPhysics _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CCoExitVent_003Ed__57(int _003C_003E1__state)
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

		void IEnumerator.Reset()
		{
		}
	}

	private sealed class _003CCoSpawnPlayer_003Ed__52 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public LobbyBehaviour lobby;

		public PlayerPhysics _003C_003E4__this;

		private Vector3 _003CspawnPos_003E5__2;

		private bool _003CamFlipped_003E5__3;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CCoSpawnPlayer_003Ed__52(int _003C_003E1__state)
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

	private sealed class _003CWalkPlayerTo_003Ed__58 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public bool ignoreColliderOffset;

		public Vector2 worldPos;

		public PlayerPhysics _003C_003E4__this;

		public float speedMul;

		public float tolerance;

		private Rigidbody2D _003Cbody_003E5__2;

		private Vector2 _003Cdel_003E5__3;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CWalkPlayerTo_003Ed__58(int _003C_003E1__state)
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

		void IEnumerator.Reset()
		{
		}
	}

	public float Speed;

	public float GhostSpeed;

	private Rigidbody2D body;

	private PlayerControl myPlayer;

	public AnimationClip SpawnAnim;

	public SkinLayer Skin;

	public SpriteAnimNodeSync HatSync;

	public PlayerBody[] playerBodies;

	public PlayerBody CurBody;

	public BodyTypes CurrentBodyType;

	private byte lastClimbLadderSid;

	private const float ClimbPositionTolerance = 0.0005f;

	private HudManager cachedHudManager;

	private float remoteFlipCandSign;

	private float remoteFlipCandAt;

	private static float lastSpawnSoundRealtime;

	private const float SpawnSoundMinInterval = 0.5f;

	private bool _ventTransition;

	private Coroutine _ventRoutine;

	public SpriteAnim Animator => null;

	public SpriteRenderer rend => null;

	public PlayerBody _curBody => null;

	public AnimationClip RunAnim => null;

	public AnimationClip IdleAnim => null;

	public AnimationClip EnterVentAnim => null;

	public AnimationClip ExitVentAnim => null;

	public float TrueSpeed => 0f;

	public float TrueGhostSpeed => 0f;

	public void Awake()
	{
	}

	public void EnableInterpolation()
	{
	}

	private void FixedUpdate()
	{
	}

	public void SetBody(PlayerBody body)
	{
	}

	public void SetBodyType(BodyTypes type)
	{
	}

	public void Recalculate()
	{
	}

	private void LateUpdate()
	{
	}

	public Vector3 Vec2ToPosition(Vector2 pos)
	{
		return default(Vector3);
	}

	public void SetSkin(string skinId)
	{
	}

	public void ResetAnim(bool stopCoroutines = true)
	{
	}

	public void RecalculateBodyType()
	{
	}

	public void ResetSkin(bool flipX = false)
	{
	}

	private void ApplyRunFlip(Vector2 velocity)
	{
	}

	private void HandleAnimation()
	{
	}

	private static bool ClaimSpawnSound()
	{
		return false;
	}

	public IEnumerator CoSpawnPlayer(LobbyBehaviour lobby)
	{
		return null;
	}

	public void ExitAllVents()
	{
	}

	private void ClearVentButtons()
	{
	}

	private void ClearVentEffects()
	{
	}

	private IEnumerator CoEnterVent(int id)
	{
		return null;
	}

	private IEnumerator CoExitVent(int id)
	{
		return null;
	}

	public IEnumerator WalkPlayerTo(Vector2 worldPos, float tolerance = 0.01f, float speedMul = 1f, bool ignoreColliderOffset = false)
	{
		return null;
	}

	public void RpcClimbLadder(Ladder source)
	{
	}

	private void ClimbLadder(Ladder source, byte climbLadderSid)
	{
	}

	public void StartClimb(bool down)
	{
	}

	private IEnumerator CoClimbLadder(Ladder source)
	{
		return null;
	}

	public override bool Serialize(MessageWriter writer, bool initialState)
	{
		return false;
	}

	public override void Deserialize(MessageReader reader, bool initialState)
	{
	}

	private void StartVentRoutine(IEnumerator routine)
	{
	}

	public void RpcEnterVent(int id)
	{
	}

	public void RpcExitVent(int id)
	{
	}

	public void ExitVent(int id)
	{
	}

	public override void HandleRpc(byte callId, MessageReader reader)
	{
	}
}
