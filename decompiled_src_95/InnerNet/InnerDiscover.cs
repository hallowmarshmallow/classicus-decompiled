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

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CRunClient_003Ed__11(int _003C_003E1__state)
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

	private sealed class _003CRunServer_003Ed__8 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public InnerDiscover _003C_003E4__this;

		private float _003Ctimer_003E5__2;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CRunServer_003Ed__8(int _003C_003E1__state)
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

	private UdpBroadcastListener listener;

	private UdpBroadcaster sender;

	public int Port;

	public float Interval;

	private Action<BroadcastPacket> m_OnPacketGet;

	public event Action<BroadcastPacket> OnPacketGet
	{
		add
		{
		}
		remove
		{
		}
	}

	public void StartAsServer(string data)
	{
	}

	private IEnumerator RunServer()
	{
		return null;
	}

	public void StopServer()
	{
	}

	public void StartAsClient()
	{
	}

	private IEnumerator RunClient()
	{
		return null;
	}

	public void StopClient()
	{
	}

	public override void OnDestroy()
	{
	}
}
