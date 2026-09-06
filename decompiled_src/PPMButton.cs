using System;
using UnityEngine;

public class PPMButton : MonoBehaviour
{
	public PoolablePlayer prefab;

	public PoolablePlayer player;

	public SpriteRenderer PlayerIcon;

	public SpriteRenderer Overlay;

	public TextRenderer NameText;

	public PlayerPickMenu Parent;

	public Action OnClick;

	public GameData.PlayerInfo Data;

	public void ClickButton()
	{
		throw null;
	}

	public void SetupPlayer(GameData.PlayerInfo data)
	{
		throw null;
	}

	public PPMButton()
	{
		throw null;
	}
}
