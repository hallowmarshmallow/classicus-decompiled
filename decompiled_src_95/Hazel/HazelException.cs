using System;

namespace Hazel;

[Serializable]
public class HazelException : Exception
{
	internal HazelException(string msg)
	{
	}

	internal HazelException(string msg, Exception e)
	{
	}
}
