using UnityEngine;

public class SkinData : ScriptableObject, IBuyable
{
	public Sprite IdleFrame;

	public AnimationClip IdleAnim;

	public AnimationClip RunAnim;

	public AnimationClip EnterVentAnim;

	public AnimationClip ExitVentAnim;

	public AnimationClip ClimbAnim;

	public AnimationClip ClimbDownAnim;

	public AnimationClip KillTongueImpostor;

	public AnimationClip KillTongueVictim;

	public AnimationClip KillShootImpostor;

	public AnimationClip KillShootVictim;

	public AnimationClip KillStabVictim;

	public AnimationClip KillNeckVictim;

	public AnimationClip KillRHMVictim;

	public Sprite EjectFrame;

	public AnimationClip SpawnAnim;

	public OverlayKillAnimation[] KillAnims;

	public bool Free;

	public bool isNewSkin;

	public string StoreName;

	public string ProductId;

	public XMLSkinData XMLSkin;

	public string ProdId => null;
}
