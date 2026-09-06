using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PurchaseBreakFastMinigame : Minigame
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Func<Transform, Vector3> _003C_003E9__37_0;

		public static Func<Transform, Vector3> _003C_003E9__38_0;

		public static Func<Transform, Vector3> _003C_003E9__38_1;

		public static Func<Transform, Vector3> _003C_003E9__38_2;

		public static Func<Transform, Vector3> _003C_003E9__38_3;

		internal Vector3 _003CCompleteTask_003Eb__37_0(Transform t)
		{
			return default(Vector3);
		}

		internal Vector3 _003CFailTask_003Eb__38_0(Transform t)
		{
			return default(Vector3);
		}

		internal Vector3 _003CFailTask_003Eb__38_1(Transform t)
		{
			return default(Vector3);
		}

		internal Vector3 _003CFailTask_003Eb__38_2(Transform t)
		{
			return default(Vector3);
		}

		internal Vector3 _003CFailTask_003Eb__38_3(Transform t)
		{
			return default(Vector3);
		}
	}

	private sealed class _003C_003Ec__DisplayClass33_0
	{
		public int chosenPrice;

		internal bool _003CStart_003Eb__0((int, int[]) p)
		{
			return false;
		}

		internal bool _003CStart_003Eb__1(CakeBehaviour c)
		{
			return false;
		}
	}

	private sealed class _003CCompleteTask_003Ed__37 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PurchaseBreakFastMinigame _003C_003E4__this;

		public CakeBehaviour cake;

		private Vector3[] _003CoriginalPositions_003E5__2;

		private Vector3 _003CoriginalPos_003E5__3;

		private float _003Ct_003E5__4;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CCompleteTask_003Ed__37(int _003C_003E1__state)
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

	private sealed class _003CFailTask_003Ed__38 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PurchaseBreakFastMinigame _003C_003E4__this;

		private Vector3 _003CoriginalPos_003E5__2;

		private Vector3[] _003CoriginalPositions_003E5__3;

		private float _003Ct_003E5__4;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CFailTask_003Ed__38(int _003C_003E1__state)
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

	private const int MAX_RETRY_COUNT = 10;

	private const float ANIMATION_DURATION_SHORT = 0.15f;

	private const float ANIMATION_DURATION_LONG = 0.4f;

	private const float TRAY_SLIDE_OFFSET = 22.75f;

	private const float SALES_Y_OFFSET = 5.5f;

	private const float RESET_Y_POSITION = -1.27f;

	private const float MONEY_FALL_Y = -8f;

	private Sprite[] _sprites;

	public int[] currencyDenominations;

	public List<int> possiblePrices;

	public List<int> existingBillConfigurations;

	public List<int> pickedPrices;

	public List<int> pickedSlots;

	public List<int> pickedSales;

	public List<SpriteRenderer> billRenderers;

	public List<Transform> billTransforms;

	public List<Transform> traysMovingParts;

	public List<Transform> salesMovingParts;

	private int _amountOfBills;

	private int _callCount;

	private bool _canComplete;

	private bool _hasShownEasterEgg;

	private SpriteRenderer _leftFailRenderer;

	private int _pastryAmount;

	private Sprite _previousSprite;

	private System.Random _random;

	private SpriteRenderer _rightFailRenderer;

	private int _seed;

	public Dictionary<int, CakeBehaviour> cakeBehaviours;

	public List<(Sprite, Sprite)> foodSprites;

	public Dictionary<int, Sprite> moneySprites;

	public Dictionary<int, Sprite> numbers;

	public List<(int, int[])> priceToBill;

	private void Start()
	{
	}

	public void GeneratePossiblePrices()
	{
	}

	public int GetBillIdentifier(int[] bills)
	{
		return 0;
	}

	public void FindSprites()
	{
	}

	public IEnumerator CompleteTask(CakeBehaviour cake)
	{
		return null;
	}

	public IEnumerator FailTask()
	{
		return null;
	}

	public static List<T> ShuffleWithRandom<T>(List<T> list, System.Random random)
	{
		return null;
	}

	public static List<T> ShuffleWithRandomCopy<T>(List<T> list, System.Random random)
	{
		return null;
	}

	public override void Close()
	{
	}
}
