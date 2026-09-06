using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class TaskWarm
{
	private sealed class _003CCoWarmLocalTaskMinigames_003Ed__4 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PlayerControl player;

		private float _003CstartedAt_003E5__2;

		private float _003CworkSeconds_003E5__3;

		private int _003Cframes_003E5__4;

		private int _003Cwarmed_003E5__5;

		private int _003Ctouched_003E5__6;

		private float _003CworstSeconds_003E5__7;

		private string _003CworstName_003E5__8;

		private HashSet<int> _003Cseen_003E5__9;

		private List<Minigame> _003Cdistinct_003E5__10;

		private int _003Ci_003E5__11;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CCoWarmLocalTaskMinigames_003Ed__4(int _003C_003E1__state)
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

	private static readonly HashSet<int> warmedPrefabIds;

	public static IEnumerator CoWarmLocalTaskMinigames(PlayerControl player)
	{
		return null;
	}

	private static int TouchAssets(GameObject root)
	{
		return 0;
	}
}
