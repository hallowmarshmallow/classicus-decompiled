using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeCell : MonoBehaviour
{
	private sealed class _003CRotatePiece_003Ed__8 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PipeCell _003C_003E4__this;

		private Vector3 _003CoriginalRotation_003E5__2;

		private Vector3 _003CnewRotation_003E5__3;

		private float _003Ct_003E5__4;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CRotatePiece_003Ed__8(int _003C_003E1__state)
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

	private int _queuedClicks;

	private bool _canClick;

	private ReconnectPipingMinigame _reconnectPipingMinigame;

	private bool _straightSet;

	public GameObject straight;

	public GameObject elbow;

	private void Awake()
	{
	}

	public void Click()
	{
	}

	public IEnumerator RotatePiece()
	{
		return null;
	}

	public void SetPiece(Direction firstDirection, Direction secondDirection, bool randomiseRotation = true)
	{
	}

	public void SetRandom()
	{
	}

	public Direction GetNextDirection(Direction direction)
	{
		return default(Direction);
	}
}
