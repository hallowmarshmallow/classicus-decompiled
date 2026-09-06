using System;
using System.Collections;
using System.Collections.Generic;
using Hazel;
using Kino;
using UnityEngine;

public class BomberRole : RoleBehaviour
{
	public enum RpcCalls
	{
		Explode,
		CheckExplode
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Func<PlayerControl, bool> _003C_003E9__45_0;

		public static Func<PlayerControl, bool> _003C_003E9__45_1;

		static _003C_003Ec()
		{
			throw null;
		}

		public _003C_003Ec()
		{
			throw null;
		}

		internal bool _003CExplode_003Eb__45_0(PlayerControl p)
		{
			throw null;
		}

		internal bool _003CExplode_003Eb__45_1(PlayerControl p)
		{
			throw null;
		}
	}

	private sealed class _003CExplode_003Ed__45 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public BomberRole _003C_003E4__this;

		private Vector2 _003CexplosionSource_003E5__2;

		private GameObject _003CbombObj_003E5__3;

		private List<PlayerControl> _003CalertedPlayers_003E5__4;

		private FollowerCamera _003CfollowerCamera_003E5__5;

		private float _003CogShakeAmount_003E5__6;

		private float _003CogShakePeriod_003E5__7;

		private AnalogGlitch _003Cglitch_003E5__8;

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

		public _003CExplode_003Ed__45(int _003C_003E1__state)
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

	private sealed class _003CFadeAndRecycle_003Ed__43 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public GameObject particle;

		public float duration;

		public SpriteRenderer renderer;

		private float _003Celapsed_003E5__2;

		private Vector3 _003CinitialScale_003E5__3;

		private Vector3 _003CtargetScale_003E5__4;

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

		public _003CFadeAndRecycle_003Ed__43(int _003C_003E1__state)
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

	private sealed class _003CSpawnSmoke_003Ed__42 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public BomberRole _003C_003E4__this;

		public Vector3 position;

		public float spawnRadius;

		public float particleLifetime;

		public int particleCount;

		private int _003Ci_003E5__2;

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

		public _003CSpawnSmoke_003Ed__42(int _003C_003E1__state)
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

	public AbilityButtonSettings BomberSettings;

	public VanillaButtonManager placeButton;

	public AudioClip plantSfx;

	public AudioClip explosionSfx;

	public Sprite bomb;

	public Sprite fogSprite;

	public bool bombEnabled;

	public int MaxUses;

	public int uses;

	private int lastDisplayedUses;

	public float explodeTimer;

	public float explodeCooldown;

	public DateTimeOffset LastExplosion;

	private static readonly WaitForSeconds WaitPlantDelay;

	private static readonly WaitForSeconds WaitPreExplosion;

	private static readonly WaitForSeconds WaitPostGlitch;

	private static readonly WaitForSeconds WaitBombCooldown;

	private static readonly WaitForSeconds WaitSmokeInterval;

	private static readonly Collider2D[] OverlapBuffer;

	private Camera _cachedMainCamera;

	private const int SmokePoolSize = 12;

	private readonly List<GameObject> _smokePool;

	public override bool IsEnabled
	{
		get
		{
			throw null;
		}
	}

	public override string roleDisplayName
	{
		get
		{
			throw null;
		}
	}

	public override string roleDescription
	{
		get
		{
			throw null;
		}
	}

	public bool bombCoolingDown
	{
		get
		{
			throw null;
		}
	}

	public string PlantAbility
	{
		get
		{
			throw null;
		}
	}

	public override void ConfigureRole()
	{
		throw null;
	}

	public override void OnFixedUpdate()
	{
		throw null;
	}

	internal bool CanCooldown()
	{
		throw null;
	}

	public void SetExplodeTimer(float time)
	{
		throw null;
	}

	public void CmdCheckExplode()
	{
		throw null;
	}

	public void RpcExplode()
	{
		throw null;
	}

	public void CheckExplode()
	{
		throw null;
	}

	public GameObject CreateBomb(Vector2 pos)
	{
		throw null;
	}

	private GameObject GetSmokeParticle()
	{
		throw null;
	}

	public IEnumerator SpawnSmoke(Vector3 position, int particleCount, float spawnRadius, float particleLifetime, float spawnInterval)
	{
		throw null;
	}

	private IEnumerator FadeAndRecycle(GameObject particle, SpriteRenderer renderer, float duration)
	{
		throw null;
	}

	public List<PlayerControl> GetPlayersInArea(Vector2 area, float radius)
	{
		throw null;
	}

	public IEnumerator Explode()
	{
		throw null;
	}

	public override void HandleRpc(MessageReader reader, int rpc)
	{
		throw null;
	}

	public override void OnAssign(PlayerControl player)
	{
		throw null;
	}

	public BomberRole()
	{
		throw null;
	}

	static BomberRole()
	{
		throw null;
	}
}
