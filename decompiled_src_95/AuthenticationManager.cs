using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;

public class AuthenticationManager : MonoBehaviour
{
	[StructLayout((LayoutKind)3)]
	private struct _003CAnonymousLoginClicked_003Ed__2 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public AuthenticationManager _003C_003E4__this;

		private LoaderSystem.Load _003C_003E7__wrap1;

		private TaskAwaiter _003C_003Eu__1;

		private void MoveNext()
		{
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}
	}

	private AsyncOperation _scene;

	private void Start()
	{
	}

	public void AnonymousLoginClicked()
	{
	}

	public void GooglePlayLoginClicked()
	{
	}
}
