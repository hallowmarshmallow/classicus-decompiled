using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BanButton : MonoBehaviour
{
	private sealed class _003CCoSetVotes_003Ed__12 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public int oldNum;

		public int newNum;

		public BanButton _003C_003E4__this;

		private float _003Cend_003E5__2;

		private float _003Ctimer_003E5__3;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CCoSetVotes_003Ed__12(int _003C_003E1__state)
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

	public TextRenderer NameText;

	public SpriteRenderer Background;

	public int TargetClientId;

	public int numVotes;

	private BanMenu _003CParent_003Ek__BackingField;

	public BanMenu Parent
	{
		get
		{
			return _003CParent_003Ek__BackingField;
		}
		set
		{
			_003CParent_003Ek__BackingField = value;
		}
	}

	public void Start()
	{
	}

	public void Select()
	{
	}

	public void Unselect()
	{
	}

	public void SetVotes(int newVotes)
	{
	}

	private IEnumerator CoSetVotes(int oldNum, int newNum)
	{
		return null;
	}
}
