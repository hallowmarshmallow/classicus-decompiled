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
		throw null;
	}

	private bool TaskIsForThisPanel()
	{
		throw null;
	}

	public override void Begin(PlayerTask task)
	{
		throw null;
	}

	private static Color[] BuildShuffledColors(int count)
	{
		throw null;
	}

	private Sprite GetSymbolSafe(int colorIndex)
	{
		throw null;
	}

	private static void SetSymbolRecursive(Transform node, Sprite symbol)
	{
		throw null;
	}

	public void Update()
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

	public WireMinigame()
	{
		throw null;
	}

	static WireMinigame()
	{
		throw null;
	}
}
