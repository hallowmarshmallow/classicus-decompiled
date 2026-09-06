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

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CCoClearUnusedCosmetics_003Ed__56(int _003C_003E1__state)
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

	private sealed class _003CCoWatchRound_003Ed__54 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CosmeticsCache _003C_003E4__this;

		private WaitForSecondsRealtime _003Cpoll_003E5__2;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CCoWatchRound_003Ed__54(int _003C_003E1__state)
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

	public static bool Initialized => false;

	public static bool Disabled => false;

	public static int RestorablePets => 0;

	public static int RestorableSkins => 0;

	public static bool AnythingEvicted => false;

	private static void Install()
	{
	}

	public static void RegisterCatalogue(HatManager manager)
	{
	}

	private static string Describe(HatManager manager)
	{
		return null;
	}

	private static string FailTail(int failed)
	{
		return null;
	}

	private static void NoteProbeFailure(string name)
	{
	}

	private static void DropCatalogue(string reason)
	{
	}

	private static int ProbePets(HatManager manager)
	{
		return 0;
	}

	private static int ProbeSkins(HatManager manager)
	{
		return 0;
	}

	private static void EnsureRunner()
	{
	}

	private static void OnSceneLoaded(Scene scene, LoadSceneMode mode)
	{
	}

	public static void RestoreAll(string reason)
	{
	}

	public static PetBehaviour ResolvePet(string productId)
	{
		return null;
	}

	public static SkinData ResolveSkin(string productId)
	{
		return null;
	}

	private static PetBehaviour RestorePetSlot(HatManager manager, string productId)
	{
		return null;
	}

	private static SkinData RestoreSkinSlot(HatManager manager, string productId)
	{
		return null;
	}

	private static HatManager LiveManager()
	{
		return null;
	}

	private IEnumerator CoWatchRound()
	{
		return null;
	}

	public static void ClearUnusedCosmetics()
	{
	}

	private IEnumerator CoClearUnusedCosmetics()
	{
		return null;
	}

	private static bool TryBuildInUseSets(out HashSet<string> keepPets, out HashSet<string> keepSkins)
	{
		keepPets = null;
		keepSkins = null;
		return false;
	}

	private static void Add(HashSet<string> set, string id)
	{
	}

	private static int EvictPets(HatManager manager, HashSet<string> keep)
	{
		return 0;
	}

	private static int EvictSkins(HatManager manager, HashSet<string> keep)
	{
		return 0;
	}

	public static string Snapshot()
	{
		return null;
	}
}
