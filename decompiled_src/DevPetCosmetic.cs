using System;
using System.Collections;
using System.Collections.Generic;
using Hazel;
using UnityEngine;

public class DevPetCosmetic : MonoBehaviour
{
	private sealed class _003C_003Ec__DisplayClass28_0
	{
		public PlayerControl target;

		public _003C_003Ec__DisplayClass28_0()
		{
			throw null;
		}

		internal void _003CTryWaterShuriken_003Eb__0()
		{
			throw null;
		}
	}

	private sealed class _003CExpandingRing_003Ed__46 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Color color;

		public Vector3 center;

		private GameObject _003Cgo_003E5__2;

		private LineRenderer _003Clr_003E5__3;

		private float _003Ct_003E5__4;

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

		public _003CExpandingRing_003Ed__46(int _003C_003E1__state)
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

	private sealed class _003CPulseScale_003Ed__43 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Transform t;

		public float duration;

		public float peakMultiplier;

		private Vector3 _003CbaseScale_003E5__2;

		private float _003Chalf_003E5__3;

		private float _003Celapsed_003E5__4;

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

		public _003CPulseScale_003Ed__43(int _003C_003E1__state)
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

	private sealed class _003CThrowShuriken_003Ed__45 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Color color;

		public Vector3 from;

		public Vector3 to;

		public Action onHit;

		private GameObject _003Cgo_003E5__2;

		private float _003Ct_003E5__3;

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

		public _003CThrowShuriken_003Ed__45(int _003C_003E1__state)
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

	private sealed class _003CTintFlash_003Ed__44 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SpriteRenderer sr;

		public float duration;

		public Color flashColor;

		private Color _003CbaseColor_003E5__2;

		private float _003Celapsed_003E5__3;

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

		public _003CTintFlash_003Ed__44(int _003C_003E1__state)
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

	public const string ProductId = "pet_dev_greninja";

	private static bool _003CLocalIsDev_003Ek__BackingField;

	private const string DisplayName = "Greninja";

	private const string FramesFolder = "DevPet";

	private const int FrameCount = 119;

	private const float PixelsPerUnit = 150f;

	private const float SizeMultiplier = 2.3f;

	private const float SecondsPerFrame = 0.03f;

	private const string Pepper = "classicus-staff";

	private const float AbilityRange = 3f;

	private const float KillMoveCooldown = 2f;

	private const float VfxMoveCooldown = 0.5f;

	private static readonly string[] DevHwidHashes;

	private static readonly Vector3 ParkPosition;

	private static DevPetCosmetic _instance;

	private static PetBehaviour _template;

	private bool _resolved;

	private bool _isDev;

	private float _nextCheck;

	private float _nextAbilityAt;

	private const byte PetTransformRpc = 96;

	private const float TransformSizeMultiplier = 1.6f;

	private const string TransformChildName = "DevPetTransformSprite";

	private static readonly HashSet<byte> _transformedPlayers;

	private bool _localTransformed;

	private static Sprite _dotSprite;

	public static bool LocalIsDev
	{
		get
		{
			throw null;
		}
		private set
		{
			throw null;
		}
	}

	private static void Bootstrap()
	{
		throw null;
	}

	private void Update()
	{
		throw null;
	}

	private void HandleAbilityHotkeys()
	{
		throw null;
	}

	private void TryPet()
	{
		throw null;
	}

	private void TryBattleBond()
	{
		throw null;
	}

	private void TryWaterShuriken()
	{
		throw null;
	}

	private void TryHydroPump()
	{
		throw null;
	}

	private void TryDarkPulse()
	{
		throw null;
	}

	private void ToggleSelfTransform(PlayerControl me)
	{
		throw null;
	}

	private static void BroadcastPetTransform(PlayerControl me, bool on)
	{
		throw null;
	}

	public static void HandlePetTransformRpc(MessageReader reader)
	{
		throw null;
	}

	private static void ApplyPetTransform(PlayerControl pc, bool on)
	{
		throw null;
	}

	private static Sprite[] GetSharedFrames()
	{
		throw null;
	}

	private static void KillPlayer(PlayerControl target)
	{
		throw null;
	}

	private static PlayerControl FindNearestAlivePlayer(Vector3 origin, PlayerControl exclude)
	{
		throw null;
	}

	private static IEnumerator PulseScale(Transform t, float peakMultiplier, float duration)
	{
		throw null;
	}

	private static IEnumerator TintFlash(SpriteRenderer sr, Color flashColor, float duration)
	{
		throw null;
	}

	private static IEnumerator ThrowShuriken(Vector3 from, Vector3 to, Color color, Action onHit)
	{
		throw null;
	}

	private static IEnumerator ExpandingRing(Vector3 center, Color color)
	{
		throw null;
	}

	private static void SpawnBurst(Vector3 position, Color color, float radius, int count)
	{
		throw null;
	}

	private static Sprite MakeDotSprite()
	{
		throw null;
	}

	private static bool ResolveIsDev()
	{
		throw null;
	}

	private void EnsureRegistered()
	{
		throw null;
	}

	private static PetBehaviour BuildTemplate()
	{
		throw null;
	}

	private static Sprite[] LoadFrames()
	{
		throw null;
	}

	public DevPetCosmetic()
	{
		throw null;
	}

	static DevPetCosmetic()
	{
		throw null;
	}
}
