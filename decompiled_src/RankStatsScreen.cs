using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class RankStatsScreen : MonoBehaviour
{
	private sealed class _003CCoFetchRank_003Ed__13 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public RankStatsScreen _003C_003E4__this;

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

		public _003CCoFetchRank_003Ed__13(int _003C_003E1__state)
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

	private bool _wired;

	private TextMeshPro _rankingTexts;

	private TextMeshPro _hideCountryLabel;

	private Coroutine _refreshRoutine;

	private AccountService.RankInfo _lastRank;

	private const float HeaderSize = 2.7f;

	private void OnEnable()
	{
		throw null;
	}

	private void WireOnce()
	{
		throw null;
	}

	private void OnHideCountryClicked()
	{
		throw null;
	}

	public void RefreshTexts()
	{
		throw null;
	}

	public void RefreshRank()
	{
		throw null;
	}

	private static string T(StringNames id, string fallback)
	{
		throw null;
	}

	private void RefreshHideCountryLabel()
	{
		throw null;
	}

	private void OpenContactStaffs()
	{
		throw null;
	}

	private IEnumerator CoFetchRank()
	{
		throw null;
	}

	private void RenderRankCard()
	{
		throw null;
	}

	private static string Header(string text)
	{
		throw null;
	}

	public static string RunnerTimeText(long ms)
	{
		throw null;
	}

	public static string RankText(int rank)
	{
		throw null;
	}

	public RankStatsScreen()
	{
		throw null;
	}

	private void _003CWireOnce_003Eb__6_0()
	{
		throw null;
	}

	private void _003CCoFetchRank_003Eb__13_0(AccountService.RankInfo info)
	{
		throw null;
	}
}
