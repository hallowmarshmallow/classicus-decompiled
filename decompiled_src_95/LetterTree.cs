using System.Text;

public class LetterTree
{
	private enum NodeTypes : byte
	{
		NonTerm,
		Terminal,
		TerminalStrict,
		TerminalExact,
		TerminalUnbroken
	}

	private class LetterNode
	{
		public char Letter;

		public NodeTypes Terminal;

		public LetterNode[] Children;

		public LetterNode(char l)
		{
		}

		public LetterNode CreateChild(char l)
		{
			return null;
		}

		public LetterNode FindChild(char l)
		{
			return null;
		}

		public static int ToIndex(char c)
		{
			return 0;
		}
	}

	private LetterNode root;

	public void AddWord(string word)
	{
	}

	public static bool IsFiller(char l)
	{
		return false;
	}

	public int Search(StringBuilder input, int start)
	{
		return 0;
	}

	public int Search(string inputStr, int start)
	{
		return 0;
	}

	private int SubSearchRec(StringBuilder input, int start, LetterNode previous, bool postDupes, bool postBreak, bool exactStart)
	{
		return 0;
	}
}
