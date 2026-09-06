using UnityEngine;

public class StowArms : Minigame
{
	public GameObject GunContent;

	public GameObject RifleContent;

	public Transform selectorObject;

	public GameObject[] selectorSubobjects;

	public SpriteRenderer[] handSprites;

	public AudioClip pickupGun;

	public AudioClip placeGun;

	public Collider2D[] GunColliders;

	public DragSlot[] GunsSlots;

	public AudioClip pickupRifle;

	public AudioClip placeRifle;

	public Collider2D[] RifleColliders;

	public DragSlot[] RifleSlots;

	private Controller cont;

	private Collider2D currentGrabbedObject;

	private Vector3 grabOffset;

	private AudioClip PickupSound
	{
		get
		{
			throw null;
		}
	}

	private AudioClip PlaceSound
	{
		get
		{
			throw null;
		}
	}

	public override void Begin(PlayerTask task)
	{
		throw null;
	}

	public void Update()
	{
		throw null;
	}

	private void DoUpdate(Collider2D[] colliders, DragSlot[] slots)
	{
		throw null;
	}

	private void CheckForWin(Collider2D[] colliders, DragSlot[] slots)
	{
		throw null;
	}

	public StowArms()
	{
		throw null;
	}
}
