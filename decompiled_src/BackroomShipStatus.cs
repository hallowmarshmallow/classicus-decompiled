using System;
using System.Collections;
using System.Collections.Generic;
using Hazel;
using UnityEngine;

public class BackroomShipStatus : ShipStatus
{
	private sealed class _003C_003Ec__DisplayClass9_0
	{
		public string blockName;

		public _003C_003Ec__DisplayClass9_0()
		{
			throw null;
		}

		internal bool _003CAddBlock_003Eb__0(MinecraftBlock b)
		{
			throw null;
		}
	}

	private sealed class _003CWaitForPlayer_003Ed__3 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public BackroomShipStatus _003C_003E4__this;

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

		public _003CWaitForPlayer_003Ed__3(int _003C_003E1__state)
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

	public MazeGenerator maze;

	public override void AddSystems()
	{
		throw null;
	}

	public IEnumerator WaitForPlayer()
	{
		throw null;
	}

	public void Update()
	{
		throw null;
	}

	public void StartMaze()
	{
		throw null;
	}

	public override void AddTasksFromList(ref int start, int count, List<byte> tasks, HashSet<TaskTypes> usedTaskTypes, List<NormalPlayerTask> unusedTasks)
	{
		throw null;
	}

	public override bool CheckTaskCompletion()
	{
		throw null;
	}

	public void RpcSyncMaze(int mazeRows, int mazeColumns, int seed, float mazeScale)
	{
		throw null;
	}

	public void AddBlock(string blockName, Vector2 pos)
	{
		throw null;
	}

	public void RpcAddBlock(string blockName, Vector2 pos)
	{
		throw null;
	}

	public override void HandleRpc(byte callId, MessageReader reader)
	{
		throw null;
	}

	public override bool Serialize(MessageWriter writer, bool initialState)
	{
		throw null;
	}

	public override void Deserialize(MessageReader reader, bool initialState)
	{
		throw null;
	}

	public BackroomShipStatus()
	{
		throw null;
	}
}
