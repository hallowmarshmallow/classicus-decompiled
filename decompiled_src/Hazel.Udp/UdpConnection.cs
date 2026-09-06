using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Sockets;
using System.Threading;

namespace Hazel.Udp;

public abstract class UdpConnection : NetworkConnection
{
	public class PingPacket : IRecyclable
	{
		[Serializable]
		private sealed class _003C_003Ec
		{
			public static readonly _003C_003Ec _003C_003E9;

			static _003C_003Ec()
			{
				throw null;
			}

			public _003C_003Ec()
			{
				throw null;
			}

			internal PingPacket _003C_002Ecctor_003Eb__5_0()
			{
				throw null;
			}
		}

		private static readonly ObjectPool<PingPacket> PacketPool;

		public readonly Stopwatch Stopwatch;

		internal static PingPacket GetObject()
		{
			throw null;
		}

		public void Recycle()
		{
			throw null;
		}

		public PingPacket()
		{
			throw null;
		}

		static PingPacket()
		{
			throw null;
		}
	}

	public class Packet : IRecyclable
	{
		public ushort Id;

		private SmartBuffer Data;

		private readonly UdpConnection Connection;

		private int Length;

		public int NextTimeoutMs;

		private bool Acknowledged;

		public Action AckCallback;

		public int Retransmissions;

		public Stopwatch Stopwatch;

		internal Packet(UdpConnection connection)
		{
			throw null;
		}

		internal void Set(ushort id, SmartBuffer data, int length, int timeout, Action ackCallback)
		{
			throw null;
		}

		public int Resend()
		{
			throw null;
		}

		public void Recycle()
		{
			throw null;
		}
	}

	protected readonly ObjectPool<SmartBuffer> bufferPool;

	public static readonly byte[] EmptyDisconnectBytes;

	protected readonly ILogger logger;

	internal ConcurrentDictionary<ushort, PingPacket> activePingPackets;

	private int keepAliveInterval;

	private int _003CMissingPingsUntilDisconnect_003Ek__BackingField;

	private int pingsSinceAck;

	private Timer keepAliveTimer;

	public readonly ObjectPool<Packet> PacketPool;

	public int ResendTimeoutMs;

	public int ResendLimit;

	public float ResendPingMultiplier;

	private int lastIDAllocated;

	internal ConcurrentDictionary<ushort, Packet> reliableDataPacketsSent;

	private HashSet<ushort> reliableDataPacketsMissing;

	protected ushort reliableReceiveLast;

	private object PingLock;

	private float _pingMs;

	private bool _pingSeeded;

	public int DisconnectTimeoutMs;

	public override float AveragePingMs
	{
		get
		{
			throw null;
		}
	}

	public int KeepAliveInterval
	{
		get
		{
			throw null;
		}
		set
		{
			throw null;
		}
	}

	public int MissingPingsUntilDisconnect
	{
		get
		{
			throw null;
		}
		set
		{
			throw null;
		}
	}

	public UdpConnection(ILogger logger)
	{
		throw null;
	}

	internal static Socket CreateSocket(IPMode ipMode)
	{
		throw null;
	}

	protected abstract void WriteBytesToConnection(SmartBuffer bytes, int length);

	public override SendErrors Send(MessageWriter msg)
	{
		throw null;
	}

	protected virtual void HandleSend(byte[] data, byte sendOption, Action ackCallback = null)
	{
		throw null;
	}

	protected internal virtual void HandleReceive(MessageReader message, int bytesReceived)
	{
		throw null;
	}

	private void UnreliableSend(byte sendOption, byte[] data)
	{
		throw null;
	}

	private void UnreliableSend(byte sendOption, byte[] data, int offset, int length)
	{
		throw null;
	}

	private void InvokeDataReceived(SendOption sendOption, MessageReader buffer, int dataOffset, int bytesReceived)
	{
		throw null;
	}

	protected void SendHello(byte[] bytes, Action acknowledgeCallback)
	{
		throw null;
	}

	protected override void Dispose(bool disposing)
	{
		throw null;
	}

	protected void InitializeKeepAliveTimer()
	{
		throw null;
	}

	protected void HandleKeepAlive(object state)
	{
		throw null;
	}

	private void SendPing()
	{
		throw null;
	}

	protected void ResetKeepAliveTimer()
	{
		throw null;
	}

	private void DisposeKeepAliveTimer()
	{
		throw null;
	}

	internal int ManageReliablePackets()
	{
		throw null;
	}

	protected void AttachReliableID(SmartBuffer buffer, int offset, int length, Action ackCallback = null)
	{
		throw null;
	}

	private void ReliableSend(byte sendOption, byte[] data, Action ackCallback = null)
	{
		throw null;
	}

	private void ReliableMessageReceive(MessageReader message, int bytesReceived)
	{
		throw null;
	}

	private bool ProcessReliableReceive(byte[] bytes, int offset, out ushort id)
	{
		throw null;
	}

	private void AcknowledgementMessageReceive(byte[] bytes, int bytesReceived)
	{
		throw null;
	}

	private void AcknowledgeMessageId(ushort id)
	{
		throw null;
	}

	private void SendAck(ushort id)
	{
		throw null;
	}

	private void DisposeReliablePackets()
	{
		throw null;
	}

	static UdpConnection()
	{
		throw null;
	}

	private SmartBuffer _003C_002Ector_003Eb__5_0()
	{
		throw null;
	}

	private Packet _003C_002Ector_003Eb__5_1()
	{
		throw null;
	}
}
