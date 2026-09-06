using System.Collections.Generic;
using UnityEngine;

public class CachedMaterials : DestroyableSingleton<CachedMaterials>
{
	public Material PlayerMat;

	public Material SpriteDefault;

	public Material MaskMat;

	public Shader UnlitTransparent;

	public TutorialManager TutorialPrefab;

	public SystemConsole TaskAdd;

	public List<Material> BrookMaterials;

	public AbilityButtonManager abilityButton;

	public EffectAnimation CloudPuff;

	public EffectAnimation Shift;

	public CustomPlayerMenu PlayerMenu;

	public AudioClip CrewReveal;

	public AudioClip ImpReveal;

	public AudioClip NeutralReveal;

	public PlayerPickMenu PPM;

	public static string CachedPing;

	public AnimationClip InvisWalk;

	public AnimationClip InvisIdle;

	public OverlayKillAnimation MisfireAnimation;

	public OptionsMenuBehaviour OptionsMenu;

	public CachedMaterials()
	{
		throw null;
	}
}
