using System.Text;

public class AirshipUploadTask : NormalPlayerTask
{
	public ArrowBehaviour[] Arrows;

	public override Minigame GetMinigamePrefab()
	{
		return null;
	}

	public override bool ValidConsole(Console console)
	{
		return false;
	}

	protected override void FixedUpdate()
	{
	}

	public override void UpdateArrowAndLocation()
	{
	}

	public override void AppendTaskText(StringBuilder sb)
	{
	}

	private bool _003CValidConsole_003Eb__2_0(TaskSet set)
	{
		return false;
	}
}
