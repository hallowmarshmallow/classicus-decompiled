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

	private void FixedUpdate()
	{
		throw null;
	}

	private void StopExplosion()
	{
		throw null;
	}

	private SabotageSystemType GetSabotageSystem()
	{
		throw null;
	}

	private void SetupTranslations()
	{
		throw null;
	}

	private string GetMapExplodedText()
	{
		throw null;
	}

	public override bool ValidConsole(Console console)
	{
		throw null;
	}

	public override void OnRemove()
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

	public FartTask()
	{
		throw null;
	}
}
