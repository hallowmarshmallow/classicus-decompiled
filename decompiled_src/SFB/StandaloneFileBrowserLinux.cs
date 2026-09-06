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

		static _003C_003Ec()
		{
			throw null;
		}

		public _003C_003Ec()
		{
			throw null;
		}

		internal void _003COpenFilePanelAsync_003Eb__16_0(string result)
		{
			throw null;
		}
	}

	private sealed class _003C_003Ec__DisplayClass22_0
	{
		public Action<string[]> cb;

		public _003C_003Ec__DisplayClass22_0()
		{
			throw null;
		}

		internal void _003CTryExternalOpenFile_003Eb__0(string raw)
		{
			throw null;
		}
	}

	private sealed class _003C_003Ec__DisplayClass23_0
	{
		public string exe;

		public string args;

		public Action<string> cb;

		public _003C_003Ec__DisplayClass23_0()
		{
			throw null;
		}

		internal void _003CRunPicker_003Eb__0()
		{
			throw null;
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

	public StandaloneFileBrowserLinux()
	{
		throw null;
	}

	public void OpenFilePanelAsync(string title, string directory, ExtensionFilter[] extensions, bool multiselect, Action<string[]> cb)
	{
		throw null;
	}

	private static string FindExternalPicker()
	{
		throw null;
	}

	private static bool TryExternalOpenFile(string title, string directory, ExtensionFilter[] extensions, bool multiselect, Action<string[]> cb)
	{
		throw null;
	}

	private static bool RunPicker(string exe, string args, Action<string> cb)
	{
		throw null;
	}

	private static string Quote(string value)
	{
		throw null;
	}

	[PreserveSig]
	private static extern int LibcSystem(byte[] command);

	private static byte[] Utf8Z(string value)
	{
		throw null;
	}

	private static string ShellQuote(string value)
	{
		throw null;
	}

	private static string RunPickerViaLibc(string exe, string args)
	{
		throw null;
	}

	private static string BuildZenityArgs(string title, string directory, ExtensionFilter[] extensions, bool multiselect)
	{
		throw null;
	}

	private static string BuildKdialogArgs(string directory, ExtensionFilter[] extensions, bool multiselect)
	{
		throw null;
	}

	private static string GetFilterFromFileExtensionList(ExtensionFilter[] extensions)
	{
		throw null;
	}

	static StandaloneFileBrowserLinux()
	{
		throw null;
	}
}
