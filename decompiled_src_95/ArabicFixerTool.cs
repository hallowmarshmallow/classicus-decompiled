using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

internal class ArabicFixerTool
{
	[StructLayout((LayoutKind)3)]
	private struct _003C_003Ec__DisplayClass4_0
	{
		public int lastSplitIndex;
	}

	[StructLayout((LayoutKind)3)]
	private struct _003C_003Ec__DisplayClass6_0
	{
		public List<char> numberList;
	}

	internal static bool showTashkeel;

	internal static bool combineTashkeel;

	internal static bool useHinduNumbers;

	internal static StringBuilder internalStringBuilder;

	internal static void RemoveTashkeel(ref string str, out List<TashkeelLocation> tashkeelLocation)
	{
		tashkeelLocation = null;
	}

	internal static void ReturnTashkeel(ref char[] letters, List<TashkeelLocation> tashkeelLocation)
	{
	}

	internal static string FixLine(string str)
	{
		return null;
	}

	internal static bool NextToLatinOrDigit(char[] letters, int index, int innerDirection)
	{
		return false;
	}

	internal static ushort HandleInduNumber(ushort letterOrigin, ushort letterFinal)
	{
		return 0;
	}

	internal static bool IsIgnoredCharacter(char ch)
	{
		return false;
	}

	internal static bool IsLeadingLetter(char[] letters, int index)
	{
		return false;
	}

	internal static bool IsFinishingLetter(char[] letters, int index)
	{
		return false;
	}

	internal static bool IsMiddleLetter(char[] letters, int index)
	{
		return false;
	}

	internal static void _003CRemoveTashkeel_003Eg__IncrementSB_007C4_0(ref string str, int i, ref _003C_003Ec__DisplayClass4_0 P_2)
	{
	}

	internal static void _003CFixLine_003Eg__AddNumber_007C6_0(char value, ref _003C_003Ec__DisplayClass6_0 P_1)
	{
	}

	internal static void _003CFixLine_003Eg__AppendNumbers_007C6_1(ref _003C_003Ec__DisplayClass6_0 P_0)
	{
	}
}
