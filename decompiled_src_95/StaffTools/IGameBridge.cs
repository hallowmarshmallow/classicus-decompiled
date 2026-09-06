using System.Collections.Generic;

namespace StaffTools;

public interface IGameBridge
{
	IEnumerable<GamePlayer> Players();

	GameActionResult Execute(GameAction action, CommandContext ctx);
}
