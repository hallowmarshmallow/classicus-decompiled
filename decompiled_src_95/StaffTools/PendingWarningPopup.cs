using System.Collections.Generic;
using UnityEngine;

namespace StaffTools;

public sealed class PendingWarningPopup : MonoBehaviour
{
	private static PendingWarningPopup _instance;

	private readonly List<PendingWarning> _warnings;

	private int _index;

	private GUIStyle _boxStyle;

	private GUIStyle _titleStyle;

	private GUIStyle _labelStyle;

	private GUIStyle _textStyle;

	private GUIStyle _buttonStyle;

	private bool _stylesReady;

	public static void ShowIfAny()
	{
	}

	private void EnsureStyles()
	{
	}

	private static Texture2D SolidTexture(Color color)
	{
		return null;
	}

	private void OnGUI()
	{
	}
}
