using System;

namespace SFB;

public interface IStandaloneFileBrowser
{
	void OpenFilePanelAsync(string title, string directory, ExtensionFilter[] extensions, bool multiselect, Action<string[]> cb);
}
