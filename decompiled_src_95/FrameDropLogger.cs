using System.Text;
using UnityEngine;

public class FrameDropLogger : MonoBehaviour
{
	private const float SPIKE_MULTIPLIER = 1.6f;

	private const float MIN_SPIKE_THRESHOLD = 0.005f;

	private const float AUDIT_INTERVAL = 10f;

	private const int WINDOW_SIZE = 120;

	private const float SPIKE_REPORT_COOLDOWN = 1f;

	private readonly float[] frameTimes;

	private int frameIndex;

	private bool windowFilled;

	private float lastSpikeReport;

	private float lastAuditTime;

	private long lastGcMemory;

	private int totalSpikeCount;

	private int gcSpikeCount;

	private readonly StringBuilder sb;

	private void Awake()
	{
	}

	private void Update()
	{
	}

	private static void AppendDDOLAudit(StringBuilder sb)
	{
	}

	private static GameObject[] GetDDOLRoots()
	{
		return null;
	}
}
