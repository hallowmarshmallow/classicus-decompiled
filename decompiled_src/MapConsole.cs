using System;
using UnityEngine;

public class MapConsole : MonoBehaviour, IUsable
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Action<MapBehaviour> _003C_003E9__8_0;

		static _003C_003Ec()
		{
			throw null;
		}

		public _003C_003Ec()
		{
			throw null;
		}

		internal void _003CUse_003Eb__8_0(MapBehaviour m)
		{
			throw null;
		}
	}

	public float usableDistance;

	public SpriteRenderer Image;

	public float UsableDistance
	{
		get
		{
			throw null;
		}
	}

	public float PercentCool
	{
		get
		{
			throw null;
		}
	}

	public void SetOutline(bool on, bool mainTarget)
	{
		throw null;
	}

	public float CanUse(GameData.PlayerInfo pc, out bool canUse, out bool couldUse)
	{
		throw null;
	}

	public void Use()
	{
		throw null;
	}

	public MapConsole()
	{
		throw null;
	}
}
