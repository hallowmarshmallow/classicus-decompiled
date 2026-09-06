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

		public _003CRotatePiece_003Ed__8(int _003C_003E1__state)
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

	private int _queuedClicks;

	private bool _canClick;

	private ReconnectPipingMinigame _reconnectPipingMinigame;

	private bool _straightSet;

	public GameObject straight;

	public GameObject elbow;

	private void Awake()
	{
		throw null;
	}

	public void Click()
	{
		throw null;
	}

	public IEnumerator RotatePiece()
	{
		throw null;
	}

	public void SetPiece(Direction firstDirection, Direction secondDirection, bool randomiseRotation = true)
	{
		throw null;
	}

	public void SetRandom()
	{
		throw null;
	}

	public Direction GetNextDirection(Direction direction)
	{
		throw null;
	}

	public PipeCell()
	{
		throw null;
	}
}
