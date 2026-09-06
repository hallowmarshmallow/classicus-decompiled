using System.Collections.Generic;

namespace StaffTools;

public sealed class AuditLog
{
	private readonly string _path;

	private readonly int _memoryCapacity;

	private readonly LinkedList<AuditEntry> _recent;

	private readonly object _gate;

	public AuditLog(string path, int memoryCapacity = 1000)
	{
		throw null;
	}

	public void Record(AuditEntry entry)
	{
		throw null;
	}

	public IReadOnlyList<AuditEntry> Recent(int count)
	{
		throw null;
	}

	public IReadOnlyList<AuditEntry> ForTarget(string target, int count)
	{
		throw null;
	}

	private void Append(AuditEntry entry)
	{
		throw null;
	}
}
