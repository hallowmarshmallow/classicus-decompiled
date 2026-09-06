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

		internal GameObject _003CStart_003Eb__2_0(Transform t)
		{
			return null;
		}
	}

	private sealed class _003C_003Ec__DisplayClass2_0
	{
		public Transform button;

		public MicrowaveLunchMinigame _003C_003E4__this;

		internal void _003CStart_003Eb__1()
		{
		}
	}

	private sealed class _003CComplete_003Ed__9 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public MicrowaveLunchMinigame _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CComplete_003Ed__9(int _003C_003E1__state)
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

	private sealed class _003CCompleteTask_003Ed__10 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public MicrowaveLunchMinigame _003C_003E4__this;

		public GameObject item;

		private SpriteRenderer _003Crend_003E5__2;

		private float _003Ct_003E5__3;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CCompleteTask_003Ed__10(int _003C_003E1__state)
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

	private sealed class _003CError_003Ed__8 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public MicrowaveLunchMinigame _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CError_003Ed__8(int _003C_003E1__state)
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
	}

	private void Update()
	{
	}

	private void NumberButtonPress(int number)
	{
	}

	private string CalculateTotalSecs()
	{
		return null;
	}

	private void ClearButtonPress()
	{
	}

	private void CookButtonPress()
	{
	}

	private IEnumerator Error()
	{
		return null;
	}

	private IEnumerator Complete()
	{
		return null;
	}

	private IEnumerator CompleteTask(GameObject item)
	{
		return null;
	}

	public override void Close()
	{
	}

	private void _003CComplete_003Eb__9_0()
	{
	}
}
