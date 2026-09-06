using System;
using System.Collections;
using System.Collections.Generic;

public class TutorialManager : DestroyableSingleton<TutorialManager>
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Action<PlayerControl> _003C_003E9__3_1;

		static _003C_003Ec()
		{
			throw null;
		}

		public _003C_003Ec()
		{
			throw null;
		}

		internal void _003CRunTutorial_003Eb__3_1(PlayerControl pc)
		{
			throw null;
		}
	}

	private sealed class _003C_003Ec__DisplayClass3_0
	{
		public byte practiceGameModeId;

		public _003C_003Ec__DisplayClass3_0()
		{
			throw null;
		}

		internal void _003CRunTutorial_003Eb__0(byte m)
		{
			throw null;
		}
	}

	private sealed class _003CCoAssignDummyTasks_003Ed__5 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		private byte[] _003CtaskIds_003E5__2;

		private float _003CstartedAt_003E5__3;

		private float _003CworkSeconds_003E5__4;

		private int _003Cframes_003E5__5;

		private int _003Cassigned_003E5__6;

		private string _003Csummary_003E5__7;

		private int _003Ci_003E5__8;

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

		public _003CCoAssignDummyTasks_003Ed__5(int _003C_003E1__state)
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

	private sealed class _003CRunTutorial_003Ed__3 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		private _003C_003Ec__DisplayClass3_0 _003C_003E8__1;

		public TutorialManager _003C_003E4__this;

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

		public _003CRunTutorial_003Ed__3(int _003C_003E1__state)
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

	public PlayerControl PlayerPrefab;

	private const float DummyTaskFrameBudgetSeconds = 0.006f;

	public override void Awake()
	{
		throw null;
	}

	public override void OnDestroy()
	{
		throw null;
	}

	private IEnumerator RunTutorial()
	{
		throw null;
	}

	private IEnumerator CoAssignDummyTasks()
	{
		throw null;
	}

	private static byte[] BuildDummyTaskIds()
	{
		throw null;
	}

	private static void AddTaskIndices(List<byte> ids, NormalPlayerTask[] tasks, int count)
	{
		throw null;
	}

	public TutorialManager()
	{
		throw null;
	}
}
