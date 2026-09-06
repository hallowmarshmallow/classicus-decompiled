using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DraggableFeeder : MonoBehaviour
{
	private sealed class _003CCoReturnToShelf_003Ed__9 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public DraggableFeeder _003C_003E4__this;

		private Vector3 _003CcurrentPosition_003E5__2;

		private Vector3 _003CtargetPosition_003E5__3;

		private Quaternion _003CtargetRotation_003E5__4;

		private Quaternion _003CcurrentRotation_003E5__5;

		private float _003Ct_003E5__6;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CCoReturnToShelf_003Ed__9(int _003C_003E1__state)
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

	private sealed class _003CCoRotate_003Ed__8 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public DraggableFeeder _003C_003E4__this;

		private Quaternion _003CtargetRotation_003E5__2;

		private Quaternion _003CcurrentRotation_003E5__3;

		private float _003Ct_003E5__4;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CCoRotate_003Ed__8(int _003C_003E1__state)
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

	private const float SNAP_BACK_DURATION = 0.2f;

	public FeedPetFishMinigame owner;

	public Transform rotationTarget;

	public ParticleSystem fishFood;

	public Transform fishFoodParent;

	public BoxCollider2D activatedArea;

	public float shakeDuration;

	private int _correctFoodIndex;

	private float _counter;

	private bool _isCorrectFood;

	private bool _isNearDropZone;

	private Vector3 _lastLocation;

	private Camera _mainCamera;

	private Vector3 _mouseOffset;

	private Transform _myLid;

	private float _recordedMovement;

	private float _stepDuration;

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void OnMouseDown()
	{
	}

	private void OnMouseDrag()
	{
	}

	private void OnMouseUp()
	{
	}

	private void OnTriggerEnter2D(Collider2D collision)
	{
	}

	private void OnTriggerExit2D(Collider2D collision)
	{
	}

	public void SetCorrectFoodStatus(bool isCorrect, int index = -1)
	{
	}

	private IEnumerator CoRotate()
	{
		return null;
	}

	public IEnumerator CoReturnToShelf()
	{
		return null;
	}
}
