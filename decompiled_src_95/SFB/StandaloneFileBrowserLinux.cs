using System;
using System.Runtime.InteropServices;

namespace SFB;

public class StandaloneFileBrowserLinux : IStandaloneFileBrowser
{
	public delegate void AsyncCallback(string path);

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static AsyncCallback _003C_003E9__16_0;

		internal void _003COpenFilePanelAsync_003Eb__16_0(string result)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass22_0
	{
		public Action<string[]> cb;

		internal void _003CTryExternalOpenFile_003Eb__0(string raw)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass23_0
	{
		public string exe;

		public string args;

		public Action<string> cb;

		internal void _003CRunPicker_003Eb__0()
		{
		}
	}

	private static Action<string[]> _openFileCb;

	private static readonly string[] ExternalPickers;

	private static string _externalPicker;

	private static bool _externalPickerResolved;

	[PreserveSig]
	private static extern void DialogInit();

	[PreserveSig]
	private static extern void DialogOpenFilePanelAsync(string title, string directory, string extension, bool multiselect, AsyncCallback callback);

	public void OpenFilePanelAsync(string title, string directory, ExtensionFilter[] extensions, bool multiselect, Action<string[]> cb)
	{
	}

	private static string FindExternalPicker()
	{
		return null;
	}

	private static bool TryExternalOpenFile(string title, string directory, ExtensionFilter[] extensions, bool multiselect, Action<string[]> cb)
	{
		return false;
	}

	private static bool RunPicker(string exe, string args, Action<string> cb)
	{
		return false;
	}

	private static string Quote(string value)
	{
		return null;
	}

	[PreserveSig]
	private static extern int LibcSystem(byte[] command);

	private static byte[] Utf8Z(string value)
	{
		return null;
	}

	private static string ShellQuote(string value)
	{
		return null;
	}

	private static string RunPickerViaLibc(string exe, string args)
	{
		return null;
	}

	private static string BuildZenityArgs(string title, string directory, ExtensionFilter[] extensions, bool multiselect)
	{
		return null;
	}

	private static string BuildKdialogArgs(string directory, ExtensionFilter[] extensions, bool multiselect)
	{
		return null;
	}

	private static string GetFilterFromFileExtensionList(ExtensionFilter[] extensions)
	{
		return null;
	}
}
