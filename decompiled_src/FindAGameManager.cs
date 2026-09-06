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
			throw null;
		}

		public GameSorter()
		{
			throw null;
		}

		static GameSorter()
		{
			throw null;
		}
	}

	private sealed class _003CCoReviveConnection_003Ed__23 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public FindAGameManager _003C_003E4__this;

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

		public _003CCoReviveConnection_003Ed__23(int _003C_003E1__state)
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

		private void _003C_003Em__Finally1()
		{
			throw null;
		}

		void IEnumerator.Reset()
		{
			throw null;
		}
	}

	private sealed class _003CFetchTotalPlayersFromApi_003Ed__27 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public FindAGameManager _003C_003E4__this;

		private UnityWebRequest _003Crequest_003E5__2;

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

		public _003CFetchTotalPlayersFromApi_003Ed__27(int _003C_003E1__state)
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

		private void _003C_003Em__Finally1()
		{
			throw null;
		}

		void IEnumerator.Reset()
		{
			throw null;
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

	private int _httpTotalLobbyCount;

	private const float FirstRetryDelay = 6f;

	private const float MaxRetryDelay = 30f;

	private float _lastRequestAt;

	private float _retryDelay;

	private bool _listReceived;

	private bool _reviving;

	public void ResetTimer()
	{
		throw null;
	}

	public void Start()
	{
		throw null;
	}

	public void Update()
	{
		throw null;
	}

	private IEnumerator CoReviveConnection()
	{
		throw null;
	}

	public void RefreshList()
	{
		throw null;
	}

	public override void OnDestroy()
	{
		throw null;
	}

	public void HandleList(List<GameListing> availableGames)
	{
		throw null;
	}

	private IEnumerator FetchTotalPlayersFromApi()
	{
		throw null;
	}

	public void ExitGame()
	{
		throw null;
	}

	public FindAGameManager()
	{
		throw null;
	}
}
