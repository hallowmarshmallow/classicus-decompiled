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

		static _003C_003Ec()
		{
			throw null;
		}

		public _003C_003Ec()
		{
			throw null;
		}

		internal bool _003CInitialize_003Eb__13_0(Console t)
		{
			throw null;
		}

		internal bool _003CUpdateArrow_003Eb__15_0(Console c)
		{
			throw null;
		}

		internal bool _003CUpdateArrow_003Eb__15_1(Console console)
		{
			throw null;
		}

		internal bool _003CValidConsole_003Eb__21_1(TaskTypes tt)
		{
			throw null;
		}

		internal bool _003CValidConsole_003Eb__21_5(byte b)
		{
			throw null;
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

	public override int TaskStep
	{
		get
		{
			throw null;
		}
	}

	public override bool IsComplete
	{
		get
		{
			throw null;
		}
	}

	public override void Initialize()
	{
		throw null;
	}

	public void NextStep()
	{
		throw null;
	}

	public void UpdateArrow()
	{
		throw null;
	}

	protected override Console FindObjectPos()
	{
		throw null;
	}

	protected virtual void FixedUpdate()
	{
		throw null;
	}

	public virtual void UpdateArrowAndLocation()
	{
		throw null;
	}

	protected List<Vector2> FindValidConsolesPositions()
	{
		throw null;
	}

	public override bool ValidConsole(Console console)
	{
		throw null;
	}

	public override void Complete()
	{
		throw null;
	}

	public override void AppendTaskText(StringBuilder sb)
	{
		throw null;
	}

	private bool ShouldYellowText()
	{
		throw null;
	}

	public NormalPlayerTask()
	{
		throw null;
	}

	private bool _003CInitialize_003Eb__13_1(Console v)
	{
		throw null;
	}

	private bool _003CUpdateArrow_003Eb__15_2(Console c)
	{
		throw null;
	}

	private bool _003CValidConsole_003Eb__21_0(TaskSet set)
	{
		throw null;
	}

	private bool _003CValidConsole_003Eb__21_2(TaskSet set)
	{
		throw null;
	}

	private bool _003CValidConsole_003Eb__21_3(TaskTypes tt)
	{
		throw null;
	}

	private bool _003CValidConsole_003Eb__21_4(TaskSet set)
	{
		throw null;
	}
}
