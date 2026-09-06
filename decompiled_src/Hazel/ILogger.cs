namespace Hazel;

public interface ILogger
{
	void WriteError(string msg);

	void WriteInfo(string msg);
}
