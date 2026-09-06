using System;
using System.Collections.Generic;

public static class RoleOptionsManager
{
	[Serializable]
	private class RoleOptionsWrapper
	{
		public List<JsonRoleData> JsonRoleData;
	}

	[Serializable]
	public class JsonRoleOption
	{
		public string name;

		public float value;

		public JsonRoleOption(string Name, float Value)
		{
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
		}
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Func<RoleBehaviour, bool> _003C_003E9__5_0;

		internal bool _003CRoleToJSON_003Eb__5_0(RoleBehaviour r)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass8_0
	{
		public JsonRoleData jsonRole;

		internal bool _003CReadJson_003Eb__0(RoleBehaviour role)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass8_1
	{
		public KeyValuePair<string, RoleOption> option;

		internal bool _003CReadJson_003Eb__1(JsonRoleOption opt)
		{
			return false;
		}
	}

	public static void ToJsonRAW(string json)
	{
	}

	public static string FromJsonRAW()
	{
		return null;
	}

	public static string RoleToJSON()
	{
		return null;
	}

	public static byte[] ToCompressedBytes(string json)
	{
		return null;
	}

	public static string FromCompressedBytes(byte[] compressed)
	{
		return null;
	}

	public static void ReadJson(string json)
	{
	}

	public static bool ValidOption(int chance, int minValue, int maxValue)
	{
		return false;
	}
}
