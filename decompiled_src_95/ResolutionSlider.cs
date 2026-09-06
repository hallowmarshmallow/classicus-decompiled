using System;
using TMPro;
using UnityEngine;

public class ResolutionSlider : MonoBehaviour
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Func<Resolution, bool> _003C_003E9__13_0;

		internal bool _003COnEnable_003Eb__13_0(Resolution r)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass13_0
	{
		public int savedWidth;

		public int savedHeight;

		internal bool _003COnEnable_003Eb__1(Resolution r)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass13_1
	{
		public Resolution cur;

		internal bool _003COnEnable_003Eb__2(Resolution r)
		{
			return false;
		}
	}

	private int targetIdx;

	private Resolution targetResolution;

	private bool targetFullscreen;

	private Resolution[] allResolutions;

	private MUQualitySettings.QualityPreset[] allQualityPresets;

	private MUQualitySettings.QualityPreset targetQualityPreset;

	public SlideBar slider;

	public SlideBar presetSlider;

	public ToggleButtonBehaviour Fullscreen;

	public ToggleButtonBehaviour VSync;

	public ToggleButtonBehaviour IgnoreScreenCutoffs;

	public TextMeshPro Display;

	public TextMeshPro PresetDisplay;

	public void OnEnable()
	{
	}

	public void ToggleVSync()
	{
	}

	public void ToggleIgnoreScreenCutoffs()
	{
	}

	public void ToggleFullscreen()
	{
	}

	public void OnResChange(SlideBar slider)
	{
	}

	public void OnPresetChange(SlideBar slider)
	{
	}

	public void SaveChange()
	{
	}
}
