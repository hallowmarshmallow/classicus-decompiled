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

		internal bool _003CResolveStartupServer_003Eb__24_2(ServerInfo s)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass23_0
	{
		public string name;

		public ServerInfo server;

		internal bool _003CAddVanillaServer_003Eb__0(string r)
		{
			return false;
		}

		internal bool _003CAddVanillaServer_003Eb__1(ServerInfo s)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass24_0
	{
		public string savedRegion;

		public string defaultRegion;

		internal bool _003CResolveStartupServer_003Eb__0(string r)
		{
			return false;
		}

		internal bool _003CResolveStartupServer_003Eb__3(ServerInfo s)
		{
			return false;
		}

		internal bool _003CResolveStartupServer_003Eb__1(ServerInfo s)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass29_0
	{
		public ServerInfo existingServer;

		internal bool _003CSetServers_003Eb__0(ServerInfo s)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass32_0
	{
		public ServerInfo server;

		internal bool _003CLoadServers_003Eb__0(ServerInfo s)
		{
			return false;
		}
	}

	private sealed class _003CInitialize_003Ed__21 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ServerManager _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CInitialize_003Ed__21(int _003C_003E1__state)
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

	private sealed class _003CWaitForServers_003Ed__28 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ServerManager _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CWaitForServers_003Ed__28(int _003C_003E1__state)
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

	private const string BuiltInServerListResource = "serverConnection-v2";

	private static readonly (string, string, ushort)[] FallbackServers;

	public const string MainServerRegionName = "Main Server";

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
			return _003CAvailableServers_003Ek__BackingField;
		}
		set
		{
			_003CAvailableServers_003Ek__BackingField = value;
		}
	}

	public ServerInfo CurrentServer
	{
		get
		{
			return _003CCurrentServer_003Ek__BackingField;
		}
		private set
		{
			_003CCurrentServer_003Ek__BackingField = value;
		}
	}

	public string OnlineNetAddress => null;

	public override void Awake()
	{
	}

	public IEnumerator Initialize()
	{
		return null;
	}

	private void LoadBuiltInServers()
	{
	}

	private void AddVanillaServer(string name, string ip, ushort port)
	{
	}

	private ServerInfo ResolveStartupServer()
	{
		return null;
	}

	private static string GetGeographicDefaultRegionName()
	{
		return null;
	}

	public void AddServer(string name, string ip, ushort port)
	{
	}

	public void SetServer(ServerInfo server)
	{
	}

	public IEnumerator WaitForServers()
	{
		return null;
	}

	internal void SetServers(ServerInfo[] servers)
	{
	}

	internal void RemoveServer(ServerInfo server)
	{
	}

	private void SaveServers(ServerInfo[] servers)
	{
	}

	private void LoadServers()
	{
	}

	internal bool TrackServerFailure(string networkAddress)
	{
		return false;
	}
}
