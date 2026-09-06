using System;
using System.Collections.Generic;
using UnityEngine;

public class TranslationController : DestroyableSingleton<TranslationController>
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		static _003C_003Ec()
		{
			throw null;
		}

		public _003C_003Ec()
		{
			throw null;
		}

		internal StringNames _003C_002Ecctor_003Eb__7_0(SystemTypes t)
		{
			throw null;
		}

		internal StringNames _003C_002Ecctor_003Eb__7_1(TaskTypes t)
		{
			throw null;
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
		throw null;
	}

	public override void Awake()
	{
		throw null;
	}

	public void Initialize()
	{
		throw null;
	}

	public LanguageUnit CreateUnit(TextAsset contents)
	{
		throw null;
	}

	public void SetLanguage(TextAsset lang)
	{
		throw null;
	}

	public Sprite GetImage(ImageNames id)
	{
		throw null;
	}

	public string GetString(StringNames id, object[] parts)
	{
		throw null;
	}

	public string GetStringWithDefault(StringNames id, string defaultStr, object[] parts)
	{
		throw null;
	}

	public string GetString(SystemTypes room)
	{
		throw null;
	}

	public string GetString(TaskTypes task)
	{
		throw null;
	}

	public StringNames GetTaskName(TaskTypes task)
	{
		throw null;
	}

	public StringNames GetSystemName(SystemTypes room)
	{
		throw null;
	}

	internal static uint SelectDefaultLanguage()
	{
		throw null;
	}

	public TranslationController()
	{
		throw null;
	}
}
