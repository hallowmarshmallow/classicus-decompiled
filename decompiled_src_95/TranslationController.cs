using System;
using System.Collections.Generic;
using UnityEngine;

public class TranslationController : DestroyableSingleton<TranslationController>
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		internal StringNames _003C_002Ecctor_003Eb__7_0(SystemTypes t)
		{
			return default(StringNames);
		}

		internal StringNames _003C_002Ecctor_003Eb__7_1(TaskTypes t)
		{
			return default(StringNames);
		}
	}

	private static readonly StringNames[] SystemTypesToStringNames;

	private static readonly StringNames[] TaskTypesToStringNames;

	public List<TextAsset> Languages;

	public List<TranslatedImageSet> Images;

	public LanguageUnit CurrentLanguage;

	public LanguageUnit DefaultLanguage;

	public List<ITranslatedText> ActiveTexts;

	static TranslationController()
	{
	}

	public override void Awake()
	{
	}

	public void Initialize()
	{
	}

	public LanguageUnit CreateUnit(TextAsset contents)
	{
		return null;
	}

	public void SetLanguage(TextAsset lang)
	{
	}

	public Sprite GetImage(ImageNames id)
	{
		return null;
	}

	public string GetString(StringNames id, object[] parts)
	{
		return null;
	}

	public string GetStringWithDefault(StringNames id, string defaultStr, object[] parts)
	{
		return null;
	}

	public string GetString(SystemTypes room)
	{
		return null;
	}

	public string GetString(TaskTypes task)
	{
		return null;
	}

	public StringNames GetTaskName(TaskTypes task)
	{
		return default(StringNames);
	}

	public StringNames GetSystemName(SystemTypes room)
	{
		return default(StringNames);
	}

	internal static uint SelectDefaultLanguage()
	{
		return 0u;
	}
}
