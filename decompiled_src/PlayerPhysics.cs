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

		public _003C_003Ec__DisplayClass36_0()
		{
			throw null;
		}

		internal void _003CSetBody_003Eb__0(PlayerBody b)
		{
			throw null;
		}
	}

	private sealed class _003C_003Ec__DisplayClass37_0
	{
		public PlayerBody body;

		public _003C_003Ec__DisplayClass37_0()
		{
			throw null;
		}

		internal void _003CSetBodyType_003Eb__0(PlayerBody b)
		{
			throw null;
		}
	}

	private sealed class _003C_003Ec__DisplayClass56_0
	{
		public int id;

		public _003C_003Ec__DisplayClass56_0()
		{
			throw null;
		}

		internal bool _003CCoEnterVent_003Eb__0(Vent v)
		{
			throw null;
		}
	}

	private sealed class _003C_003Ec__DisplayClass57_0
	{
		public int id;

		public _003C_003Ec__DisplayClass57_0()
		{
			throw null;
		}

		internal bool _003CCoExitVent_003Eb__0(Vent v)
		{
			throw null;
		}
	}

	private sealed class _003C_003Ec__DisplayClass71_0
	{
		public byte ladderId;

		public _003C_003Ec__DisplayClass71_0()
		{
			throw null;
		}

		internal bool _003CHandleRpc_003Eb__0(Ladder f)
		{
			throw null;
		}
	}

	private sealed class _003CCoClimbLadder_003Ed__62 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PlayerPhysics _003C_003E4__this;

		public Ladder source;

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

		public _003CCoClimbLadder_003Ed__62(int _003C_003E1__state)
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

		void IEnumerator.Reset()
		{
			throw null;
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

		public _003CCoEnterVent_003Ed__56(int _003C_003E1__state)
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

		void IEnumerator.Reset()
		{
			throw null;
		}
	}

	private sealed class _003CCoExitVent_003Ed__57 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public int id;

		public PlayerPhysics _003C_003E4__this;

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

		public _003CCoExitVent_003Ed__57(int _003C_003E1__state)
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

		void IEnumerator.Reset()
		{
			throw null;
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

		public _003CCoSpawnPlayer_003Ed__52(int _003C_003E1__state)
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

		public _003CWalkPlayerTo_003Ed__58(int _003C_003E1__state)
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

		void IEnumerator.Reset()
		{
			throw null;
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

	public SpriteAnim Animator
	{
		get
		{
			throw null;
		}
	}

	public SpriteRenderer rend
	{
		get
		{
			throw null;
		}
	}

	public PlayerBody _curBody
	{
		get
		{
			throw null;
		}
	}

	public AnimationClip RunAnim
	{
		get
		{
			throw null;
		}
	}

	public AnimationClip IdleAnim
	{
		get
		{
			throw null;
		}
	}

	public AnimationClip EnterVentAnim
	{
		get
		{
			throw null;
		}
	}

	public AnimationClip ExitVentAnim
	{
		get
		{
			throw null;
		}
	}

	public float TrueSpeed
	{
		get
		{
			throw null;
		}
	}

	public float TrueGhostSpeed
	{
		get
		{
			throw null;
		}
	}

	public void Awake()
	{
		throw null;
	}

	public void EnableInterpolation()
	{
		throw null;
	}

	private void FixedUpdate()
	{
		throw null;
	}

	public void SetBody(PlayerBody body)
	{
		throw null;
	}

	public void SetBodyType(BodyTypes type)
	{
		throw null;
	}

	public void Recalculate()
	{
		throw null;
	}

	private void LateUpdate()
	{
		throw null;
	}

	public Vector3 Vec2ToPosition(Vector2 pos)
	{
		throw null;
	}

	public void SetSkin(string skinId)
	{
		throw null;
	}

	public void ResetAnim(bool stopCoroutines = true)
	{
		throw null;
	}

	public void RecalculateBodyType()
	{
		throw null;
	}

	public void ResetSkin(bool flipX = false)
	{
		throw null;
	}

	private void ApplyRunFlip(Vector2 velocity)
	{
		throw null;
	}

	private void HandleAnimation()
	{
		throw null;
	}

	private static bool ClaimSpawnSound()
	{
		throw null;
	}

	public IEnumerator CoSpawnPlayer(LobbyBehaviour lobby)
	{
		throw null;
	}

	public void ExitAllVents()
	{
		throw null;
	}

	private void ClearVentButtons()
	{
		throw null;
	}

	private void ClearVentEffects()
	{
		throw null;
	}

	private IEnumerator CoEnterVent(int id)
	{
		throw null;
	}

	private IEnumerator CoExitVent(int id)
	{
		throw null;
	}

	public IEnumerator WalkPlayerTo(Vector2 worldPos, float tolerance = 0.01f, float speedMul = 1f, bool ignoreColliderOffset = false)
	{
		throw null;
	}

	public void RpcClimbLadder(Ladder source)
	{
		throw null;
	}

	private void ClimbLadder(Ladder source, byte climbLadderSid)
	{
		throw null;
	}

	public void StartClimb(bool down)
	{
		throw null;
	}

	private IEnumerator CoClimbLadder(Ladder source)
	{
		throw null;
	}

	public override bool Serialize(MessageWriter writer, bool initialState)
	{
		throw null;
	}

	public override void Deserialize(MessageReader reader, bool initialState)
	{
		throw null;
	}

	private void StartVentRoutine(IEnumerator routine)
	{
		throw null;
	}

	public void RpcEnterVent(int id)
	{
		throw null;
	}

	public void RpcExitVent(int id)
	{
		throw null;
	}

	public void ExitVent(int id)
	{
		throw null;
	}

	public override void HandleRpc(byte callId, MessageReader reader)
	{
		throw null;
	}

	public PlayerPhysics()
	{
		throw null;
	}

	static PlayerPhysics()
	{
		throw null;
	}
}
