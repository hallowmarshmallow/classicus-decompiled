using UnityEngine;

public class AirshipGarbageGame : Minigame
{
	public GarbageCanBehaviour[] GarbagePrefabs;

	public Sprite RelaxeHandle;

	public Sprite PulledHandle;

	private GarbageCanBehaviour can;

	public AudioClip grabSound;

	public Controller controller;

	public Transform handCursorObject;

	public GameObject waitingHands;

	public GameObject grabbedHands;

	public SpriteRenderer[] handSprites;

	private bool prevHadLeftInput;

	private const float stickVelocityMagnitude = 6f;

	public override void Begin(PlayerTask task)
	{
		throw null;
	}

	private void Update()
	{
		throw null;
	}

	public AirshipGarbageGame()
	{
		throw null;
	}
}
