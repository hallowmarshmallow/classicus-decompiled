using UnityEngine;

public class LongBoiPlayerBody : MonoBehaviour
{
	private SpriteRenderer neckSprite;

	private SpriteRenderer foregroundNeckSprite;

	private SpriteRenderer headSprite;

	private PlayerControl myPlayerControl;

	private PoolablePlayer myPoolablePlayer;

	private float neckHeadZPos;

	private float cosmeticYOffset;

	private bool isPoolablePlayer;

	private bool isExiledPlayer;

	private float targetHeight;

	private bool skipNeckAnim;

	private bool isSeekerHorse;

	private GameObject neckHeadParent;

	private bool hideCosmeticsQC;

	private float growSpeed;

	public LongBoiPlayerBody()
	{
		throw null;
	}
}
