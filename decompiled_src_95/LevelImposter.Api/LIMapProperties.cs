using System;

namespace LevelImposter.Api;

[Serializable]
public class LIMapProperties
{
	private string _003CbgColor_003Ek__BackingField;

	private string _003CexileID_003Ek__BackingField;

	private bool? _003CshowPingIndicator_003Ek__BackingField;

	private bool? _003CpixelArtMode_003Ek__BackingField;

	private bool? _003CpreloadAllGIFs_003Ek__BackingField;

	private bool? _003CtriggerLogging_003Ek__BackingField;

	public bool? preloadAllGIFs => _003CpreloadAllGIFs_003Ek__BackingField;
}
