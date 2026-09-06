using UnityEngine;

public class SubmergedWireMinigame : Minigame
{
	private static readonly Color[] DefaultColors;

	public Wire[] LeftNodes;

	public WireNode[] RightNodes;

	public SpriteRenderer[] LeftLights;

	public SpriteRenderer[] RightLights;

	public Sprite[] Symbols;

	public AudioClip[] WireSounds;

	private Controller myController;

	private sbyte[] ExpectedWires;

	private sbyte[] ActualWires;

	private sbyte[] RightOrder;

	private sbyte[] ExpectedConnections;

	private Color[] colors;

	private bool TaskIsForThisPanel()
	{
		return false;
	}

	public override void Begin(PlayerTask task)
	{
	}

	private Sprite GetSymbolSafe(int index)
	{
		return null;
	}

	private static void SetSymbolRecursive(Transform node, Sprite symbol)
	{
	}

	private void Update()
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

	private static void FillRandomRange(sbyte[] array)
	{
	}

	private static void ShuffleArray<T>(T[] array)
	{
	}
}
