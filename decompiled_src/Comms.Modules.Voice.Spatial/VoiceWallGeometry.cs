using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Comms.Modules.Voice.Spatial;

public static class VoiceWallGeometry
{
	private struct WallSegment
	{
		private readonly Vector2 _003CA_003Ek__BackingField;

		private readonly Vector2 _003CB_003Ek__BackingField;

		public Vector2 A
		{
			get
			{
				throw null;
			}
		}

		public Vector2 B
		{
			get
			{
				throw null;
			}
		}

		public WallSegment(Vector2 a, Vector2 b)
		{
			throw null;
		}
	}

	public struct ServerWallSegment
	{
		private readonly Vector2 _003CA_003Ek__BackingField;

		private readonly Vector2 _003CB_003Ek__BackingField;

		public Vector2 A
		{
			get
			{
				throw null;
			}
		}

		public Vector2 B
		{
			get
			{
				throw null;
			}
		}

		public ServerWallSegment(Vector2 a, Vector2 b)
		{
			throw null;
		}
	}

	private static readonly List<WallSegment> Segments;

	private static readonly List<string> SourceNames;

	private static readonly RaycastHit2D[] RaycastHits;

	private static string _layoutKey;

	private static bool _built;

	private static int _colliderCount;

	private static string _geometrySource;

	private static string _003CLastBuildStatus_003Ek__BackingField;

	private static string _003CLastSvgPath_003Ek__BackingField;

	public static int SegmentCount
	{
		get
		{
			throw null;
		}
	}

	public static int ColliderCount
	{
		get
		{
			throw null;
		}
	}

	public static string LastBuildStatus
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

	public static string LastSvgPath
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

	public static void Tick(VoiceSettings settings)
	{
		throw null;
	}

	public static bool HasLineOfSight(Vector2 speakerPosition, Vector2 listenerPosition, bool wallsBlockVoice, VoiceSettings settings)
	{
		throw null;
	}

	public static string ExportSvg(VoiceSettings settings)
	{
		throw null;
	}

	public static bool TryCopyServerGeometry(VoiceSettings settings, List<ServerWallSegment> wallSegments, List<Vector2> snapPoints, out string layoutKey)
	{
		throw null;
	}

	public static void Reset()
	{
		throw null;
	}

	private static void EnsureBuilt(VoiceSettings settings, bool force)
	{
		throw null;
	}

	private static void Build(string layoutKey)
	{
		throw null;
	}

	private static void BuildFromShipLayerColliders()
	{
		throw null;
	}

	private static bool IsWallCandidate(Collider2D collider, Scene activeScene, int shipLayerMask)
	{
		throw null;
	}

	private static bool IsRaycastBlocked(Vector2 from, Vector2 to)
	{
		throw null;
	}

	private static bool IsLargeEnough(Bounds bounds)
	{
		throw null;
	}

	private static void AddColliderSegments(Collider2D collider, string source)
	{
		throw null;
	}

	private static void AddOpenPath(Vector2[] points, Vector2 offset, Transform transform, string source)
	{
		throw null;
	}

	private static void AddClosedPath(Vector2[] points, Vector2 offset, Transform transform, string source)
	{
		throw null;
	}

	private static void AddClosedPath(Span<Vector2> points, Transform transform, string source)
	{
		throw null;
	}

	private static void AddBoundsSegments(Bounds bounds, string source)
	{
		throw null;
	}

	private static void AddSegment(Vector2 a, Vector2 b, string source)
	{
		throw null;
	}

	private static Vector2 ToWorld(Vector2 local, Transform transform)
	{
		throw null;
	}

	private static void InsetLine(ref Vector2 from, ref Vector2 to)
	{
		throw null;
	}

	private static bool SegmentsIntersect(Vector2 a, Vector2 b, Vector2 c, Vector2 d)
	{
		throw null;
	}

	private static float Cross(Vector2 a, Vector2 b, Vector2 c)
	{
		throw null;
	}

	private static bool OnSegment(Vector2 a, Vector2 b, Vector2 p)
	{
		throw null;
	}

	private static void WriteSvg(string layoutKey)
	{
		throw null;
	}

	private static string BuildSvg(string layoutKey)
	{
		throw null;
	}

	private static Bounds CalculateBounds()
	{
		throw null;
	}

	private static Vector2 ToSvg(Vector2 point, Bounds bounds, float height)
	{
		throw null;
	}

	private static string GetLayoutKey()
	{
		throw null;
	}

	private static void AddSnapWhitelistPoints(List<Vector2> snapPoints)
	{
		throw null;
	}

	private static void AddUniquePoint(List<Vector2> points, Vector2 point)
	{
		throw null;
	}

	private static string GetHierarchyName(GameObject gameObject)
	{
		throw null;
	}

	private static string SanitizeFileName(string value)
	{
		throw null;
	}

	private static string XmlEscape(string value)
	{
		throw null;
	}

	private static string Format(float value)
	{
		throw null;
	}

	static VoiceWallGeometry()
	{
		throw null;
	}
}
