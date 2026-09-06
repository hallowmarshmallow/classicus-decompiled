using System;

namespace Hazel;

[Serializable]
public class HazelException : Exception
{
	internal HazelException(string msg)
	{
		throw null;
	}

	internal HazelException(string msg, Exception e)
	{
		throw null;
	}
}
