using System;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class RandomNameGenerator : DestroyableSingleton<RandomNameGenerator>
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Func<string, bool> _003C_003E9__9_0;

		internal bool _003CParse_003Eb__9_0(string w)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass6_0
	{
		public Pattern pattern;

		internal bool _003CGetName_003Eb__0(Pattern p)
		{
			return false;
		}
	}

	public TextAsset PatternConfig;

	private List<Pattern> Patterns;

	private Dictionary<string, WordGroup> WordGroups;

	private static System.Random randy;

	private IEnumerable<Pattern> UsablePatterns;

	public override void Awake()
	{
	}

	public string GetName()
	{
		return null;
	}

	public bool ValidateName(string inName)
	{
		return false;
	}

	public void Reset()
	{
	}

	public void Parse(TextReader reader)
	{
	}
}
