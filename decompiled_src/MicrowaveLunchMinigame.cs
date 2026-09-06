using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MicrowaveLunchMinigame : Minigame
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Func<Transform, GameObject> _003C_003E9__2_0;

		static _003C_003Ec()
		{
			throw null;
		}

		public _003C_003Ec()
		{
			throw null;
		}

		internal GameObject _003CStart_003Eb__2_0(Transform t)
		{
			throw null;
		}
	}

	private sealed class _003C_003Ec__DisplayClass2_0
	{
		public Transform button;

		public MicrowaveLunchMinigame _003C_003E4__this;

		public _003C_003Ec__DisplayClass2_0()
		{
			throw null;
		}

		internal void _003CStart_003Eb__1()
		{
			throw null;
		}
	}

	private sealed class _003CComplete_003Ed__9 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public MicrowaveLunchMinigame _003C_003E4__this;

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

		public _003CComplete_003Ed__9(int _003C_003E1__state)
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

	private sealed class _003CCompleteTask_003Ed__10 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public MicrowaveLunchMinigame _003C_003E4__this;

		public GameObject item;

		private SpriteRenderer _003Crend_003E5__2;

		private float _003Ct_003E5__3;

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

		public _003CCompleteTask_003Ed__10(int _003C_003E1__state)
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

	private sealed class _003CError_003Ed__8 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public MicrowaveLunchMinigame _003C_003E4__this;

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

		public _003CError_003Ed__8(int _003C_003E1__state)
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

	public bool isCooking;

	public string AllSecs;

	private readonly List<int> _enteredNumber;

	private readonly ClickableSprite[] _numberButtons;

	public AudioSource _audio;

	public AudioClip sussound;

	public TextMeshPro _timerTextAlt;

	private GameObject _background;

	public AudioClip _beep;

	private Transform[] _buttons;

	private Transform _controlPanel;

	private int _cookTimeSeconds;

	private TextMeshPro _cookTimeText;

	private bool _dontUpdate;

	private int _foodItem;

	private GameObject[] _foodItems;

	private GameObject _loreTextGreen;

	private GameObject _loreTextPink;

	private MinigameProperties _minigameProperties;

	private GameObject _notesMask;

	private GameObject _openDoor;

	private GameObject _screen;

	private GameObject _screenLight;

	private TextMeshPro _timerText;

	private void Start()
	{
		throw null;
	}

	private void Update()
	{
		throw null;
	}

	private void NumberButtonPress(int number)
	{
		throw null;
	}

	private string CalculateTotalSecs()
	{
		throw null;
	}

	private void ClearButtonPress()
	{
		throw null;
	}

	private void CookButtonPress()
	{
		throw null;
	}

	private IEnumerator Error()
	{
		throw null;
	}

	private IEnumerator Complete()
	{
		throw null;
	}

	private IEnumerator CompleteTask(GameObject item)
	{
		throw null;
	}

	public override void Close()
	{
		throw null;
	}

	public MicrowaveLunchMinigame()
	{
		throw null;
	}

	private void _003CComplete_003Eb__9_0()
	{
		throw null;
	}
}
