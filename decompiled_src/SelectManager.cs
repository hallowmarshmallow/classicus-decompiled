using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using UnityEngine;

public class SelectManager : MonoBehaviour
{
	[StructLayout((LayoutKind)3)]
	private struct _003CDeleteClicked_003Ed__19 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public SelectManager _003C_003E4__this;

		private LoaderSystem.Load _003C_003E7__wrap1;

		private TaskAwaiter _003C_003Eu__1;

		private void MoveNext()
		{
			throw null;
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			throw null;
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}
	}

	[StructLayout((LayoutKind)3)]
	private struct _003CLoadSlotAsync_003Ed__14 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public SelectManager _003C_003E4__this;

		public int index;

		private CharacterSlot _003C_003E7__wrap1;

		private int _003C_003E7__wrap2;

		private TaskAwaiter<CharacterData> _003C_003Eu__1;

		private void MoveNext()
		{
			throw null;
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			throw null;
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}
	}

	[StructLayout((LayoutKind)3)]
	private struct _003CLoadSlots_003Ed__13 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public SelectManager _003C_003E4__this;

		private LoaderSystem.Load _003C_003E7__wrap1;

		private TaskAwaiter<List<CharacterData>> _003C_003Eu__1;

		private void MoveNext()
		{
			throw null;
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			throw null;
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}
	}

	[StructLayout((LayoutKind)3)]
	private struct _003CRefreshSlot_003Ed__17 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public SelectManager _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		private void MoveNext()
		{
			throw null;
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			throw null;
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}
	}

	private CharacterSlot _slotPrefab;

	private ScriptablePersistentData _persistentData;

	private Transform _slotsParent;

	private Animator _interfaceAnimator;

	private GameObject _characterActions;

	private readonly List<CharacterSlot> _spawnedSlots;

	private SlotData _003CSelectedData_003Ek__BackingField;

	public SlotData SelectedData
	{
		get
		{
			throw null;
		}
		private set
		{
			throw null;
		}
	}

	private void Awake()
	{
		throw null;
	}

	private void OnDestroy()
	{
		throw null;
	}

	private void Start()
	{
		throw null;
	}

	private void LoadSlots()
	{
		throw null;
	}

	private Task LoadSlotAsync(int index)
	{
		throw null;
	}

	private void DeleteSlots()
	{
		throw null;
	}

	private void SlotSelected(SlotData data)
	{
		throw null;
	}

	public Task RefreshSlot()
	{
		throw null;
	}

	public void PlayClicked()
	{
		throw null;
	}

	public void DeleteClicked()
	{
		throw null;
	}

	public SelectManager()
	{
		throw null;
	}
}
