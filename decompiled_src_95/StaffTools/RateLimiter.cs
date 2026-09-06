using System;
using System.Collections.Generic;

namespace StaffTools;

public sealed class RateLimiter
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Func<DateTime> _003C_003E9__5_0;

		internal DateTime _003C_002Ector_003Eb__5_0()
		{
			return default(DateTime);
		}
	}

	private readonly int _maxActions;

	private readonly TimeSpan _window;

	private readonly Func<DateTime> _now;

	private readonly Dictionary<string, Queue<DateTime>> _hits;

	private readonly Dictionary<string, DateTime> _cooldowns;

	public RateLimiter(int maxActions, TimeSpan window, Func<DateTime> now = null)
	{
	}

	public bool TryConsume(string key)
	{
		return false;
	}

	public bool OnCooldown(string key, out TimeSpan remaining)
	{
		remaining = default(TimeSpan);
		return false;
	}

	public void ApplyCooldown(string key, TimeSpan duration)
	{
	}
}
