using System;

public class RoleSettingMenu : SettingMenu
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Func<RoleBehaviour, bool> _003C_003E9__0_0;

		public static Func<RoleBehaviour, bool> _003C_003E9__0_1;

		public static Func<RoleBehaviour, bool> _003C_003E9__0_2;

		internal bool _003CSetupFromData_003Eb__0_0(RoleBehaviour r)
		{
			return false;
		}

		internal bool _003CSetupFromData_003Eb__0_1(RoleBehaviour r)
		{
			return false;
		}

		internal bool _003CSetupFromData_003Eb__0_2(RoleBehaviour r)
		{
			return false;
		}
	}

	public override void SetupFromData()
	{
	}
}
