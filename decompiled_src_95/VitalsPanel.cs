using UnityEngine;

public class VitalsPanel : MonoBehaviour
{
	public PoolablePlayer PlayerIcon;

	public SpriteRenderer MaskingArea;

	public SpriteRenderer Background;

	public VertLineBehaviour Cardio;

	public Sprite VitalBgDead;

	public Sprite VitalBgDiscon;

	public IntRange BeatRange;

	public bool IsDead;

	public bool IsDiscon;

	private GameData.PlayerInfo _003CPlayerInfo_003Ek__BackingField;

	public GameData.PlayerInfo PlayerInfo
	{
		get
		{
			return _003CPlayerInfo_003Ek__BackingField;
		}
		set
		{
			_003CPlayerInfo_003Ek__BackingField = value;
		}
	}

	public void SetPlayer(int index, GameData.PlayerInfo playerInfo)
	{
	}

	public void SetDisconnected()
	{
	}

	public void SetDead()
	{
	}

	public void SetAlive()
	{
	}
}
