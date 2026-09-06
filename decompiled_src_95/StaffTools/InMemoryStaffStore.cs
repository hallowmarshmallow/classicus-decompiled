using System.Collections.Generic;

namespace StaffTools;

public sealed class InMemoryStaffStore : IStaffStore
{
	private sealed class _003C_003Ec__DisplayClass2_0
	{
		public string username;

		internal bool _003CGetByUsername_003Eb__0(StaffAccount a)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass3_0
	{
		public string hwidHash;

		internal bool _003CGetByHwidHash_003Eb__0(StaffAccount a)
		{
			return false;
		}
	}

	private readonly Dictionary<string, StaffAccount> _byId;

	public StaffAccount GetById(string accountId)
	{
		return null;
	}

	public StaffAccount GetByUsername(string username)
	{
		return null;
	}

	public StaffAccount GetByHwidHash(string hwidHash)
	{
		return null;
	}

	public IEnumerable<StaffAccount> All()
	{
		return null;
	}

	public void Upsert(StaffAccount account)
	{
	}
}
