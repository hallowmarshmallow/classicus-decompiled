using System.Collections.Generic;
using System.Text;

public class FartTask : SabotageTask
{
	private const float ExplosionDuration = 10f;

	private const float SabotageCooldown = 20f;

	private bool isComplete;

	private bool explosionActive;

	private float explosionTimer;

	private bool even;

	private Dictionary<int, string> mapExplodedTranslations;

	public override int TaskStep => 0;

	public override bool IsComplete => false;

	public override void Initialize()
	{
	}

	private void FixedUpdate()
	{
	}

	private void StopExplosion()
	{
	}

	private SabotageSystemType GetSabotageSystem()
	{
		return null;
	}

	private void SetupTranslations()
	{
	}

	private string GetMapExplodedText()
	{
		return null;
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

	public override void AppendTaskText(StringBuilder sb)
	{
	}
}
