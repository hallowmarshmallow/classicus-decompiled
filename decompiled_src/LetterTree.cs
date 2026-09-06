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
			throw null;
		}

		public LetterNode CreateChild(char l)
		{
			throw null;
		}

		public LetterNode FindChild(char l)
		{
			throw null;
		}

		public static int ToIndex(char c)
		{
			throw null;
		}
	}

	private LetterNode root;

	public void AddWord(string word)
	{
		throw null;
	}

	public static bool IsFiller(char l)
	{
		throw null;
	}

	public int Search(StringBuilder input, int start)
	{
		throw null;
	}

	public int Search(string inputStr, int start)
	{
		throw null;
	}

	private int SubSearchRec(StringBuilder input, int start, LetterNode previous, bool postDupes, bool postBreak, bool exactStart)
	{
		throw null;
	}

	public LetterTree()
	{
		throw null;
	}
}
