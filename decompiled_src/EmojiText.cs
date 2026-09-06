using System.Text.RegularExpressions;

public static class EmojiText
{
	private static readonly Regex SpriteTagRegex;

	private static readonly Regex RichTextTagRegex;

	public static bool IsPlaceholder(char c)
	{
		throw null;
	}

	public static char PlaceholderFor(int spriteIndex)
	{
		throw null;
	}

	public static string TagFor(int spriteIndex)
	{
		throw null;
	}

	public static string ToTags(string buffer)
	{
		throw null;
	}

	public static string StripToPlain(string s)
	{
		throw null;
	}

	public static string StripPrivateUse(string s)
	{
		throw null;
	}

	public static int CountSprites(string s)
	{
		throw null;
	}

	public static int EffectiveLength(string s)
	{
		throw null;
	}

	public static string TruncateEffective(string s, int maxVisible, string ellipsis)
	{
		throw null;
	}

	public static string SpliceCensored(string tagged, string censoredPlain)
	{
		throw null;
	}

	public static string ProtectForNoParse(string tagged)
	{
		throw null;
	}

	private static bool MatchStartsAt(MatchCollection matches, ref int cursor, int index, out Match match)
	{
		throw null;
	}

	private static bool TrySpriteTagAt(MatchCollection matches, ref int cursor, int index, out int length, out int spriteIndex)
	{
		throw null;
	}

	private static int ParseSpriteIndex(Match match)
	{
		throw null;
	}

	static EmojiText()
	{
		throw null;
	}
}
