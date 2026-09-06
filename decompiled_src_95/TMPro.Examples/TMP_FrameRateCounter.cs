using UnityEngine;

namespace TMPro.Examples;

public class TMP_FrameRateCounter : MonoBehaviour
{
	public enum FpsCounterAnchorPositions
	{
		TopLeft,
		BottomLeft,
		TopRight,
		BottomRight
	}

	public float UpdateInterval;

	private float m_LastInterval;

	private int m_Frames;

	public FpsCounterAnchorPositions AnchorPosition;

	private string htmlColorTag;

	private const string fpsLabel = "{0:2}</color> <#8080ff>FPS \n<#FF8000>{1:2} <#8080ff>MS";

	private TextMeshPro m_TextMeshPro;

	private Transform m_frameCounter_transform;

	private Camera m_camera;

	private FpsCounterAnchorPositions last_AnchorPosition;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void Set_FrameCounter_Position(FpsCounterAnchorPositions anchor_position)
	{
	}
}
