using System;
using UnityEngine;

public class SabotageButton : MonoBehaviour
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Action<MapBehaviour> _003C_003E9__4_0;

		internal void _003CDoClick_003Eb__4_0(MapBehaviour m)
		{
		}
	}

	private static readonly Color DisabledColor;

	private static readonly Color EnabledColor;

	public SpriteRenderer UseButton;

	public Sprite SabotageImage;

	public void DoClick()
	{
	}

	internal void Refresh()
	{
	}

	public void SetTarget()
	{
	}
}
