using System;
using System.Collections.Generic;

public class MopPuddlesTask : NormalPlayerTask
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Func<Console, bool> _003C_003E9__1_0;

		public static Func<Console, int> _003C_003E9__1_1;

		internal bool _003CInitialize_003Eb__1_0(Console c)
		{
			return false;
		}

		internal int _003CInitialize_003Eb__1_1(Console t)
		{
			return 0;
		}
	}

	public List<int> validConsoleIds;

	private void Awake()
	{
	}

	public override void Initialize()
	{
	}

	public override bool ValidConsole(Console console)
	{
		return false;
	}

	public new void UpdateArrow()
	{
	}

	private bool _003CInitialize_003Eb__1_2(Console c)
	{
		return false;
	}

	private bool _003CUpdateArrow_003Eb__3_0(Console c)
	{
		return false;
	}
}
