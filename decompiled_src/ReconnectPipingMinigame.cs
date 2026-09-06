using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class ReconnectPipingMinigame : Minigame
{
	[StructLayout((LayoutKind)3)]
	private struct _003C_003Ec__DisplayClass9_0
	{
		public ReconnectPipingMinigame _003C_003E4__this;

		public List<(int, int)> stack;
	}

	private sealed class _003CSpinItem_003Ed__14 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Transform item;

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

		public _003CSpinItem_003Ed__14(int _003C_003E1__state)
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

	private Cell[,] _cells;

	private List<(int, int)> _path;

	public int[] seeds;

	public static int seed;

	public bool IsTaskComplete
	{
		get
		{
			throw null;
		}
	}

	private void Start()
	{
		throw null;
	}

	public Direction FindDirection((int, int) start, (int, int) next)
	{
		throw null;
	}

	public void AssignDefaultCells()
	{
		throw null;
	}

	public void GenerateMazeDfsNonRecursive()
	{
		throw null;
	}

	public List<(int, int)> PathfindBfs(int xStart, int yStart, int xEnd, int yEnd)
	{
		throw null;
	}

	private static bool ValidIndex<T>(T[,] arr, (int, int) pos)
	{
		throw null;
	}

	public void CheckComplete()
	{
		throw null;
	}

	public void Complete()
	{
		throw null;
	}

	public IEnumerator SpinItem(Transform item)
	{
		throw null;
	}

	public ReconnectPipingMinigame()
	{
		throw null;
	}

	private List<(int, int)> _003CGenerateMazeDfsNonRecursive_003Eg__getNeighbours_007C9_0((int, int) position, ref _003C_003Ec__DisplayClass9_0 P_1)
	{
		throw null;
	}
}
