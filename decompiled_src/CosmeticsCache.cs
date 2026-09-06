using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CosmeticsCache : MonoBehaviour
{
	private sealed class _003CCoClearUnusedCosmetics_003Ed__56 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		private float _003Cwaited_003E5__2;

		private int _003CtexBefore_003E5__3;

		private long _003CgfxBefore_003E5__4;

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

		public _003CCoClearUnusedCosmetics_003Ed__56(int _003C_003E1__state)
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

	private sealed class _003CCoWatchRound_003Ed__54 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CosmeticsCache _003C_003E4__this;

		private WaitForSecondsRealtime _003Cpoll_003E5__2;

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

		public _003CCoWatchRound_003Ed__54(int _003C_003E1__state)
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

	private const string Tag = "[CosmeticsCache]";

	private const bool EvictionEnabled = true;

	private const string PetResourceRoot = "Cosmetics/Pets/";

	private const string SkinResourceRoot = "Cosmetics/Skins/";

	private const float RoundPollSeconds = 1f;

	private const float HiddenWindowWaitSeconds = 15f;

	private const float SweepCooldownSeconds = 20f;

	private const string SweepOwner = "CosmeticsCache";

	private static readonly Dictionary<string, string> PetPathById;

	private static readonly Dictionary<string, string> SkinPathById;

	private static readonly Dictionary<string, int> PetSlotById;

	private static readonly Dictionary<string, int> SkinSlotById;

	private static readonly HashSet<string> EvictedPetIds;

	private static readonly HashSet<string> EvictedSkinIds;

	private static readonly string[] ProbeFailNames;

	private static CosmeticsCache _runner;

	private static HatManager _manager;

	private static string _catalogueOwner;

	private static int _catalogueEntries;

	private static int _catalogueVersion;

	private static int _probeFailShown;

	private static bool _catalogued;

	private static bool _disabled;

	private static bool _hardDisabled;

	private static bool _evictedThisRound;

	private static int _evictionCount;

	private static int _restoreCount;

	private static int _onDemandRestores;

	public static bool Initialized
	{
		get
		{
			throw null;
		}
	}

	public static bool Disabled
	{
		get
		{
			throw null;
		}
	}

	public static int RestorablePets
	{
		get
		{
			throw null;
		}
	}

	public static int RestorableSkins
	{
		get
		{
			throw null;
		}
	}

	public static bool AnythingEvicted
	{
		get
		{
			throw null;
		}
	}

	private static void Install()
	{
		throw null;
	}

	public static void RegisterCatalogue(HatManager manager)
	{
		throw null;
	}

	private static string Describe(HatManager manager)
	{
		throw null;
	}

	private static string FailTail(int failed)
	{
		throw null;
	}

	private static void NoteProbeFailure(string name)
	{
		throw null;
	}

	private static void DropCatalogue(string reason)
	{
		throw null;
	}

	private static int ProbePets(HatManager manager)
	{
		throw null;
	}

	private static int ProbeSkins(HatManager manager)
	{
		throw null;
	}

	private static void EnsureRunner()
	{
		throw null;
	}

	private static void OnSceneLoaded(Scene scene, LoadSceneMode mode)
	{
		throw null;
	}

	public static void RestoreAll(string reason)
	{
		throw null;
	}

	public static PetBehaviour ResolvePet(string productId)
	{
		throw null;
	}

	public static SkinData ResolveSkin(string productId)
	{
		throw null;
	}

	private static PetBehaviour RestorePetSlot(HatManager manager, string productId)
	{
		throw null;
	}

	private static SkinData RestoreSkinSlot(HatManager manager, string productId)
	{
		throw null;
	}

	private static HatManager LiveManager()
	{
		throw null;
	}

	private IEnumerator CoWatchRound()
	{
		throw null;
	}

	public static void ClearUnusedCosmetics()
	{
		throw null;
	}

	private IEnumerator CoClearUnusedCosmetics()
	{
		throw null;
	}

	private static bool TryBuildInUseSets(out HashSet<string> keepPets, out HashSet<string> keepSkins)
	{
		throw null;
	}

	private static void Add(HashSet<string> set, string id)
	{
		throw null;
	}

	private static int EvictPets(HatManager manager, HashSet<string> keep)
	{
		throw null;
	}

	private static int EvictSkins(HatManager manager, HashSet<string> keep)
	{
		throw null;
	}

	public static string Snapshot()
	{
		throw null;
	}

	public CosmeticsCache()
	{
		throw null;
	}

	static CosmeticsCache()
	{
		throw null;
	}
}
