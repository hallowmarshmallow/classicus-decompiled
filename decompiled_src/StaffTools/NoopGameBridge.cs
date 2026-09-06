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

		GamePlayer IEnumerator<GamePlayer>.Current
		{
			get
			{
				throw null;
			}
		}

		object IEnumerator.Current
		{
			get
			{
				throw null;
			}
		}

		public _003CPlayers_003Ed__1(int _003C_003E1__state)
		{
			throw null;
		}

		void IDisposable.Dispose()
		{
			throw null;
		}

		private bool MoveNext()
		{
			throw null;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
			throw null;
		}

		IEnumerator<GamePlayer> IEnumerable<GamePlayer>.GetEnumerator()
		{
			throw null;
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			throw null;
		}
	}

	public IEnumerable<GamePlayer> Players()
	{
		throw null;
	}

	public GameActionResult Execute(GameAction action, CommandContext ctx)
	{
		throw null;
	}

	public NoopGameBridge()
	{
		throw null;
	}
}
