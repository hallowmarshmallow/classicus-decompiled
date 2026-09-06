using System.Collections.Generic;
using UnityEngine;

public class FontExtensionData : ScriptableObject
{
	public string FontName;

	public List<KerningPair> kernings;

	public List<OffsetAdjustment> Offsets;

	public void AdjustKernings(FontData target)
	{
		throw null;
	}

	public void AdjustOffsets(FontData target)
	{
		throw null;
	}

	public FontExtensionData()
	{
		throw null;
	}
}
