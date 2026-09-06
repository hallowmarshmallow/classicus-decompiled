using System.Collections.Generic;
using System.Threading.Tasks;

public interface ISaveClient
{
	Task Save(string key, object value);

	Task<T> Load<T>(string key);

	Task<IEnumerable<T>> Load<T>(string[] keys);

	Task Delete(string key);
}
