using System;
using System.Collections.Generic;
using UnityEngine;

public class SortScubaGearMinigame : Minigame
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Func<ScubaGearItem, Vector3> _003C_003E9__1_0;

		internal Vector3 _003CShuffleGear_003Eb__1_0(ScubaGearItem s)
		{
			return default(Vector3);
		}
	}

	private sealed class _003C_003Ec__DisplayClass0_0
	{
		public AudioClip pickup;

		public AudioClip drop;

		public ScubaGearItem scubaGearItem;

		public SortScubaGearMinigame _003C_003E4__this;

		internal void _003CStart_003Eb__1()
		{
		}

		internal void _003CStart_003Eb__2()
		{
		}

		internal void _003CStart_003Eb__3()
		{
		}

		internal void _003CStart_003Eb__4()
		{
		}

		internal void _003CStart_003Eb__5()
		{
		}

		internal bool _003CStart_003Eb__6(Draggable d)
		{
			return false;
		}
	}

	public List<ScubaGearItem> scubaGearItems;

	public List<Transform> boxes;

	public AudioClip number0;

	public AudioClip dropn1;

	public List<Draggable> hovering;

	private bool _forceClose;

	public AudioClip pickupclip;

	public AudioClip number5;

	public AudioClip dropclip;

	public AudioClip number3;

	public AudioClip pickup2;

	public AudioClip number2;

	public Dictionary<ScubaGearType, SortScubaBox> scubaBoxes;

	private void Start()
	{
	}

	public void ShuffleGear()
	{
	}

	public bool CheckBoxes()
	{
		return false;
	}

	public override void Close()
	{
	}

	private static bool MustCloseNow()
	{
		return false;
	}

	private void _003CStart_003Eb__0_0(Transform t)
	{
	}
}
