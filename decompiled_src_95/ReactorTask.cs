using System.Text;
using UnityEngine;

public class ReactorTask : SabotageTask
{
	private bool isComplete;

	private ReactorSystemType reactor;

	private bool even;

	private AudioClip originalSabotageSound;

	public override int TaskStep => 0;

	public override bool IsComplete => false;

	public override void Initialize()
	{
	}

	private void FixedUpdate()
	{
	}

	public override bool ValidConsole(Console console)
	{
		return false;
	}

	public override void OnRemove()
	{
	}

	public override void Complete()
	{
	}

	private string SabotageLabel()
	{
		return null;
	}

	public override void AppendTaskText(StringBuilder sb)
	{
	}

	private bool _003CInitialize_003Eb__8_0(ShipRoom r)
	{
		return false;
	}
}
