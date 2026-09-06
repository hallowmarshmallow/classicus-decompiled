namespace KlassicHideNSeek;

internal static class HnSPhaseText
{
	internal enum Key
	{
		HiderRole,
		SeekerRole,
		EscapePhase,
		HuntPhase,
		FinalHuntPhase,
		EscapeHider,
		EscapeSeeker,
		HuntSeeker,
		HuntHider,
		FinalHuntSeeker,
		FinalHuntHider,
		Proximity,
		LobbyBanner,
		PositionRevealed,
		CaughtPopup
	}

	private static readonly string[] HiderRole;

	private static readonly string[] SeekerRole;

	private static readonly string[] EscapePhase;

	private static readonly string[] HuntPhase;

	private static readonly string[] FinalHuntPhase;

	private static readonly string[] EscapeHider;

	private static readonly string[] EscapeSeeker;

	private static readonly string[] HuntSeeker;

	private static readonly string[] HuntHider;

	private static readonly string[] FinalHuntSeeker;

	private static readonly string[] FinalHuntHider;

	private static string[] Table(Key key)
	{
		throw null;
	}

	private static string EnglishDefault(Key key)
	{
		throw null;
	}

	private static string ArabicOnly(Key key)
	{
		throw null;
	}

	private static int CurrentLangIndex()
	{
		throw null;
	}

	internal static string Get(Key key, string englishOverride)
	{
		throw null;
	}

	static HnSPhaseText()
	{
		throw null;
	}
}
