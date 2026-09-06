using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public sealed class RunnerBotNav
{
	public enum LinkKind : byte
	{
		Ladder = 1,
		Platform,
		Elevator
	}

	public struct Link
	{
		public Vector2 A;

		public Vector2 B;

		public LinkKind Kind;

		public ElevatorTransition ElevatorA;

		public ElevatorTransition ElevatorB;
	}

	private sealed class _003CBridgeIslands_003Ed__62 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public RunnerBotNav _003C_003E4__this;

		public HashSet<Collider2D> scenery;

		private Dictionary<long, int> _003Cattempts_003E5__2;

		private HashSet<long> _003Cdone_003E5__3;

		private int _003Cprobes_003E5__4;

		private int _003Cy_003E5__5;

		private int _003Cx_003E5__6;

		private int _003Ci_003E5__7;

		private int _003Cia_003E5__8;

		private int _003Co_003E5__9;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CBridgeIslands_003Ed__62(int _003C_003E1__state)
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

	private sealed class _003CCoBake_003Ed__53 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public RunnerBotNav _003C_003E4__this;

		private int _003Ctotal_003E5__2;

		private HashSet<Collider2D> _003Cscenery_003E5__3;

		private int _003Cprobes_003E5__4;

		private int _003Ci_003E5__5;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CCoBake_003Ed__53(int _003C_003E1__state)
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

	private sealed class _003CCoRefloodTraversed_003Ed__76 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public RunnerBotNav _003C_003E4__this;

		private int _003Copened_003E5__2;

		private int _003Cbefore_003E5__3;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CCoRefloodTraversed_003Ed__76(int _003C_003E1__state)
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

	private sealed class _003CFloodIslands_003Ed__57 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public RunnerBotNav _003C_003E4__this;

		private int _003Ctotal_003E5__2;

		private int[] _003Cmap_003E5__3;

		private int _003Ccount_003E5__4;

		private Queue<int> _003Cflood_003E5__5;

		private int _003Ci_003E5__6;

		private int _003Cid_003E5__7;

		private int _003Csteps_003E5__8;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CFloodIslands_003Ed__57(int _003C_003E1__state)
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

	public const float CellSize = 0.25f;

	private const float ProbeRadius = 0.22f;

	private const float BridgeClearance = 0.22f;

	private const float GapProbeRadius = 0.17f;

	private const int GapStepCost = 900;

	private const int MaxGapDepth = 4;

	private const int MaxGapProbesPerSearch = 48;

	private const int MaxGapProbesPerBake = 3000;

	private const byte GapEndpointBit = 64;

	private const int MaxBridgeAttempts = 12;

	private const int MaxSnapProbes = 24;

	private const int MaxCellsPerAxis = 480;

	private const int ProbesPerFrame = 4000;

	private const int MaxExpand = 12000;

	private bool _003CReady_003Ek__BackingField;

	private int _003CIslandCount_003Ek__BackingField;

	public readonly List<Link> Links;

	private int _w;

	private int _h;

	private Vector2 _origin;

	private byte[] _cells;

	private int[] _island;

	private int[] _islandScratch;

	private int _bridgesCarved;

	private byte[] _gapEdge;

	private int _gapProbesThisBake;

	private int _gapPassed;

	private int _gapBlocked;

	private readonly HashSet<Collider2D> _scenery;

	private int[] _gCost;

	private int[] _parent;

	private int[] _stampArr;

	private int _stamp;

	private float[] _avoidExpire;

	private int[] _avoidCost;

	private static readonly Collider2D[] ProbeBuffer;

	private static readonly RaycastHit2D[] LosBuffer;

	private static ContactFilter2D _probeFilter;

	private static bool _probeFilterReady;

	private static readonly int[] BridgeDX;

	private static readonly int[] BridgeDY;

	private const float MaxTraversedSpan = 0.9f;

	private bool _traversedDirty;

	private int _traversedOpened;

	private bool _reflooding;

	private readonly List<int> _trace;

	private static readonly int[] DX;

	private static readonly int[] DY;

	private readonly List<long> _heapKeys;

	public bool Ready
	{
		get
		{
			return _003CReady_003Ek__BackingField;
		}
		private set
		{
			_003CReady_003Ek__BackingField = value;
		}
	}

	public int IslandCount
	{
		get
		{
			return _003CIslandCount_003Ek__BackingField;
		}
		private set
		{
			_003CIslandCount_003Ek__BackingField = value;
		}
	}

	public int GapEdgesPassed => 0;

	public int GapEdgesBlocked => 0;

	public bool NeedsTraversedReflood => false;

	private static void GrowBounds(ref Bounds bounds, ref bool any, Vector3 point)
	{
	}

	private static void EnsureProbeFilter()
	{
	}

	public IEnumerator CoBake()
	{
		return null;
	}

	public int IslandOf(Vector2 p)
	{
		return 0;
	}

	private static byte ProbeAt(Vector2 p, float radius, HashSet<Collider2D> scenery)
	{
		return 0;
	}

	public bool IsClear(Vector2 p, float radius)
	{
		return false;
	}

	private IEnumerator FloodIslands()
	{
		return null;
	}

	private static bool CorridorFits(Vector2 a, Vector2 b, float radius, HashSet<Collider2D> scenery)
	{
		return false;
	}

	private bool GapPassable(int a, int b, int dir, ref int searchProbes)
	{
		return false;
	}

	private IEnumerator BridgeIslands(HashSet<Collider2D> scenery)
	{
		return null;
	}

	private static bool SeesFrom(Vector2 freeCell, Vector2 p)
	{
		return false;
	}

	private void BuildLinks()
	{
	}

	private void CarveDoorway(ElevatorTransition ev)
	{
	}

	private int CarveCorridor(Vector2 from, Vector2 to, float halfWidth)
	{
		return 0;
	}

	private int CarveWalkable(Vector2 center, float radius)
	{
		return 0;
	}

	public bool MarkTraversed(Vector2 from, Vector2 to)
	{
		return false;
	}

	private int CarveTraversed(Vector2 from, Vector2 to)
	{
		return 0;
	}

	public IEnumerator CoRefloodTraversed()
	{
		return null;
	}

	public bool RandomWalkableWorld(out Vector2 world)
	{
		world = default(Vector2);
		return false;
	}

	public void AddAvoidance(Vector2 center, float radius, int extraCost, float durationSeconds)
	{
	}

	public bool NearestWalkableWorld(Vector2 p, out Vector2 world)
	{
		world = default(Vector2);
		return false;
	}

	private Vector2 CellCenter(int index)
	{
		return default(Vector2);
	}

	private int CellAt(Vector2 p)
	{
		return 0;
	}

	private int NearestWalkable(Vector2 p)
	{
		return 0;
	}

	public bool TryFindPath(Vector2 from, Vector2 to, List<Vector2> outPath)
	{
		return false;
	}

	private bool Search(int start, int goal, Vector2 to, List<Vector2> outPath, bool allowGaps)
	{
		return false;
	}

	private int Heuristic(int a, int b)
	{
		return 0;
	}

	private void PushOpen(int index, int fScore)
	{
	}

	private int PopOpen()
	{
		return 0;
	}
}
