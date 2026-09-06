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

	public override bool IsComplete => false;

	public override int TaskStep => 0;

	private void Awake()
	{
	}

	public void FixedUpdate()
	{
	}

	private void ResolveConsoles()
	{
	}

	public override void Initialize()
	{
	}

	public override bool ValidConsole(Console console)
	{
		return false;
	}

	public override void AppendTaskText(StringBuilder sb)
	{
	}

	public override void Complete()
	{
	}

	public override void OnRemove()
	{
	}
}
