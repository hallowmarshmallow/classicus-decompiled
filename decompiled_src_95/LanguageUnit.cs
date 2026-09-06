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
	}

	public static string UnescapeCodes(string src)
	{
		return null;
	}

	public string GetString(StringNames stringId, object[] parts)
	{
		return null;
	}

	public Sprite GetImage(ImageNames id)
	{
		return null;
	}
}
