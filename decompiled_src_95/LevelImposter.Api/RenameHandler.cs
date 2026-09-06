using System.Collections.Generic;

namespace LevelImposter.Api;

public class RenameHandler
{
	private readonly Dictionary<StringNames, string> _stringRenames;

	private readonly Dictionary<SystemTypes, string> _systemRenames;

	private readonly Dictionary<TaskTypes, string> _taskRenames;
}
