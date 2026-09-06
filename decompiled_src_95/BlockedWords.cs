using System.Collections.Generic;

public static class BlockedWords
{
	public static readonly HashSet<char> SymbolChars;

	private static readonly LetterTree SkipList;

	public static readonly string[] AllWords;

	static BlockedWords()
	{
	}

	public static bool ContainsWord(string chatText)
	{
		return false;
	}

	public static string CensorWords(string chatText)
	{
		return null;
	}
}
