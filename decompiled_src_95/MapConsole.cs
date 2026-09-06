using System;
using UnityEngine;

public class MapConsole : MonoBehaviour, IUsable
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Action<MapBehaviour> _003C_003E9__8_0;

		internal void _003CUse_003Eb__8_0(MapBehaviour m)
		{
		}
	}

	public float usableDistance;

	public SpriteRenderer Image;

	public float UsableDistance => 0f;

	public float PercentCool => 0f;

	public void SetOutline(bool on, bool mainTarget)
	{
	}

	public float CanUse(GameData.PlayerInfo pc, out bool canUse, out bool couldUse)
	{
		canUse = default(bool);
		couldUse = default(bool);
		return 0f;
	}

	public void Use()
	{
	}
}
