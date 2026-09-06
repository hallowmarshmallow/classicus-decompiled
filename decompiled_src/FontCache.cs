using System.Collections.Generic;
using UnityEngine;

public class FontCache : MonoBehaviour
{
	private sealed class _003C_003Ec__DisplayClass7_0
	{
		public TextAsset dataSrc;

		public _003C_003Ec__DisplayClass7_0()
		{
			throw null;
		}

		internal bool _003CLoadFont_003Eb__0(FontExtensionData ed)
		{
			throw null;
		}
	}

	public static FontCache Instance;

	private Dictionary<string, FontData> cache;

	public List<FontExtensionData> extraData;

	public List<TextAsset> DefaultFonts;

	public List<Material> DefaultFontMaterials;

	public void OnEnable()
	{
		throw null;
	}

	public void SetFont(TextRendererOld self, string name)
	{
		throw null;
	}

	public FontData LoadFont(TextAsset dataSrc)
	{
		throw null;
	}

	public static FontData LoadFontUncached(TextAsset dataSrc, FontExtensionData eData = null)
	{
		throw null;
	}

	public FontCache()
	{
		throw null;
	}
}
