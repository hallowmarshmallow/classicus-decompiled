using UnityEngine;
using UnityEngine.Events;

public class RandomEventTrigger : MonoBehaviour
{
	private const string LOG_TAG = "[RandomEventTrigger]";

	public float chancePercent;

	public bool rollOnStart;

	public GameObject[] objectsToEnable;

	public GameObject[] objectsToDisable;

	public bool enableBounce;

	public float bounceHeight;

	public float bounceDuration;

	public bool enableRainbow;

	public float rainbowSpeed;

	public float rainbowSaturation;

	public bool enableCameraBeat;

	public float beatBPM;

	public float beatBounceStrength;

	public float beatSmoothSpeed;

	public string originalMusicChannelName;

	public AudioClip replacementMusic;

	public string replacementMusicName;

	public float replacementMusicVolume;

	public string[] menuScenes;

	public bool neverStopTheParty;

	public UnityEvent onSuccess;

	public UnityEvent onFail;

	private bool lastRollSucceeded;

	private SpriteRenderer cachedRenderer;

	private Vector3 bounceOrigin;

	private bool isActive;

	private void Awake()
	{
		throw null;
	}

	private void Start()
	{
		throw null;
	}

	public void RollChance()
	{
		throw null;
	}

	public void ForceResult(bool success)
	{
		throw null;
	}

	private void ApplyResult(bool success)
	{
		throw null;
	}

	private void Update()
	{
		throw null;
	}

	private void SpawnPersistence()
	{
		throw null;
	}

	private void UpdateBounce()
	{
		throw null;
	}

	private void UpdateRainbow()
	{
		throw null;
	}

	private static void SetObjectsActive(GameObject[] objects, bool active)
	{
		throw null;
	}

	public RandomEventTrigger()
	{
		throw null;
	}
}
