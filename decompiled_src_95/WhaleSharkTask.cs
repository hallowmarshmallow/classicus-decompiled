using System.Text;

public class WhaleSharkTask : NormalPlayerTask
{
	public bool visible;

	public float timer;

	public float visibleDuration;

	public float notVisibleDuration;

	public static bool CanComplete(PlayerControl player)
	{
		return false;
	}

	private void Start()
	{
	}

	public new void FixedUpdate()
	{
	}

	public override void AppendTaskText(StringBuilder sb)
	{
	}
}
