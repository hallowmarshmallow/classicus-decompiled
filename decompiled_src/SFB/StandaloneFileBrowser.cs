using System;

namespace SFB;

public class StandaloneFileBrowser
{
	private static IStandaloneFileBrowser _platformWrapper;

	static StandaloneFileBrowser()
	{
		throw null;
	}

	public static void OpenFilePanelAsync(string title, string directory, ExtensionFilter[] extensions, bool multiselect, Action<string[]> cb)
	{
		throw null;
	}
}
