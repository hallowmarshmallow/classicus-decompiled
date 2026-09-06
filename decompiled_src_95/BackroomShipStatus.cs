using System;
using System.Collections;
using System.Collections.Generic;
using Hazel;

public class BackroomShipStatus : ShipStatus
{
	private sealed class _003CWaitForPlayer_003Ed__3 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public BackroomShipStatus _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CWaitForPlayer_003Ed__3(int _003C_003E1__state)
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

	public MazeGenerator maze;

	public override void AddSystems()
	{
	}

	public IEnumerator WaitForPlayer()
	{
		return null;
	}

	public void Update()
	{
	}

	public void StartMaze()
	{
	}

	public override void AddTasksFromList(ref int start, int count, List<byte> tasks, HashSet<TaskTypes> usedTaskTypes, List<NormalPlayerTask> unusedTasks)
	{
	}

	public override bool CheckTaskCompletion()
	{
		return false;
	}

	public void RpcSyncMaze(int mazeRows, int mazeColumns, int seed, float mazeScale)
	{
	}

	public override void HandleRpc(byte callId, MessageReader reader)
	{
	}

	public override bool Serialize(MessageWriter writer, bool initialState)
	{
		return false;
	}

	public override void Deserialize(MessageReader reader, bool initialState)
	{
	}
}
