using UnityEngine;

public class SpecimenGame : Minigame
{
	public Collider2D[] Specimens;

	public Transform[] Slots;

	private Controller cont;

	public AudioClip[] PlaceSounds;

	private SpriteRenderer[] SpecimenSprites;

	public Color highlightColor;

	private bool completed;

	private bool prevHadStick;

	private bool prevHadButton;

	private int prevSelectedSpecimen;

	private int selectedSpecimen;

	public override void Begin(PlayerTask task)
	{
		throw null;
	}

	public void Update()
	{
		throw null;
	}

	private void CheckForWin()
	{
		throw null;
	}

	public SpecimenGame()
	{
		throw null;
	}
}
