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

		static _003C_003Ec()
		{
			throw null;
		}

		public _003C_003Ec()
		{
			throw null;
		}

		internal CommandResult _003CRegisterModerator_003Eb__10_0(CommandContext ctx)
		{
			throw null;
		}

		internal CommandResult _003CRegisterInfoDebug_003Eb__12_0(CommandContext ctx)
		{
			throw null;
		}

		internal string _003CRegisterInfoDebug_003Eb__12_9(GamePlayer p)
		{
			throw null;
		}

		internal CommandResult _003CRegisterInfoDebug_003Eb__12_1(CommandContext ctx)
		{
			throw null;
		}

		internal bool _003CRegisterInfoDebug_003Eb__12_10(GamePlayer p)
		{
			throw null;
		}

		internal string _003CRegisterInfoDebug_003Eb__12_11(GamePlayer p)
		{
			throw null;
		}

		internal CommandResult _003CRegisterInfoDebug_003Eb__12_2(CommandContext ctx)
		{
			throw null;
		}

		internal CommandResult _003CRegisterInfoDebug_003Eb__12_3(CommandContext ctx)
		{
			throw null;
		}

		internal CommandResult _003CRegisterInfoDebug_003Eb__12_4(CommandContext ctx)
		{
			throw null;
		}

		internal string _003CRegisterInfoDebug_003Eb__12_12(AltMatch m)
		{
			throw null;
		}

		internal CommandResult _003CRegisterInfoDebug_003Eb__12_5(CommandContext ctx)
		{
			throw null;
		}

		internal string _003CRegisterInfoDebug_003Eb__12_13(AuditEntry e)
		{
			throw null;
		}

		internal CommandResult _003CRegisterInfoDebug_003Eb__12_6(CommandContext ctx)
		{
			throw null;
		}

		internal string _003CRegisterInfoDebug_003Eb__12_14(AuditEntry e)
		{
			throw null;
		}

		internal CommandResult _003CRegisterInfoDebug_003Eb__12_7(CommandContext ctx)
		{
			throw null;
		}

		internal CommandResult _003CRegisterInfoDebug_003Eb__12_8(CommandContext ctx)
		{
			throw null;
		}

		internal CommandResult _003CRegisterAccountSecurity_003Eb__13_0(CommandContext ctx)
		{
			throw null;
		}

		internal CommandResult _003CRegisterAccountSecurity_003Eb__13_1(CommandContext ctx)
		{
			throw null;
		}

		internal CommandResult _003CRegisterAccountSecurity_003Eb__13_2(CommandContext ctx)
		{
			throw null;
		}

		internal CommandResult _003CRegisterAccountSecurity_003Eb__13_3(CommandContext ctx)
		{
			throw null;
		}

		internal CommandResult _003CRegisterAccountSecurity_003Eb__13_4(CommandContext ctx)
		{
			throw null;
		}

		internal void _003CRegisterAccountSecurity_003Eb__13_19(StaffAccount a)
		{
			throw null;
		}

		internal CommandResult _003CRegisterAccountSecurity_003Eb__13_5(CommandContext ctx)
		{
			throw null;
		}

		internal void _003CRegisterAccountSecurity_003Eb__13_20(StaffAccount a)
		{
			throw null;
		}

		internal CommandResult _003CRegisterAccountSecurity_003Eb__13_6(CommandContext ctx)
		{
			throw null;
		}

		internal string _003CRegisterAccountSecurity_003Eb__13_21(AltMatch m)
		{
			throw null;
		}

		internal string _003CRegisterAccountSecurity_003Eb__13_22(AuditEntry e)
		{
			throw null;
		}

		internal CommandResult _003CRegisterAccountSecurity_003Eb__13_7(CommandContext ctx)
		{
			throw null;
		}

		internal bool _003CRegisterAccountSecurity_003Eb__13_23(StaffAccount a)
		{
			throw null;
		}

		internal string _003CRegisterAccountSecurity_003Eb__13_24(StaffAccount a)
		{
			throw null;
		}

		internal CommandResult _003CRegisterAccountSecurity_003Eb__13_8(CommandContext ctx)
		{
			throw null;
		}

		internal CommandResult _003CRegisterAccountSecurity_003Eb__13_9(CommandContext ctx)
		{
			throw null;
		}

		internal CommandResult _003CRegisterAccountSecurity_003Eb__13_10(CommandContext ctx)
		{
			throw null;
		}

		internal void _003CRegisterAccountSecurity_003Eb__13_25(StaffAccount a)
		{
			throw null;
		}

		internal CommandResult _003CRegisterAccountSecurity_003Eb__13_11(CommandContext ctx)
		{
			throw null;
		}

		internal CommandResult _003CRegisterAccountSecurity_003Eb__13_12(CommandContext ctx)
		{
			throw null;
		}

		internal CommandResult _003CRegisterAccountSecurity_003Eb__13_13(CommandContext ctx)
		{
			throw null;
		}

		internal void _003CRegisterAccountSecurity_003Eb__13_28(StaffAccount a)
		{
			throw null;
		}

		internal CommandResult _003CRegisterAccountSecurity_003Eb__13_14(CommandContext ctx)
		{
			throw null;
		}

		internal void _003CRegisterAccountSecurity_003Eb__13_29(StaffAccount a)
		{
			throw null;
		}

		internal CommandResult _003CRegisterServerLobby_003Eb__15_0(CommandContext ctx)
		{
			throw null;
		}

		internal CommandResult _003CRegisterServerLobby_003Eb__15_1(CommandContext ctx)
		{
			throw null;
		}

		internal CommandResult _003CRegisterServerLobby_003Eb__15_2(CommandContext ctx)
		{
			throw null;
		}

		internal CommandResult _003CRegisterServerLobby_003Eb__15_3(CommandContext ctx)
		{
			throw null;
		}

		internal CommandResult _003CRegisterServerLobby_003Eb__15_4(CommandContext ctx)
		{
			throw null;
		}

		internal CommandResult _003CRegisterServerLobby_003Eb__15_5(CommandContext ctx)
		{
			throw null;
		}

		internal CommandResult _003CRegisterTrollCommands_003Eb__19_0(CommandContext ctx)
		{
			throw null;
		}

		internal CommandResult _003CRegisterTrollCommands_003Eb__19_1(CommandContext ctx)
		{
			throw null;
		}

		internal CommandResult _003CRegisterTrollCommands_003Eb__19_2(CommandContext ctx)
		{
			throw null;
		}

		internal CommandResult _003CRegisterTrollCommands_003Eb__19_3(CommandContext ctx)
		{
			throw null;
		}

		internal CommandResult _003CRegisterTrollCommands_003Eb__19_4(CommandContext ctx)
		{
			throw null;
		}

		internal CommandResult _003CRegisterTrollCommands_003Eb__19_5(CommandContext ctx)
		{
			throw null;
		}

		internal CommandResult _003CRegisterTrollCommands_003Eb__19_6(CommandContext ctx)
		{
			throw null;
		}
	}

	private sealed class _003C_003Ec__DisplayClass13_0
	{
		public CommandContext ctx;

		public _003C_003Ec__DisplayClass13_0()
		{
			throw null;
		}

		internal void _003CRegisterAccountSecurity_003Eb__15(StaffAccount a)
		{
			throw null;
		}
	}

	private sealed class _003C_003Ec__DisplayClass13_1
	{
		public CommandContext ctx;

		public _003C_003Ec__DisplayClass13_1()
		{
			throw null;
		}

		internal void _003CRegisterAccountSecurity_003Eb__16(StaffAccount a)
		{
			throw null;
		}
	}

	private sealed class _003C_003Ec__DisplayClass13_2
	{
		public CommandContext ctx;

		public _003C_003Ec__DisplayClass13_2()
		{
			throw null;
		}

		internal void _003CRegisterAccountSecurity_003Eb__17(StaffAccount a)
		{
			throw null;
		}
	}

	private sealed class _003C_003Ec__DisplayClass13_3
	{
		public CommandContext ctx;

		public _003C_003Ec__DisplayClass13_3()
		{
			throw null;
		}

		internal void _003CRegisterAccountSecurity_003Eb__18(StaffAccount a)
		{
			throw null;
		}
	}

	private sealed class _003C_003Ec__DisplayClass13_4
	{
		public CommandContext ctx;

		public _003C_003Ec__DisplayClass13_4()
		{
			throw null;
		}

		internal void _003CRegisterAccountSecurity_003Eb__26(StaffAccount a)
		{
			throw null;
		}
	}

	private sealed class _003C_003Ec__DisplayClass13_5
	{
		public CommandContext ctx;

		public _003C_003Ec__DisplayClass13_5()
		{
			throw null;
		}

		internal void _003CRegisterAccountSecurity_003Eb__27(StaffAccount a)
		{
			throw null;
		}
	}

	private sealed class _003C_003Ec__DisplayClass6_0
	{
		public GameAction action;

		public _003C_003Ec__DisplayClass6_0()
		{
			throw null;
		}

		internal CommandResult _003CG_003Eb__0(CommandContext ctx)
		{
			throw null;
		}
	}

	private readonly Dictionary<string, CommandDescriptor> _commands;

	public IEnumerable<CommandDescriptor> All
	{
		get
		{
			throw null;
		}
	}

	public CommandDescriptor Find(string name)
	{
		throw null;
	}

	public CommandRegistry()
	{
		throw null;
	}

	private void Add(string name, StaffRole min, Func<CommandContext, CommandResult> handler, string usage, string desc, bool critical = false, int cooldownSec = 0)
	{
		throw null;
	}

	private void G(string name, StaffRole min, GameAction action, string usage, string desc, bool critical = false, int cooldownSec = 0)
	{
		throw null;
	}

	private static CommandResult RunGame(CommandContext ctx, GameAction action)
	{
		throw null;
	}

	private static StaffAccount ResolveAccount(CommandContext ctx)
	{
		throw null;
	}

	private static CommandResult RequireTarget(CommandContext ctx)
	{
		throw null;
	}

	private void RegisterModerator()
	{
		throw null;
	}

	private void RegisterPlayerManagement()
	{
		throw null;
	}

	private void RegisterInfoDebug()
	{
		throw null;
	}

	private void RegisterAccountSecurity()
	{
		throw null;
	}

	private static CommandResult AccountMutate(CommandContext ctx, Action<StaffAccount> mutate, string ok)
	{
		throw null;
	}

	private void RegisterServerLobby()
	{
		throw null;
	}

	private void RegisterTestUtilities()
	{
		throw null;
	}

	private void RegisterFun()
	{
		throw null;
	}

	private void RegisterDevPowerTools()
	{
		throw null;
	}

	private void RegisterTrollCommands()
	{
		throw null;
	}

	private static string FormatAccount(StaffAccount acc, StaffRole viewer, StaffServices svc)
	{
		throw null;
	}
}
