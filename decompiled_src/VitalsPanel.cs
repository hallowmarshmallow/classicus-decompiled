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
			throw null;
		}
		set
		{
			throw null;
		}
	}

	public void SetPlayer(int index, GameData.PlayerInfo playerInfo)
	{
		throw null;
	}

	public void SetDisconnected()
	{
		throw null;
	}

	public void SetDead()
	{
		throw null;
	}

	public void SetAlive()
	{
		throw null;
	}

	public VitalsPanel()
	{
		throw null;
	}
}
