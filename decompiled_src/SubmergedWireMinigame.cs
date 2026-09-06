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
		throw null;
	}

	public override void Begin(PlayerTask task)
	{
		throw null;
	}

	private Sprite GetSymbolSafe(int index)
	{
		throw null;
	}

	private static void SetSymbolRecursive(Transform node, Sprite symbol)
	{
		throw null;
	}

	private void Update()
	{
		throw null;
	}

	private void UpdateLights()
	{
		throw null;
	}

	private WireNode CheckRightSide(Vector2 pos)
	{
		throw null;
	}

	private void CheckTask()
	{
		throw null;
	}

	private static void FillRandomRange(sbyte[] array)
	{
		throw null;
	}

	private static void ShuffleArray<T>(T[] array)
	{
		throw null;
	}

	public SubmergedWireMinigame()
	{
		throw null;
	}

	static SubmergedWireMinigame()
	{
		throw null;
	}
}
