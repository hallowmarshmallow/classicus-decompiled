using System;
using System.Collections;
using System.Collections.Generic;
using Hazel.Udp;

namespace InnerNet;

public class InnerDiscover : DestroyableSingleton<InnerDiscover>
{
	private sealed class _003CRunClient_003Ed__11 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public InnerDiscover _003C_003E4__this;

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

		public _003CRunClient_003Ed__11(int _003C_003E1__state)
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

	private sealed class _003CRunServer_003Ed__8 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public InnerDiscover _003C_003E4__this;

		private float _003Ctimer_003E5__2;

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

		public _003CRunServer_003Ed__8(int _003C_003E1__state)
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

	private UdpBroadcastListener listener;

	private UdpBroadcaster sender;

	public int Port;

	public float Interval;

	private Action<BroadcastPacket> m_OnPacketGet;

	public event Action<BroadcastPacket> OnPacketGet
	{
		add
		{
			throw null;
		}
		remove
		{
			throw null;
		}
	}

	public void StartAsServer(string data)
	{
		throw null;
	}

	private IEnumerator RunServer()
	{
		throw null;
	}

	public void StopServer()
	{
		throw null;
	}

	public void StartAsClient()
	{
		throw null;
	}

	private IEnumerator RunClient()
	{
		throw null;
	}

	public void StopClient()
	{
		throw null;
	}

	public override void OnDestroy()
	{
		throw null;
	}

	public InnerDiscover()
	{
		throw null;
	}
}
