using System;
using System.Collections.Generic;
using UnityEngine;

public class HatManager : DestroyableSingleton<HatManager>
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Func<PetBehaviour, bool> _003C_003E9__5_0;

		public static Func<PetBehaviour, bool> _003C_003E9__5_1;

		public static Func<PetBehaviour, bool> _003C_003E9__6_1;

		public static Func<PetBehaviour, bool> _003C_003E9__8_0;

		public static Func<PetBehaviour, bool> _003C_003E9__8_1;

		public static Func<HatBehaviour, bool> _003C_003E9__12_0;

		public static Func<SkinData, bool> _003C_003E9__14_0;

		public static Func<SkinData, bool> _003C_003E9__16_1;

		internal bool _003CGetPetByListId_003Eb__5_0(PetBehaviour p)
		{
			return false;
		}

		internal bool _003CGetPetByListId_003Eb__5_1(PetBehaviour p)
		{
			return false;
		}

		internal bool _003CGetPetById_003Eb__6_1(PetBehaviour p)
		{
			return false;
		}

		internal bool _003CGetUnlockedPets_003Eb__8_0(PetBehaviour p)
		{
			return false;
		}

		internal bool _003CGetUnlockedPets_003Eb__8_1(PetBehaviour p)
		{
			return false;
		}

		internal bool _003CGetUnlockedHats_003Eb__12_0(HatBehaviour h)
		{
			return false;
		}

		internal bool _003CGetUnlockedSkins_003Eb__14_0(SkinData s)
		{
			return false;
		}

		internal bool _003CGetSkinById_003Eb__16_1(SkinData sk)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass16_0
	{
		public string skinId;

		internal bool _003CGetSkinById_003Eb__0(SkinData sk)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass6_0
	{
		public string petId;

		internal bool _003CGetPetById_003Eb__0(PetBehaviour p)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass7_0
	{
		public PetBehaviour pet;

		internal bool _003CGetIdFromPet_003Eb__0(PetBehaviour p)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass9_0
	{
		public string hatId;

		internal bool _003CGetHatByProdId_003Eb__0(HatBehaviour hat)
		{
			return false;
		}
	}

	public HatBehaviour NoneHat;

	public List<PetBehaviour> AllPets;

	public List<HatBehaviour> AllHats;

	public List<SkinData> AllSkins;

	public override void Awake()
	{
	}

	internal PetBehaviour GetPetByListId(uint petId)
	{
		return null;
	}

	internal PetBehaviour GetPetById(string petId)
	{
		return null;
	}

	public uint GetIdFromPet(PetBehaviour pet)
	{
		return 0u;
	}

	public PetBehaviour[] GetUnlockedPets()
	{
		return null;
	}

	public HatBehaviour GetHatByProdId(string hatId)
	{
		return null;
	}

	public static void AppplyHatOptions(string hatId, PlayerControl pc)
	{
	}

	public HatBehaviour GetHatById(uint hatId)
	{
		return null;
	}

	public HatBehaviour[] GetUnlockedHats()
	{
		return null;
	}

	public uint GetIdFromHat(HatBehaviour hat)
	{
		return 0u;
	}

	public SkinData[] GetUnlockedSkins()
	{
		return null;
	}

	public uint GetIdFromSkin(SkinData skin)
	{
		return 0u;
	}

	internal SkinData GetSkinById(string skinId)
	{
		return null;
	}

	internal void SetSkin(SpriteRenderer skinRend, string skinId)
	{
	}
}
