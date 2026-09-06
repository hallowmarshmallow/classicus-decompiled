using System;

namespace StaffTools;

public sealed class AuditEntry
{
	public DateTime TimestampUtc;

	public string StaffName;

	public string StaffId;

	public string Command;

	public string Target;

	public ActionResult Result;

	public string Detail;

	public override string ToString()
	{
		throw null;
	}

	public AuditEntry()
	{
		throw null;
	}
}
