using System.Collections.Generic;

namespace StaffTools;

public interface IStaffStore
{
	StaffAccount GetById(string accountId);

	StaffAccount GetByUsername(string username);

	StaffAccount GetByHwidHash(string hwidHash);

	IEnumerable<StaffAccount> All();

	void Upsert(StaffAccount account);
}
