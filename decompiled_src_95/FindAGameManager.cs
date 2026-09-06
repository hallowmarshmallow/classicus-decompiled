using System;
using System.Collections;
using System.Collections.Generic;
using InnerNet;
using TMPro;
using UnityEngine.Networking;

public class FindAGameManager : DestroyableSingleton<FindAGameManager>, IGameListHandler
{
	private class GameSorter : IComparer<GameListing>
	{
		public static readonly GameSorter Instance;

		public int Compare(GameListing x, GameListing y)
		{
			return 0;
		}
	}

	private sealed class _003CCoReviveConnection_003Ed__22 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public FindAGameManager _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CCoReviveConnection_003Ed__22(int _003C_003E1__state)
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

		private void _003C_003Em__Finally1()
		{
		}

		void IEnumerator.Reset()
		{
		}
	}

	private sealed class _003CFetchTotalPlayersFromApi_003Ed__26 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public FindAGameManager _003C_003E4__this;

		private UnityWebRequest _003Crequest_003E5__2;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CFetchTotalPlayersFromApi_003Ed__26(int _003C_003E1__state)
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

		private void _003C_003Em__Finally1()
		{
		}

		void IEnumerator.Reset()
		{
		}
	}

	private const float RefreshTime = 1.5f;

	private float timer;

	public ObjectPoolBehavior buttonPool;

	public SpinAnimator RefreshSpinner;

	public Scroller TargetArea;

	public float ButtonStart;

	public float ButtonHeight;

	public const bool showPrivate = false;

	public TextMeshPro AvailableGamesText;

	public TextMeshPro TotalLobbiesText;

	public TextMeshPro TotalPlayersText;

	private int _httpTotalPlayerCount;

	private const float FirstRetryDelay = 6f;

	private const float MaxRetryDelay = 30f;

	private float _lastRequestAt;

	private float _retryDelay;

	private bool _listReceived;

	private bool _reviving;

	public void ResetTimer()
	{
	}

	public void Start()
	{
	}

	public void Update()
	{
	}

	private IEnumerator CoReviveConnection()
	{
		return null;
	}

	public void RefreshList()
	{
	}

	public override void OnDestroy()
	{
	}

	public void HandleList(List<GameListing> availableGames)
	{
	}

	private IEnumerator FetchTotalPlayersFromApi()
	{
		return null;
	}

	private static void SetCount(TextMeshPro text, int value)
	{
	}

	public void ExitGame()
	{
	}
}
