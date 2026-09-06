using System.Collections.Generic;
using UnityEngine;

public class ColorParser : MonoBehaviour
{
	public static bool TryParseColors(string colorString, out List<Color> colors)
	{
		colors = null;
		return false;
	}

	public static bool TryParseColor(string colorString, out Color color)
	{
		color = default(Color);
		return false;
	}

	public static string ToString(List<Color> colors)
	{
		return null;
	}

	private static string ColorToString(Color color)
	{
		return null;
	}
}
