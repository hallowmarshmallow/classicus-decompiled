using System;
using UnityEngine;

public class CrystalMinigame : Minigame
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Func<CrystalBehaviour, bool> _003C_003E9__10_0;

		internal bool _003CCheckSolution_003Eb__10_0(CrystalBehaviour c)
		{
			return false;
		}
	}

	public CrystalBehaviour[] CrystalPieces;

	private CrystalBehaviour[] Shuffed;

	public Transform[] CrystalSlots;

	public FloatRange XRange;

	public float TrayY;

	public AudioClip[] PickUpSounds;

	public AudioClip AttachSound;

	private Controller myController;

	public void Start()
	{
	}

	public void Update()
	{
	}

	private void CheckSolution(int startAt)
	{
	}
}
