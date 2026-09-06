using System.Collections.Generic;

namespace StaffTools;

public sealed class AltReport
{
	public bool PossibleAlt;

	public List<AltMatch> Matches;

	public string Warning => null;
}
