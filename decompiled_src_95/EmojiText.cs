using System.Text.RegularExpressions;

public static class EmojiText
{
	private static readonly Regex SpriteTagRegex;

	private static readonly Regex RichTextTagRegex;

	public static bool IsPlaceholder(char c)
	{
		return false;
	}

	public static char PlaceholderFor(int spriteIndex)
	{
		return '\0';
	}

	public static string TagFor(int spriteIndex)
	{
		return null;
	}

	public static string ToTags(string buffer)
	{
		return null;
	}

	public static string StripToPlain(string s)
	{
		return null;
	}

	public static string StripPrivateUse(string s)
	{
		return null;
	}

	public static int CountSprites(string s)
	{
		return 0;
	}

	public static int EffectiveLength(string s)
	{
		return 0;
	}

	public static string TruncateEffective(string s, int maxVisible, string ellipsis)
	{
		return null;
	}

	public static string SpliceCensored(string tagged, string censoredPlain)
	{
		return null;
	}

	public static string ProtectForNoParse(string tagged)
	{
		return null;
	}

	private static bool MatchStartsAt(MatchCollection matches, ref int cursor, int index, out Match match)
	{
		match = null;
		return false;
	}

	private static bool TrySpriteTagAt(MatchCollection matches, ref int cursor, int index, out int length, out int spriteIndex)
	{
		length = default(int);
		spriteIndex = default(int);
		return false;
	}

	private static int ParseSpriteIndex(Match match)
	{
		return 0;
	}
}
