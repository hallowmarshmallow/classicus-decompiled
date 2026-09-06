using System.Text;

public class DivertPowerTask : NormalPlayerTask
{
	public SystemTypes TargetSystem;

	public override bool ValidConsole(Console console)
	{
		return false;
	}

	public override void AppendTaskText(StringBuilder sb)
	{
	}

	private bool _003CValidConsole_003Eb__1_0(TaskSet set)
	{
		return false;
	}
}
