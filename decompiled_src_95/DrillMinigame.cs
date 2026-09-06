using PowerTools;
using TMPro;
using UnityEngine;

public class DrillMinigame : Minigame
{
	public SpriteRenderer CaseImage;

	public TextMeshPro statusText;

	public SpriteAnim[] Buttons;

	public AnimationClip BadAnim;

	public AudioClip ButtonSound;

	private int MaxState;

	private int[] states;

	private SpriteAnim prevFixedButton;

	private float changeButtonDelay;

	private int[] drillButtonMaps;

	public void Start()
	{
	}

	public override void Begin(PlayerTask task)
	{
	}

	private void Update()
	{
	}

	public void FixButton(SpriteAnim button)
	{
	}

	private bool _003CBegin_003Eb__11_0(int s)
	{
		return false;
	}

	private bool _003CFixButton_003Eb__13_0(int ss)
	{
		return false;
	}
}
