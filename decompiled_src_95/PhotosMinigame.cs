using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhotosMinigame : Minigame
{
	private sealed class _003C_003Ec__DisplayClass13_0
	{
		public GamePhotoBehaviour p;

		internal bool _003CWriteInitialData_003Eb__0(Sprite s)
		{
			return false;
		}
	}

	private sealed class _003CStart_003Ed__15 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PhotosMinigame _003C_003E4__this;

		private float _003Cz_003E5__2;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CStart_003Ed__15(int _003C_003E1__state)
		{
		}

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
		}
	}

	public GamePhotoBehaviour[] photos;

	public Sprite[] PhotoContents;

	public Collider2D PoolHitbox;

	public Transform selectorObject;

	public SpriteRenderer selectorHand;

	public Rect PolaroidBounds;

	private Controller controller;

	private bool prevHadButton;

	private int currentlyGrabbedObject;

	private bool AllowDraggingPhotos => false;

	private List<Sprite> GetUniqueListOfPhotos(int count)
	{
		return null;
	}

	public override void Begin(PlayerTask task)
	{
	}

	private void WriteInitialData()
	{
	}

	private void ReadInitialData()
	{
	}

	public IEnumerator Start()
	{
		return null;
	}

	private void Update()
	{
	}

	private void HandleJoystick()
	{
	}

	private void HandleMouse()
	{
	}

	private void clampToBounds(GamePhotoBehaviour photo)
	{
	}

	private void FixZ(GamePhotoBehaviour current)
	{
	}

	private bool _003CUpdate_003Eb__16_0(GamePhotoBehaviour p)
	{
		return false;
	}

	private bool _003CUpdate_003Eb__16_1(GamePhotoBehaviour p)
	{
		return false;
	}
}
