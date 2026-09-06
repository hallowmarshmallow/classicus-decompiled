using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhotosMinigame : Minigame
{
	private sealed class _003C_003Ec__DisplayClass13_0
	{
		public GamePhotoBehaviour p;

		public _003C_003Ec__DisplayClass13_0()
		{
			throw null;
		}

		internal bool _003CWriteInitialData_003Eb__0(Sprite s)
		{
			throw null;
		}
	}

	private sealed class _003CStart_003Ed__15 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PhotosMinigame _003C_003E4__this;

		private float _003Cz_003E5__2;

		object IEnumerator<object>.Current
		{
			get
			{
				throw null;
			}
		}

		object IEnumerator.Current
		{
			get
			{
				throw null;
			}
		}

		public _003CStart_003Ed__15(int _003C_003E1__state)
		{
			throw null;
		}

		void IDisposable.Dispose()
		{
			throw null;
		}

		private bool MoveNext()
		{
			throw null;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
			throw null;
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

	private bool AllowDraggingPhotos
	{
		get
		{
			throw null;
		}
	}

	private List<Sprite> GetUniqueListOfPhotos(int count)
	{
		throw null;
	}

	public override void Begin(PlayerTask task)
	{
		throw null;
	}

	private void WriteInitialData()
	{
		throw null;
	}

	private void ReadInitialData()
	{
		throw null;
	}

	public IEnumerator Start()
	{
		throw null;
	}

	private void Update()
	{
		throw null;
	}

	private void HandleJoystick()
	{
		throw null;
	}

	private void HandleMouse()
	{
		throw null;
	}

	private void clampToBounds(GamePhotoBehaviour photo)
	{
		throw null;
	}

	private void FixZ(GamePhotoBehaviour current)
	{
		throw null;
	}

	public PhotosMinigame()
	{
		throw null;
	}

	private bool _003CUpdate_003Eb__16_0(GamePhotoBehaviour p)
	{
		throw null;
	}

	private bool _003CUpdate_003Eb__16_1(GamePhotoBehaviour p)
	{
		throw null;
	}
}
