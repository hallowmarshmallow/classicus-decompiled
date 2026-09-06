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

		static _003C_003Ec()
		{
			throw null;
		}

		public _003C_003Ec()
		{
			throw null;
		}

		internal bool _003CGetPetByListId_003Eb__5_0(PetBehaviour p)
		{
			throw null;
		}

		internal bool _003CGetPetByListId_003Eb__5_1(PetBehaviour p)
		{
			throw null;
		}

		internal bool _003CGetPetById_003Eb__6_1(PetBehaviour p)
		{
			throw null;
		}

		internal bool _003CGetUnlockedPets_003Eb__8_0(PetBehaviour p)
		{
			throw null;
		}

		internal bool _003CGetUnlockedPets_003Eb__8_1(PetBehaviour p)
		{
			throw null;
		}

		internal bool _003CGetUnlockedHats_003Eb__12_0(HatBehaviour h)
		{
			throw null;
		}

		internal bool _003CGetUnlockedSkins_003Eb__14_0(SkinData s)
		{
			throw null;
		}

		internal bool _003CGetSkinById_003Eb__16_1(SkinData sk)
		{
			throw null;
		}
	}

	private sealed class _003C_003Ec__DisplayClass16_0
	{
		public string skinId;

		public _003C_003Ec__DisplayClass16_0()
		{
			throw null;
		}

		internal bool _003CGetSkinById_003Eb__0(SkinData sk)
		{
			throw null;
		}
	}

	private sealed class _003C_003Ec__DisplayClass6_0
	{
		public string petId;

		public _003C_003Ec__DisplayClass6_0()
		{
			throw null;
		}

		internal bool _003CGetPetById_003Eb__0(PetBehaviour p)
		{
			throw null;
		}
	}

	private sealed class _003C_003Ec__DisplayClass7_0
	{
		public PetBehaviour pet;

		public _003C_003Ec__DisplayClass7_0()
		{
			throw null;
		}

		internal bool _003CGetIdFromPet_003Eb__0(PetBehaviour p)
		{
			throw null;
		}
	}

	private sealed class _003C_003Ec__DisplayClass9_0
	{
		public string hatId;

		public _003C_003Ec__DisplayClass9_0()
		{
			throw null;
		}

		internal bool _003CGetHatByProdId_003Eb__0(HatBehaviour hat)
		{
			throw null;
		}
	}

	public HatBehaviour NoneHat;

	public List<PetBehaviour> AllPets;

	public List<HatBehaviour> AllHats;

	public List<SkinData> AllSkins;

	public override void Awake()
	{
		throw null;
	}

	internal PetBehaviour GetPetByListId(uint petId)
	{
		throw null;
	}

	internal PetBehaviour GetPetById(string petId)
	{
		throw null;
	}

	public uint GetIdFromPet(PetBehaviour pet)
	{
		throw null;
	}

	public PetBehaviour[] GetUnlockedPets()
	{
		throw null;
	}

	public HatBehaviour GetHatByProdId(string hatId)
	{
		throw null;
	}

	public static void AppplyHatOptions(string hatId, PlayerControl pc)
	{
		throw null;
	}

	public HatBehaviour GetHatById(uint hatId)
	{
		throw null;
	}

	public HatBehaviour[] GetUnlockedHats()
	{
		throw null;
	}

	public uint GetIdFromHat(HatBehaviour hat)
	{
		throw null;
	}

	public SkinData[] GetUnlockedSkins()
	{
		throw null;
	}

	public uint GetIdFromSkin(SkinData skin)
	{
		throw null;
	}

	internal SkinData GetSkinById(string skinId)
	{
		throw null;
	}

	internal void SetSkin(SpriteRenderer skinRend, string skinId)
	{
		throw null;
	}

	public HatManager()
	{
		throw null;
	}
}
