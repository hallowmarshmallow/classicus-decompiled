using UnityEngine;

namespace Comms.Modules.Voice.Ui;

public sealed class VoiceDebugGui : MonoBehaviour
{
	private const float AreaX = 12f;

	private const float AreaY = 52f;

	private const float AreaWidth = 390f;

	private const float MaxAreaHeight = 690f;

	private Vector2 _panelScroll;

	private Vector2 _microphoneScroll;

	private bool show;

	private void Update()
	{
	}

	private void OnDisable()
	{
	}

	private void OnGUI()
	{
	}

	private static string YesNo(bool value)
	{
		return null;
	}

	private static Rect GetArea()
	{
		return default(Rect);
	}

	private static void DrawMicrophoneList(VoiceSettings settings)
	{
	}

	private static void SelectDefaultMicrophone()
	{
	}

	private static void SelectRelativeMicrophone(int direction)
	{
	}

	private static string Compact(string value)
	{
		return null;
	}
}
