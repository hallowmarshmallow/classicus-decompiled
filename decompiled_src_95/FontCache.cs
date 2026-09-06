using System.Collections.Generic;
using UnityEngine;

public class FontCache : MonoBehaviour
{
	private sealed class _003C_003Ec__DisplayClass7_0
	{
		public TextAsset dataSrc;

		internal bool _003CLoadFont_003Eb__0(FontExtensionData ed)
		{
			return false;
		}
	}

	public static FontCache Instance;

	private Dictionary<string, FontData> cache;

	public List<FontExtensionData> extraData;

	public List<TextAsset> DefaultFonts;

	public List<Material> DefaultFontMaterials;

	public void OnEnable()
	{
	}

	public void SetFont(TextRendererOld self, string name)
	{
	}

	public FontData LoadFont(TextAsset dataSrc)
	{
		return null;
	}

	public static FontData LoadFontUncached(TextAsset dataSrc, FontExtensionData eData = null)
	{
		return null;
	}
}
