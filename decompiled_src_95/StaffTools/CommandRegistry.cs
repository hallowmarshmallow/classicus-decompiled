using System;
using System.Collections.Generic;

namespace StaffTools;

public sealed class CommandRegistry
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Func<CommandContext, CommandResult> _003C_003E9__10_0;

		public static Func<GamePlayer, string> _003C_003E9__12_9;

		public static Func<CommandContext, CommandResult> _003C_003E9__12_0;

		public static Func<GamePlayer, bool> _003C_003E9__12_10;

		public static Func<GamePlayer, string> _003C_003E9__12_11;

		public static Func<CommandContext, CommandResult> _003C_003E9__12_1;

		public static Func<CommandContext, CommandResult> _003C_003E9__12_2;

		public static Func<CommandContext, CommandResult> _003C_003E9__12_3;

		public static Func<AltMatch, string> _003C_003E9__12_12;

		public static Func<CommandContext, CommandResult> _003C_003E9__12_4;

		public static Func<AuditEntry, string> _003C_003E9__12_13;

		public static Func<CommandContext, CommandResult> _003C_003E9__12_5;

		public static Func<AuditEntry, string> _003C_003E9__12_14;

		public static Func<CommandContext, CommandResult> _003C_003E9__12_6;

		public static Func<CommandContext, CommandResult> _003C_003E9__12_7;

		public static Func<CommandContext, CommandResult> _003C_003E9__12_8;

		public static Func<CommandContext, CommandResult> _003C_003E9__13_0;

		public static Func<CommandContext, CommandResult> _003C_003E9__13_1;

		public static Func<CommandContext, CommandResult> _003C_003E9__13_2;

		public static Func<CommandContext, CommandResult> _003C_003E9__13_3;

		public static Action<StaffAccount> _003C_003E9__13_19;

		public static Func<CommandContext, CommandResult> _003C_003E9__13_4;

		public static Action<StaffAccount> _003C_003E9__13_20;

		public static Func<CommandContext, CommandResult> _003C_003E9__13_5;

		public static Func<AltMatch, string> _003C_003E9__13_21;

		public static Func<AuditEntry, string> _003C_003E9__13_22;

		public static Func<CommandContext, CommandResult> _003C_003E9__13_6;

		public static Func<StaffAccount, bool> _003C_003E9__13_23;

		public static Func<StaffAccount, string> _003C_003E9__13_24;

		public static Func<CommandContext, CommandResult> _003C_003E9__13_7;

		public static Func<CommandContext, CommandResult> _003C_003E9__13_8;

		public static Func<CommandContext, CommandResult> _003C_003E9__13_9;

		public static Action<StaffAccount> _003C_003E9__13_25;

		public static Func<CommandContext, CommandResult> _003C_003E9__13_10;

		public static Func<CommandContext, CommandResult> _003C_003E9__13_11;

		public static Func<CommandContext, CommandResult> _003C_003E9__13_12;

		public static Action<StaffAccount> _003C_003E9__13_28;

		public static Func<CommandContext, CommandResult> _003C_003E9__13_13;

		public static Action<StaffAccount> _003C_003E9__13_29;

		public static Func<CommandContext, CommandResult> _003C_003E9__13_14;

		public static Func<CommandContext, CommandResult> _003C_003E9__15_0;

		public static Func<CommandContext, CommandResult> _003C_003E9__15_1;

		public static Func<CommandContext, CommandResult> _003C_003E9__15_2;

		public static Func<CommandContext, CommandResult> _003C_003E9__15_3;

		public static Func<CommandContext, CommandResult> _003C_003E9__15_4;

		public static Func<CommandContext, CommandResult> _003C_003E9__15_5;

		public static Func<CommandContext, CommandResult> _003C_003E9__19_0;

		public static Func<CommandContext, CommandResult> _003C_003E9__19_1;

		public static Func<CommandContext, CommandResult> _003C_003E9__19_2;

		public static Func<CommandContext, CommandResult> _003C_003E9__19_3;

		public static Func<CommandContext, CommandResult> _003C_003E9__19_4;

		public static Func<CommandContext, CommandResult> _003C_003E9__19_5;

		public static Func<CommandContext, CommandResult> _003C_003E9__19_6;

		internal CommandResult _003CRegisterModerator_003Eb__10_0(CommandContext ctx)
		{
			return null;
		}

		internal CommandResult _003CRegisterInfoDebug_003Eb__12_0(CommandContext ctx)
		{
			return null;
		}

		internal string _003CRegisterInfoDebug_003Eb__12_9(GamePlayer p)
		{
			return null;
		}

		internal CommandResult _003CRegisterInfoDebug_003Eb__12_1(CommandContext ctx)
		{
			return null;
		}

		internal bool _003CRegisterInfoDebug_003Eb__12_10(GamePlayer p)
		{
			return false;
		}

		internal string _003CRegisterInfoDebug_003Eb__12_11(GamePlayer p)
		{
			return null;
		}

		internal CommandResult _003CRegisterInfoDebug_003Eb__12_2(CommandContext ctx)
		{
			return null;
		}

		internal CommandResult _003CRegisterInfoDebug_003Eb__12_3(CommandContext ctx)
		{
			return null;
		}

		internal CommandResult _003CRegisterInfoDebug_003Eb__12_4(CommandContext ctx)
		{
			return null;
		}

		internal string _003CRegisterInfoDebug_003Eb__12_12(AltMatch m)
		{
			return null;
		}

		internal CommandResult _003CRegisterInfoDebug_003Eb__12_5(CommandContext ctx)
		{
			return null;
		}

		internal string _003CRegisterInfoDebug_003Eb__12_13(AuditEntry e)
		{
			return null;
		}

		internal CommandResult _003CRegisterInfoDebug_003Eb__12_6(CommandContext ctx)
		{
			return null;
		}

		internal string _003CRegisterInfoDebug_003Eb__12_14(AuditEntry e)
		{
			return null;
		}

		internal CommandResult _003CRegisterInfoDebug_003Eb__12_7(CommandContext ctx)
		{
			return null;
		}

		internal CommandResult _003CRegisterInfoDebug_003Eb__12_8(CommandContext ctx)
		{
			return null;
		}

		internal CommandResult _003CRegisterAccountSecurity_003Eb__13_0(CommandContext ctx)
		{
			return null;
		}

		internal CommandResult _003CRegisterAccountSecurity_003Eb__13_1(CommandContext ctx)
		{
			return null;
		}

		internal CommandResult _003CRegisterAccountSecurity_003Eb__13_2(CommandContext ctx)
		{
			return null;
		}

		internal CommandResult _003CRegisterAccountSecurity_003Eb__13_3(CommandContext ctx)
		{
			return null;
		}

		internal CommandResult _003CRegisterAccountSecurity_003Eb__13_4(CommandContext ctx)
		{
			return null;
		}

		internal void _003CRegisterAccountSecurity_003Eb__13_19(StaffAccount a)
		{
		}

		internal CommandResult _003CRegisterAccountSecurity_003Eb__13_5(CommandContext ctx)
		{
			return null;
		}

		internal void _003CRegisterAccountSecurity_003Eb__13_20(StaffAccount a)
		{
		}

		internal CommandResult _003CRegisterAccountSecurity_003Eb__13_6(CommandContext ctx)
		{
			return null;
		}

		internal string _003CRegisterAccountSecurity_003Eb__13_21(AltMatch m)
		{
			return null;
		}

		internal string _003CRegisterAccountSecurity_003Eb__13_22(AuditEntry e)
		{
			return null;
		}

		internal CommandResult _003CRegisterAccountSecurity_003Eb__13_7(CommandContext ctx)
		{
			return null;
		}

		internal bool _003CRegisterAccountSecurity_003Eb__13_23(StaffAccount a)
		{
			return false;
		}

		internal string _003CRegisterAccountSecurity_003Eb__13_24(StaffAccount a)
		{
			return null;
		}

		internal CommandResult _003CRegisterAccountSecurity_003Eb__13_8(CommandContext ctx)
		{
			return null;
		}

		internal CommandResult _003CRegisterAccountSecurity_003Eb__13_9(CommandContext ctx)
		{
			return null;
		}

		internal CommandResult _003CRegisterAccountSecurity_003Eb__13_10(CommandContext ctx)
		{
			return null;
		}

		internal void _003CRegisterAccountSecurity_003Eb__13_25(StaffAccount a)
		{
		}

		internal CommandResult _003CRegisterAccountSecurity_003Eb__13_11(CommandContext ctx)
		{
			return null;
		}

		internal CommandResult _003CRegisterAccountSecurity_003Eb__13_12(CommandContext ctx)
		{
			return null;
		}

		internal CommandResult _003CRegisterAccountSecurity_003Eb__13_13(CommandContext ctx)
		{
			return null;
		}

		internal void _003CRegisterAccountSecurity_003Eb__13_28(StaffAccount a)
		{
		}

		internal CommandResult _003CRegisterAccountSecurity_003Eb__13_14(CommandContext ctx)
		{
			return null;
		}

		internal void _003CRegisterAccountSecurity_003Eb__13_29(StaffAccount a)
		{
		}

		internal CommandResult _003CRegisterServerLobby_003Eb__15_0(CommandContext ctx)
		{
			return null;
		}

		internal CommandResult _003CRegisterServerLobby_003Eb__15_1(CommandContext ctx)
		{
			return null;
		}

		internal CommandResult _003CRegisterServerLobby_003Eb__15_2(CommandContext ctx)
		{
			return null;
		}

		internal CommandResult _003CRegisterServerLobby_003Eb__15_3(CommandContext ctx)
		{
			return null;
		}

		internal CommandResult _003CRegisterServerLobby_003Eb__15_4(CommandContext ctx)
		{
			return null;
		}

		internal CommandResult _003CRegisterServerLobby_003Eb__15_5(CommandContext ctx)
		{
			return null;
		}

		internal CommandResult _003CRegisterTrollCommands_003Eb__19_0(CommandContext ctx)
		{
			return null;
		}

		internal CommandResult _003CRegisterTrollCommands_003Eb__19_1(CommandContext ctx)
		{
			return null;
		}

		internal CommandResult _003CRegisterTrollCommands_003Eb__19_2(CommandContext ctx)
		{
			return null;
		}

		internal CommandResult _003CRegisterTrollCommands_003Eb__19_3(CommandContext ctx)
		{
			return null;
		}

		internal CommandResult _003CRegisterTrollCommands_003Eb__19_4(CommandContext ctx)
		{
			return null;
		}

		internal CommandResult _003CRegisterTrollCommands_003Eb__19_5(CommandContext ctx)
		{
			return null;
		}

		internal CommandResult _003CRegisterTrollCommands_003Eb__19_6(CommandContext ctx)
		{
			return null;
		}
	}

	private sealed class _003C_003Ec__DisplayClass13_0
	{
		public CommandContext ctx;

		internal void _003CRegisterAccountSecurity_003Eb__15(StaffAccount a)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass13_1
	{
		public CommandContext ctx;

		internal void _003CRegisterAccountSecurity_003Eb__16(StaffAccount a)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass13_2
	{
		public CommandContext ctx;

		internal void _003CRegisterAccountSecurity_003Eb__17(StaffAccount a)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass13_3
	{
		public CommandContext ctx;

		internal void _003CRegisterAccountSecurity_003Eb__18(StaffAccount a)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass13_4
	{
		public CommandContext ctx;

		internal void _003CRegisterAccountSecurity_003Eb__26(StaffAccount a)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass13_5
	{
		public CommandContext ctx;

		internal void _003CRegisterAccountSecurity_003Eb__27(StaffAccount a)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass6_0
	{
		public GameAction action;

		internal CommandResult _003CG_003Eb__0(CommandContext ctx)
		{
			return null;
		}
	}

	private readonly Dictionary<string, CommandDescriptor> _commands;

	public IEnumerable<CommandDescriptor> All => null;

	public CommandDescriptor Find(string name)
	{
		return null;
	}

	private void Add(string name, StaffRole min, Func<CommandContext, CommandResult> handler, string usage, string desc, bool critical = false, int cooldownSec = 0)
	{
	}

	private void G(string name, StaffRole min, GameAction action, string usage, string desc, bool critical = false, int cooldownSec = 0)
	{
	}

	private static CommandResult RunGame(CommandContext ctx, GameAction action)
	{
		return null;
	}

	private static StaffAccount ResolveAccount(CommandContext ctx)
	{
		return null;
	}

	private static CommandResult RequireTarget(CommandContext ctx)
	{
		return null;
	}

	private void RegisterModerator()
	{
	}

	private void RegisterPlayerManagement()
	{
	}

	private void RegisterInfoDebug()
	{
	}

	private void RegisterAccountSecurity()
	{
	}

	private static CommandResult AccountMutate(CommandContext ctx, Action<StaffAccount> mutate, string ok)
	{
		return null;
	}

	private void RegisterServerLobby()
	{
	}

	private void RegisterTestUtilities()
	{
	}

	private void RegisterFun()
	{
	}

	private void RegisterDevPowerTools()
	{
	}

	private void RegisterTrollCommands()
	{
	}

	private static string FormatAccount(StaffAccount acc, StaffRole viewer, StaffServices svc)
	{
		return null;
	}
}
