public static class ResolutionManager
{
	public delegate void ResolutionChangedHandler(float aspectRatio, int width, int height, bool fullscreen);

	private sealed class _003C_003Ec__DisplayClass4_0
	{
		public int width;

		public int height;

		public bool fullscreen;

		public _003C_003Ec__DisplayClass4_0()
		{
			throw null;
		}

		internal void _003CSetResolution_003Eb__0()
		{
			throw null;
		}
	}

	private static ResolutionChangedHandler m_ResolutionChanged;

	public static event ResolutionChangedHandler ResolutionChanged
	{
		add
		{
			throw null;
		}
		remove
		{
			throw null;
		}
	}

	public static void SetResolution(int width, int height, bool fullscreen)
	{
		throw null;
	}

	public static void ToggleFullscreen()
	{
		throw null;
	}
}
