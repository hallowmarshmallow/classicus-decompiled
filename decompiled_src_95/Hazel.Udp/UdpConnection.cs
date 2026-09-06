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

			internal PingPacket _003C_002Ecctor_003Eb__5_0()
			{
				return null;
			}
		}

		private static readonly ObjectPool<PingPacket> PacketPool;

		public readonly Stopwatch Stopwatch;

		internal static PingPacket GetObject()
		{
			return null;
		}

		public void Recycle()
		{
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
		}

		internal void Set(ushort id, SmartBuffer data, int length, int timeout, Action ackCallback)
		{
		}

		public int Resend()
		{
			return 0;
		}

		public void Recycle()
		{
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

	public override float AveragePingMs => 0f;

	public override long OldestUnackedMs => 0L;

	public int KeepAliveInterval
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int MissingPingsUntilDisconnect
	{
		get
		{
			return _003CMissingPingsUntilDisconnect_003Ek__BackingField;
		}
		set
		{
			_003CMissingPingsUntilDisconnect_003Ek__BackingField = value;
		}
	}

	public UdpConnection(ILogger logger)
	{
	}

	internal static Socket CreateSocket(IPMode ipMode)
	{
		return null;
	}

	protected abstract void WriteBytesToConnection(SmartBuffer bytes, int length);

	public override SendErrors Send(MessageWriter msg)
	{
		return default(SendErrors);
	}

	protected virtual void HandleSend(byte[] data, byte sendOption, Action ackCallback = null)
	{
	}

	protected internal virtual void HandleReceive(MessageReader message, int bytesReceived)
	{
	}

	private void UnreliableSend(byte sendOption, byte[] data)
	{
	}

	private void UnreliableSend(byte sendOption, byte[] data, int offset, int length)
	{
	}

	private void InvokeDataReceived(SendOption sendOption, MessageReader buffer, int dataOffset, int bytesReceived)
	{
	}

	protected void SendHello(byte[] bytes, Action acknowledgeCallback)
	{
	}

	protected override void Dispose(bool disposing)
	{
	}

	protected void InitializeKeepAliveTimer()
	{
	}

	protected void HandleKeepAlive(object state)
	{
	}

	private void SendPing()
	{
	}

	protected void ResetKeepAliveTimer()
	{
	}

	private void DisposeKeepAliveTimer()
	{
	}

	internal int ManageReliablePackets()
	{
		return 0;
	}

	protected void AttachReliableID(SmartBuffer buffer, int offset, int length, Action ackCallback = null)
	{
	}

	private void ReliableSend(byte sendOption, byte[] data, Action ackCallback = null)
	{
	}

	private void ReliableMessageReceive(MessageReader message, int bytesReceived)
	{
	}

	private bool ProcessReliableReceive(byte[] bytes, int offset, out ushort id)
	{
		id = default(ushort);
		return false;
	}

	private void AcknowledgementMessageReceive(byte[] bytes, int bytesReceived)
	{
	}

	private void AcknowledgeMessageId(ushort id)
	{
	}

	private void SendAck(ushort id)
	{
	}

	private void DisposeReliablePackets()
	{
	}

	private SmartBuffer _003C_002Ector_003Eb__7_0()
	{
		return null;
	}

	private Packet _003C_002Ector_003Eb__7_1()
	{
		return null;
	}
}
