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

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CCoFetchRank_003Ed__13(int _003C_003E1__state)
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

	private bool _wired;

	private TextMeshPro _rankingTexts;

	private TextMeshPro _hideCountryLabel;

	private Coroutine _refreshRoutine;

	private AccountService.RankInfo _lastRank;

	private const float HeaderSize = 2.7f;

	private void OnEnable()
	{
	}

	private void WireOnce()
	{
	}

	private void OnHideCountryClicked()
	{
	}

	public void RefreshTexts()
	{
	}

	public void RefreshRank()
	{
	}

	private static string T(StringNames id, string fallback)
	{
		return null;
	}

	private void RefreshHideCountryLabel()
	{
	}

	private void OpenContactStaffs()
	{
	}

	private IEnumerator CoFetchRank()
	{
		return null;
	}

	private void RenderRankCard()
	{
	}

	private static string Header(string text)
	{
		return null;
	}

	public static string RunnerTimeText(long ms)
	{
		return null;
	}

	public static string RankText(int rank)
	{
		return null;
	}

	private void _003CWireOnce_003Eb__6_0()
	{
	}

	private void _003CCoFetchRank_003Eb__13_0(AccountService.RankInfo info)
	{
	}
}
