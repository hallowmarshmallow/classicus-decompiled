using System;
using System.Collections;
using System.Collections.Generic;

namespace StaffTools;

public sealed class NoopGameBridge : IGameBridge
{
	private sealed class _003CPlayers_003Ed__1 : IEnumerable<GamePlayer>, IEnumerable, IEnumerator<GamePlayer>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private GamePlayer _003C_003E2__current;

		private int _003C_003El__initialThreadId;

		GamePlayer IEnumerator<GamePlayer>.Current => null;

		object IEnumerator.Current => null;

		public _003CPlayers_003Ed__1(int _003C_003E1__state)
		{
		}

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
		}

		IEnumerator<GamePlayer> IEnumerable<GamePlayer>.GetEnumerator()
		{
			return null;
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	public IEnumerable<GamePlayer> Players()
	{
		return null;
	}

	public GameActionResult Execute(GameAction action, CommandContext ctx)
	{
		return null;
	}
}
