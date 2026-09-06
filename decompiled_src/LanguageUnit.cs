using System.Collections.Generic;
using UnityEngine;

public class LanguageUnit
{
	public bool IsEnglish;

	public string langName;

	private Dictionary<StringNames, string> AllStrings;

	private Dictionary<ImageNames, Sprite> AllImages;

	public LanguageUnit(TextAsset data, ImageData[] images)
	{
		throw null;
	}

	public static string UnescapeCodes(string src)
	{
		throw null;
	}

	public string GetString(StringNames stringId, object[] parts)
	{
		throw null;
	}

	public Sprite GetImage(ImageNames id)
	{
		throw null;
	}
}
