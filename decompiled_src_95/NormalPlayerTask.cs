using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

public class NormalPlayerTask : PlayerTask
{
	public enum TimerState
	{
		NotStarted,
		Started,
		Finished
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Func<Console, bool> _003C_003E9__13_0;

		public static Func<Console, bool> _003C_003E9__15_0;

		public static Func<Console, bool> _003C_003E9__15_1;

		public static Func<TaskTypes, bool> _003C_003E9__21_1;

		public static Predicate<byte> _003C_003E9__21_5;

		internal bool _003CInitialize_003Eb__13_0(Console t)
		{
			return false;
		}

		internal bool _003CUpdateArrow_003Eb__15_0(Console c)
		{
			return false;
		}

		internal bool _003CUpdateArrow_003Eb__15_1(Console console)
		{
			return false;
		}

		internal bool _003CValidConsole_003Eb__21_1(TaskTypes tt)
		{
			return false;
		}

		internal bool _003CValidConsole_003Eb__21_5(byte b)
		{
			return false;
		}
	}

	public int taskStep;

	public int MaxStep;

	public bool ShowTaskStep;

	public bool ShowTaskTimer;

	public TimerState TimerStarted;

	public float TaskTimer;

	public byte[] Data;

	public ArrowBehaviour Arrow;

	protected bool arrowSuspended;

	public override int TaskStep => 0;

	public override bool IsComplete => false;

	public override void Initialize()
	{
	}

	public void NextStep()
	{
	}

	public void UpdateArrow()
	{
	}

	protected override Console FindObjectPos()
	{
		return null;
	}

	protected virtual void FixedUpdate()
	{
	}

	public virtual void UpdateArrowAndLocation()
	{
	}

	protected List<Vector2> FindValidConsolesPositions()
	{
		return null;
	}

	public override bool ValidConsole(Console console)
	{
		return false;
	}

	public override void Complete()
	{
	}

	public override void AppendTaskText(StringBuilder sb)
	{
	}

	private bool ShouldYellowText()
	{
		return false;
	}

	private bool _003CInitialize_003Eb__13_1(Console v)
	{
		return false;
	}

	private bool _003CUpdateArrow_003Eb__15_2(Console c)
	{
		return false;
	}

	private bool _003CValidConsole_003Eb__21_0(TaskSet set)
	{
		return false;
	}

	private bool _003CValidConsole_003Eb__21_2(TaskSet set)
	{
		return false;
	}

	private bool _003CValidConsole_003Eb__21_3(TaskTypes tt)
	{
		return false;
	}

	private bool _003CValidConsole_003Eb__21_4(TaskSet set)
	{
		return false;
	}
}
