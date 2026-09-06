using System.Collections.Generic;

namespace StaffTools;

public sealed class JsonFileStaffStore : IStaffStore
{
	private sealed class _003C_003Ec__DisplayClass5_0
	{
		public string username;

		public _003C_003Ec__DisplayClass5_0()
		{
			throw null;
		}

		internal bool _003CGetByUsername_003Eb__0(StaffAccount a)
		{
			throw null;
		}
	}

	private sealed class _003C_003Ec__DisplayClass6_0
	{
		public string hwidHash;

		public _003C_003Ec__DisplayClass6_0()
		{
			throw null;
		}

		internal bool _003CGetByHwidHash_003Eb__0(StaffAccount a)
		{
			throw null;
		}
	}

	private readonly string _path;

	private readonly Dictionary<string, StaffAccount> _byId;

	private readonly object _gate;

	public JsonFileStaffStore(string path)
	{
		throw null;
	}

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

	private void Load()
	{
		throw null;
	}

	private void Save()
	{
		throw null;
	}
}
