namespace StaffTools;

public sealed class AuthResult
{
	public bool Ok;

	public string SessionToken;

	public string Error;

	public static AuthResult Fail(string error)
	{
		throw null;
	}

	public static AuthResult Success(string token)
	{
		throw null;
	}

	public AuthResult()
	{
		throw null;
	}
}
