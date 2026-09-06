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

		static _003C_003Ec()
		{
			throw null;
		}

		public _003C_003Ec()
		{
			throw null;
		}

		internal bool _003CParse_003Eb__9_0(string w)
		{
			throw null;
		}
	}

	private sealed class _003C_003Ec__DisplayClass6_0
	{
		public Pattern pattern;

		public _003C_003Ec__DisplayClass6_0()
		{
			throw null;
		}

		internal bool _003CGetName_003Eb__0(Pattern p)
		{
			throw null;
		}
	}

	public TextAsset PatternConfig;

	private List<Pattern> Patterns;

	private Dictionary<string, WordGroup> WordGroups;

	private static System.Random randy;

	private IEnumerable<Pattern> UsablePatterns;

	public override void Awake()
	{
		throw null;
	}

	public string GetName()
	{
		throw null;
	}

	public bool ValidateName(string inName)
	{
		throw null;
	}

	public void Reset()
	{
		throw null;
	}

	public void Parse(TextReader reader)
	{
		throw null;
	}

	public RandomNameGenerator()
	{
		throw null;
	}

	static RandomNameGenerator()
	{
		throw null;
	}
}
