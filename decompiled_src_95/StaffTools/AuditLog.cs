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
	}

	public void Record(AuditEntry entry)
	{
	}

	public IReadOnlyList<AuditEntry> Recent(int count)
	{
		return null;
	}

	public IReadOnlyList<AuditEntry> ForTarget(string target, int count)
	{
		return null;
	}

	private void Append(AuditEntry entry)
	{
	}
}
