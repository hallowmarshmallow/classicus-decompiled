public static class ResolutionManager
{
	public delegate void ResolutionChangedHandler(float aspectRatio, int width, int height, bool fullscreen);

	private sealed class _003C_003Ec__DisplayClass4_0
	{
		public int width;

		public int height;

		public bool fullscreen;

		internal void _003CSetResolution_003Eb__0()
		{
		}
	}

	private static ResolutionChangedHandler m_ResolutionChanged;

	public static event ResolutionChangedHandler ResolutionChanged
	{
		add
		{
		}
		remove
		{
		}
	}

	public static void SetResolution(int width, int height, bool fullscreen)
	{
	}

	public static void ToggleFullscreen()
	{
	}
}
