using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

public class TowelTask : NormalPlayerTask
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Func<byte, bool> _003C_003E9__0_1;

		public static Func<byte, bool> _003C_003E9__2_0;

		internal bool _003CValidConsole_003Eb__0_1(byte b)
		{
			return false;
		}

		internal bool _003CAppendTaskText_003Eb__2_0(byte b)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass0_0
	{
		public Console console;

		internal bool _003CValidConsole_003Eb__0(byte b)
		{
			return false;
		}
	}

	public override bool ValidConsole(Console console)
	{
		return false;
	}

	public override List<Vector2> GetLocations()
	{
		return null;
	}

	public override void AppendTaskText(StringBuilder sb)
	{
	}
}
