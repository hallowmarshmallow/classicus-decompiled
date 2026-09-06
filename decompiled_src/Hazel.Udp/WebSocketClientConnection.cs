using System.Collections.Concurrent;
using System.Diagnostics;
using System.Net.WebSockets;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;

namespace Hazel.Udp;

public class WebSocketClientConnection : UdpConnection
{
	private sealed class _003C_003Ec__DisplayClass21_0
	{
		[StructLayout((LayoutKind)3)]
		private struct _003C_003CBackendConnect_003Eb__0_003Ed : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder _003C_003Et__builder;

			public _003C_003Ec__DisplayClass21_0 _003C_003E4__this;

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

		public WebSocketClientConnection _003C_003E4__this;

		public string wsUrl;

		public CancellationToken token;

		public _003C_003Ec__DisplayClass21_0()
		{
			throw null;
		}

		internal Task _003CBackendConnect_003Eb__0()
		{
			throw null;
		}
	}

	[StructLayout((LayoutKind)3)]
	private struct _003CRunReceiveLoop_003Ed__23 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public WebSocketClientConnection _003C_003E4__this;

		public CancellationToken token;

		private byte[] _003Cbuffer_003E5__2;

		private int _003Ccount_003E5__3;

		private TaskAwaiter<WebSocketReceiveResult> _003C_003Eu__1;

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
	private struct _003CRunSendLoop_003Ed__22 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public WebSocketClientConnection _003C_003E4__this;

		public CancellationToken token;

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

	public int ConnectTimeoutMs;

	private readonly string url;

	private byte[] helloBytes;

	private bool helloSent;

	private readonly Stopwatch clock;

	private long connectStartedMs;

	private long lastKeepAliveMs;

	private ClientWebSocket clientWebSocket;

	private CancellationTokenSource cancellation;

	private readonly ConcurrentQueue<byte[]> receiveQueue;

	private readonly ConcurrentQueue<byte[]> sendQueue;

	private SemaphoreSlim sendSignal;

	private bool wsOpen;

	private bool wsClosed;

	public WebSocketClientConnection(ILogger logger, string url)
	{
		throw null;
	}

	public override void ConnectAsync(byte[] bytes = null)
	{
		throw null;
	}

	public void Poll()
	{
		throw null;
	}

	protected override void WriteBytesToConnection(SmartBuffer bytes, int length)
	{
		throw null;
	}

	protected override bool SendDisconnect(MessageWriter data = null)
	{
		throw null;
	}

	protected override void Dispose(bool disposing)
	{
		throw null;
	}

	private void BackendConnect(string wsUrl)
	{
		throw null;
	}

	private Task RunSendLoop(CancellationToken token)
	{
		throw null;
	}

	private Task RunReceiveLoop(CancellationToken token)
	{
		throw null;
	}

	private void BackendUpdate()
	{
		throw null;
	}

	private bool BackendIsOpen()
	{
		throw null;
	}

	private bool BackendIsClosed()
	{
		throw null;
	}

	private void BackendSend(byte[] data, int length)
	{
		throw null;
	}

	private byte[] BackendReceive()
	{
		throw null;
	}

	private void BackendClose()
	{
		throw null;
	}

	private void _003CPoll_003Eb__10_0()
	{
		throw null;
	}
}
