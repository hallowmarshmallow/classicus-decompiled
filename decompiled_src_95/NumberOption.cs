using TMPro;

public class NumberOption : OptionBehaviour
{
	public TextMeshPro TitleText;

	public TextMeshPro ValueText;

	public float Value;

	private float oldValue;

	public float Increment;

	public FloatRange ValidRange;

	public string FormatString;

	public bool ZeroIsInfinity;

	private bool ignoreText;

	private static readonly string[] RunnerDisabledMapNames;

	private void EnableStepperHold()
	{
	}

	public void OnEnableManual()
	{
	}

	private void FixedUpdate()
	{
	}

	public void Increase()
	{
	}

	public void Decrease()
	{
	}

	private static float SkipRunnerDisabledMaps(float value, int direction)
	{
		return 0f;
	}

	public override float GetFloat()
	{
		return 0f;
	}

	public override int GetInt()
	{
		return 0;
	}
}
