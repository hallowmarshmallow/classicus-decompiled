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

		static _003C_003Ec()
		{
			throw null;
		}

		public _003C_003Ec()
		{
			throw null;
		}

		internal bool _003COnEnable_003Eb__13_0(Resolution r)
		{
			throw null;
		}
	}

	private sealed class _003C_003Ec__DisplayClass13_0
	{
		public int savedWidth;

		public int savedHeight;

		public _003C_003Ec__DisplayClass13_0()
		{
			throw null;
		}

		internal bool _003COnEnable_003Eb__1(Resolution r)
		{
			throw null;
		}
	}

	private sealed class _003C_003Ec__DisplayClass13_1
	{
		public Resolution cur;

		public _003C_003Ec__DisplayClass13_1()
		{
			throw null;
		}

		internal bool _003COnEnable_003Eb__2(Resolution r)
		{
			throw null;
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
		throw null;
	}

	public void ToggleVSync()
	{
		throw null;
	}

	public void ToggleIgnoreScreenCutoffs()
	{
		throw null;
	}

	public void ToggleFullscreen()
	{
		throw null;
	}

	public void OnResChange(SlideBar slider)
	{
		throw null;
	}

	public void OnPresetChange(SlideBar slider)
	{
		throw null;
	}

	public void SaveChange()
	{
		throw null;
	}

	public ResolutionSlider()
	{
		throw null;
	}
}
