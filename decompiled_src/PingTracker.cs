using UnityEngine;

public class PingTracker : MonoBehaviour
{
	public TextRenderer text;

	public float zPosition;

	public GameObject WifiBar;

	public GameObject BadPing;

	public GameObject HorriblePing;

	public int badPingMs;

	public int horriblePingMs;

	public float noPacketsSeconds;

	private const int pingGreenMs = 120;

	private static readonly Color GoodColor;

	private static readonly Color WarnColor;

	private static readonly Color BadColor;

	private const string GoodHex = "#00FF00";

	private const string WarnHex = "#FFFF00";

	private const string BadHex = "#FF0000";

	private int frameCount;

	private float deltaTime;

	private float fps;

	private const float updateRate = 4f;

	private string _pingLabel;

	private string _pingLabelLang;

	private string _shapedLabel;

	private string _shapedLabelSource;

	private string _lastAssigned;

	private int _lastFpsShown;

	private int _lastPing;

	private string _lastCredits;

	private GameModes _lastMode;

	private string _lastLabel;

	private int _pingHexFor;

	private string _pingHex;

	private int _lastBytesGot;

	private float _lastTrafficTime;

	private bool _trafficTimeValid;

	private bool? _barWifi;

	private bool? _barBad;

	private bool? _barHorrible;

	private string GetPingLabel()
	{
		throw null;
	}

	private void LateUpdate()
	{
		throw null;
	}

	private void Update()
	{
		throw null;
	}

	private void Awake()
	{
		throw null;
	}

	private string GetShapedPingLabel()
	{
		throw null;
	}

	private static string ToHex(Color c)
	{
		throw null;
	}

	private string GetPingHex(int ping)
	{
		throw null;
	}

	private bool NoPackets(bool online)
	{
		throw null;
	}

	private void ApplyBars(bool wifi, bool bad, bool horrible)
	{
		throw null;
	}

	private void FixedUpdate()
	{
		throw null;
	}

	public PingTracker()
	{
		throw null;
	}

	static PingTracker()
	{
		throw null;
	}
}
