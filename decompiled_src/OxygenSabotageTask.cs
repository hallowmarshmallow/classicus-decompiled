using System.Text;
using UnityEngine;

public class OxygenSabotageTask : PlayerTask
{
	public bool isComplete;

	public bool taskTextYellow;

	public ArrowBehaviour[] arrows;

	public SubmarineOxygenSystem system;

	private Console upperConsole;

	private Console lowerConsole;

	private bool consolesResolved;

	private float nextConsoleRescan;

	private AudioClip originalSabotageSound;

	public override bool IsComplete
	{
		get
		{
			throw null;
		}
	}

	public override int TaskStep
	{
		get
		{
			throw null;
		}
	}

	private void Awake()
	{
		throw null;
	}

	public void FixedUpdate()
	{
		throw null;
	}

	private void ResolveConsoles()
	{
		throw null;
	}

	public override void Initialize()
	{
		throw null;
	}

	public override bool ValidConsole(Console console)
	{
		throw null;
	}

	public override void AppendTaskText(StringBuilder sb)
	{
		throw null;
	}

	public override void Complete()
	{
		throw null;
	}

	public override void OnRemove()
	{
		throw null;
	}

	public OxygenSabotageTask()
	{
		throw null;
	}
}
