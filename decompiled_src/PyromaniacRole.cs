using System;
using System.Collections;
using System.Collections.Generic;
using Hazel;
using UnityEngine;

public class PyromaniacRole : RoleBehaviour
{
	public enum RpcCalls
	{
		Explode,
		CheckExplode,
		DieFire
	}

	private sealed class _003CExplode_003Ed__33 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PyromaniacRole _003C_003E4__this;

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

		public _003CExplode_003Ed__33(int _003C_003E1__state)
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

	private sealed class _003CFadeAndDestroy_003Ed__31 : IEnumerator<object>, IEnumerator, IDisposable
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

		public _003CFadeAndDestroy_003Ed__31(int _003C_003E1__state)
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

	private sealed class _003CSpawnSmoke_003Ed__30 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Vector3 position;

		public float spawnRadius;

		public PyromaniacRole _003C_003E4__this;

		public float particleLifetime;

		public float spawnInterval;

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

		public _003CSpawnSmoke_003Ed__30(int _003C_003E1__state)
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

	public int MaxUses;

	public int uses;

	public float explodeTimer;

	public float explodeCooldown;

	public DateTimeOffset LastExplosion;

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

	public IEnumerator SpawnSmoke(Vector3 position, int particleCount, float spawnRadius, float particleLifetime, float spawnInterval)
	{
		throw null;
	}

	private IEnumerator FadeAndDestroy(GameObject particle, SpriteRenderer renderer, float duration)
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

	public PyromaniacRole()
	{
		throw null;
	}
}
