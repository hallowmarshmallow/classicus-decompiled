using System.Collections.Generic;

namespace StaffTools;

public sealed class JsonFileStaffStore : IStaffStore
{
	private sealed class _003C_003Ec__DisplayClass5_0
	{
		public string username;

		internal bool _003CGetByUsername_003Eb__0(StaffAccount a)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass6_0
	{
		public string hwidHash;

		internal bool _003CGetByHwidHash_003Eb__0(StaffAccount a)
		{
			return false;
		}
	}

	private readonly string _path;

	private readonly Dictionary<string, StaffAccount> _byId;

	private readonly object _gate;

	public JsonFileStaffStore(string path)
	{
	}

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

	private void Load()
	{
	}

	private void Save()
	{
	}
}
