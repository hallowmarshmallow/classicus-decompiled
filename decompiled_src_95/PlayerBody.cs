using PowerTools;
using UnityEngine;

public class PlayerBody : MonoBehaviour
{
	public bool HideSkin;

	public SpriteAnim Animator;

	public SpriteRenderer Rend;

	public AnimationClip IdleAnim;

	public AnimationClip RunAnim;

	public AnimationClip EnterVentAnim;

	public AnimationClip ExitVentAnim;

	public AnimationClip GhostAnim;

	public AnimationClip ClimbUpAnim;

	public AnimationClip ClimbDownAnim;

	public virtual void CheckHatProperties(PlayerControl player, HatBehaviour hat)
	{
	}
}
