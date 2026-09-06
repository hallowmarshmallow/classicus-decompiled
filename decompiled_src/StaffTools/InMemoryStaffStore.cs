using System.Collections.Generic;

namespace StaffTools;

public sealed class InMemoryStaffStore : IStaffStore
{
	private sealed class _003C_003Ec__DisplayClass2_0
	{
		public string username;

		public _003C_003Ec__DisplayClass2_0()
		{
			throw null;
		}

		internal bool _003CGetByUsername_003Eb__0(StaffAccount a)
		{
			throw null;
		}
	}

	private sealed class _003C_003Ec__DisplayClass3_0
	{
		public string hwidHash;

		public _003C_003Ec__DisplayClass3_0()
		{
			throw null;
		}

		internal bool _003CGetByHwidHash_003Eb__0(StaffAccount a)
		{
			throw null;
		}
	}

	private readonly Dictionary<string, StaffAccount> _byId;

	public StaffAccount GetById(string accountId)
	{
		throw null;
	}

	public StaffAccount GetByUsername(string username)
	{
		throw null;
	}

	public StaffAccount GetByHwidHash(string hwidHash)
	{
		throw null;
	}

	public IEnumerable<StaffAccount> All()
	{
		throw null;
	}

	public void Upsert(StaffAccount account)
	{
		throw null;
	}

	public InMemoryStaffStore()
	{
		throw null;
	}
}
