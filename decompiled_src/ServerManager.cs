using System;
using System.Collections;
using System.Collections.Generic;

public class ServerManager : DestroyableSingleton<ServerManager>
{
	public class JsonServerInfo
	{
		public string name;

		public string ip;

		public int port;

		public JsonServerInfo(string name, string ip, int port)
		{
			throw null;
		}
	}

	private enum UpdateState
	{
		Connecting,
		Failed,
		Success
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Func<ServerInfo, bool> _003C_003E9__24_2;

		static _003C_003Ec()
		{
			throw null;
		}

		public _003C_003Ec()
		{
			throw null;
		}

		internal bool _003CResolveStartupServer_003Eb__24_2(ServerInfo s)
		{
			throw null;
		}
	}

	private sealed class _003C_003Ec__DisplayClass23_0
	{
		public string name;

		public ServerInfo server;

		public _003C_003Ec__DisplayClass23_0()
		{
			throw null;
		}

		internal bool _003CAddVanillaServer_003Eb__0(string r)
		{
			throw null;
		}

		internal bool _003CAddVanillaServer_003Eb__1(ServerInfo s)
		{
			throw null;
		}
	}

	private sealed class _003C_003Ec__DisplayClass24_0
	{
		public string savedRegion;

		public string defaultRegion;

		public _003C_003Ec__DisplayClass24_0()
		{
			throw null;
		}

		internal bool _003CResolveStartupServer_003Eb__0(string r)
		{
			throw null;
		}

		internal bool _003CResolveStartupServer_003Eb__3(ServerInfo s)
		{
			throw null;
		}

		internal bool _003CResolveStartupServer_003Eb__1(ServerInfo s)
		{
			throw null;
		}
	}

	private sealed class _003C_003Ec__DisplayClass29_0
	{
		public ServerInfo existingServer;

		public _003C_003Ec__DisplayClass29_0()
		{
			throw null;
		}

		internal bool _003CSetServers_003Eb__0(ServerInfo s)
		{
			throw null;
		}
	}

	private sealed class _003C_003Ec__DisplayClass32_0
	{
		public ServerInfo server;

		public _003C_003Ec__DisplayClass32_0()
		{
			throw null;
		}

		internal bool _003CLoadServers_003Eb__0(ServerInfo s)
		{
			throw null;
		}
	}

	private sealed class _003CInitialize_003Ed__21 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ServerManager _003C_003E4__this;

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

		public _003CInitialize_003Ed__21(int _003C_003E1__state)
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

	private sealed class _003CWaitForServers_003Ed__28 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ServerManager _003C_003E4__this;

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

		public _003CWaitForServers_003Ed__28(int _003C_003E1__state)
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

	private const string BuiltInServerListResource = "serverConnection-v2";

	private static readonly (string, string, ushort)[] FallbackServers;

	private const string MainServerRegionName = "Main Server";

	private static readonly string[] LegacyRegionNames;

	private static string _sessionServerName;

	private List<ServerInfo> _003CAvailableServers_003Ek__BackingField;

	private string serverInfoFile;

	private UpdateState state;

	public ushort annoucementPort;

	private ServerInfo _003CCurrentServer_003Ek__BackingField;

	public List<ServerInfo> AvailableServers
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

	public ServerInfo CurrentServer
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

	public string OnlineNetAddress
	{
		get
		{
			throw null;
		}
	}

	public override void Awake()
	{
		throw null;
	}

	public IEnumerator Initialize()
	{
		throw null;
	}

	private void LoadBuiltInServers()
	{
		throw null;
	}

	private void AddVanillaServer(string name, string ip, ushort port)
	{
		throw null;
	}

	private ServerInfo ResolveStartupServer()
	{
		throw null;
	}

	private static string GetGeographicDefaultRegionName()
	{
		throw null;
	}

	public void AddServer(string name, string ip, ushort port)
	{
		throw null;
	}

	public void SetServer(ServerInfo server)
	{
		throw null;
	}

	public IEnumerator WaitForServers()
	{
		throw null;
	}

	internal void SetServers(ServerInfo[] servers)
	{
		throw null;
	}

	internal void RemoveServer(ServerInfo server)
	{
		throw null;
	}

	private void SaveServers(ServerInfo[] servers)
	{
		throw null;
	}

	private void LoadServers()
	{
		throw null;
	}

	internal bool TrackServerFailure(string networkAddress)
	{
		throw null;
	}

	public ServerManager()
	{
		throw null;
	}

	static ServerManager()
	{
		throw null;
	}
}
