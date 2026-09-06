using TMPro;
using UnityEngine;
using UnityEngine.UI;

public static class PracticeUiStyle
{
	private static TMP_FontAsset _arialFont;

	private static Material _uiMaterial;

	public static TMP_FontAsset ArialFont => null;

	public static Material UiMaterial => null;

	public static void ApplyArial(TMP_Text text)
	{
	}

	public static void ApplyUiMaterial(Graphic graphic)
	{
	}

	private static Shader ResolveUiShader()
	{
		return null;
	}

	private static bool IsUsable(Shader shader)
	{
		return false;
	}
}
