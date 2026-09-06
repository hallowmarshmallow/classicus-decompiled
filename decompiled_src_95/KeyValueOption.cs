using System.Collections.Generic;

public class KeyValueOption : OptionBehaviour
{
	public TextRenderer TitleText;

	public TextRendererOld ValueText;

	public List<KeyValuePair<string, int>> Values;

	private int Selected;

	private int oldValue;

	public void Start()
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

	public override int GetInt()
	{
		return 0;
	}
}
