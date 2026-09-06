using System;
using System.Collections.Generic;

public static class RoleOptionsManager
{
	[Serializable]
	private class RoleOptionsWrapper
	{
		public List<JsonRoleData> JsonRoleData;

		public RoleOptionsWrapper()
		{
			throw null;
		}
	}

	[Serializable]
	public class JsonRoleOption
	{
		public string name;

		public float value;

		public JsonRoleOption(string Name, float Value)
		{
			throw null;
		}
	}

	[Serializable]
	public class JsonRoleData
	{
		public string name;

		public int chance;

		public List<JsonRoleOption> options;

		public JsonRoleData(string RoleName, int RoleChance, List<JsonRoleOption> RoleOptions)
		{
			throw null;
		}
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Func<RoleBehaviour, bool> _003C_003E9__5_0;

		static _003C_003Ec()
		{
			throw null;
		}

		public _003C_003Ec()
		{
			throw null;
		}

		internal bool _003CRoleToJSON_003Eb__5_0(RoleBehaviour r)
		{
			throw null;
		}
	}

	private sealed class _003C_003Ec__DisplayClass8_0
	{
		public JsonRoleData jsonRole;

		public _003C_003Ec__DisplayClass8_0()
		{
			throw null;
		}

		internal bool _003CReadJson_003Eb__0(RoleBehaviour role)
		{
			throw null;
		}
	}

	private sealed class _003C_003Ec__DisplayClass8_1
	{
		public KeyValuePair<string, RoleOption> option;

		public _003C_003Ec__DisplayClass8_1()
		{
			throw null;
		}

		internal bool _003CReadJson_003Eb__1(JsonRoleOption opt)
		{
			throw null;
		}
	}

	public static void ToJsonRAW(string json)
	{
		throw null;
	}

	public static string FromJsonRAW()
	{
		throw null;
	}

	public static string RoleToJSON()
	{
		throw null;
	}

	public static byte[] ToCompressedBytes(string json)
	{
		throw null;
	}

	public static string FromCompressedBytes(byte[] compressed)
	{
		throw null;
	}

	public static void ReadJson(string json)
	{
		throw null;
	}

	public static bool ValidOption(int chance, int minValue, int maxValue)
	{
		throw null;
	}
}
