using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class FPSLider : MonoBehaviour
{
	private static readonly float[] FpsLadder;

	private static readonly List<FPSLider> Live;

	private int targetIdx;

	private float targetResolution;

	public float[] allFps;

	public SlideBar slider;

	public TextMeshPro Display;

	public static int DisplayHz => 0;

	public static void RefreshAll()
	{
	}

	private static float[] BuildOptions()
	{
		return null;
	}

	public void OnEnable()
	{
	}

	public void OnDisable()
	{
	}

	private void Rebuild()
	{
	}

	public void OnResChange(SlideBar slider)
	{
	}

	public void SaveChange()
	{
	}
}
