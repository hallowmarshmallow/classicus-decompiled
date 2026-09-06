using System;
using System.Collections.Generic;

public static class ResourcesService
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		internal int _003C_002Ecctor_003Eb__3_0(ScriptableHero h)
		{
			return 0;
		}
	}

	private sealed class _003C_003Ec__DisplayClass4_0
	{
		public HeroType type;

		internal bool _003CGetHeroByType_003Eb__0(ScriptableHero h)
		{
			return false;
		}
	}

	private static readonly List<ScriptableHero> _003CHeroes_003Ek__BackingField;

	public static List<ScriptableHero> Heroes => _003CHeroes_003Ek__BackingField;

	static ResourcesService()
	{
	}

	public static ScriptableHero GetHeroByType(HeroType type)
	{
		return null;
	}
}
