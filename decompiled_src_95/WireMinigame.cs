using UnityEngine;

public class WireMinigame : Minigame
{
	private static readonly Color[] AllColors;

	public Sprite[] Symbols;

	public Wire[] LeftNodes;

	public WireNode[] RightNodes;

	public SpriteRenderer[] LeftLights;

	public SpriteRenderer[] RightLights;

	private Controller myController;

	private sbyte[] ExpectedWires;

	private sbyte[] ActualWires;

	private sbyte[] RightOrder;

	private sbyte[] ExpectedConnections;

	public AudioClip[] WireSounds;

	private int GetWireCount()
	{
		return 0;
	}

	private bool TaskIsForThisPanel()
	{
		return false;
	}

	public override void Begin(PlayerTask task)
	{
	}

	private static Color[] BuildShuffledColors(int count)
	{
		return null;
	}

	private Sprite GetSymbolSafe(int colorIndex)
	{
		return null;
	}

	private static void SetSymbolRecursive(Transform node, Sprite symbol)
	{
	}

	public void Update()
	{
	}

	private void UpdateLights()
	{
	}

	private WireNode CheckRightSide(Vector2 pos)
	{
		return null;
	}

	private void CheckTask()
	{
	}
}
