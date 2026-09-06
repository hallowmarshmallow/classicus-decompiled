using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Comms.Modules.Voice.Spatial;

public static class VoiceWallGeometry
{
	private struct WallSegment(Vector2 a, Vector2 b)
	{
		private readonly Vector2 _003CA_003Ek__BackingField = default(Vector2);

		private readonly Vector2 _003CB_003Ek__BackingField = default(Vector2);

		public Vector2 A => _003CA_003Ek__BackingField;

		public Vector2 B => _003CB_003Ek__BackingField;
	}

	public struct ServerWallSegment(Vector2 a, Vector2 b)
	{
		private readonly Vector2 _003CA_003Ek__BackingField = default(Vector2);

		private readonly Vector2 _003CB_003Ek__BackingField = default(Vector2);

		public Vector2 A => _003CA_003Ek__BackingField;

		public Vector2 B => _003CB_003Ek__BackingField;
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

	public static int SegmentCount => 0;

	public static int ColliderCount => 0;

	public static string LastBuildStatus
	{
		get
		{
			return _003CLastBuildStatus_003Ek__BackingField;
		}
		private set
		{
			_003CLastBuildStatus_003Ek__BackingField = value;
		}
	}

	public static string LastSvgPath
	{
		get
		{
			return _003CLastSvgPath_003Ek__BackingField;
		}
		private set
		{
			_003CLastSvgPath_003Ek__BackingField = value;
		}
	}

	public static void Tick(VoiceSettings settings)
	{
	}

	public static bool HasLineOfSight(Vector2 speakerPosition, Vector2 listenerPosition, bool wallsBlockVoice, VoiceSettings settings)
	{
		return false;
	}

	public static string ExportSvg(VoiceSettings settings)
	{
		return null;
	}

	public static bool TryCopyServerGeometry(VoiceSettings settings, List<ServerWallSegment> wallSegments, List<Vector2> snapPoints, out string layoutKey)
	{
		layoutKey = null;
		return false;
	}

	public static void Reset()
	{
	}

	private static void EnsureBuilt(VoiceSettings settings, bool force)
	{
	}

	private static void Build(string layoutKey)
	{
	}

	private static void BuildFromShipLayerColliders()
	{
	}

	private static bool IsWallCandidate(Collider2D collider, Scene activeScene, int shipLayerMask)
	{
		return false;
	}

	private static bool IsRaycastBlocked(Vector2 from, Vector2 to)
	{
		return false;
	}

	private static bool IsLargeEnough(Bounds bounds)
	{
		return false;
	}

	private static void AddColliderSegments(Collider2D collider, string source)
	{
	}

	private static void AddOpenPath(Vector2[] points, Vector2 offset, Transform transform, string source)
	{
	}

	private static void AddClosedPath(Vector2[] points, Vector2 offset, Transform transform, string source)
	{
	}

	private static void AddClosedPath(Span<Vector2> points, Transform transform, string source)
	{
	}

	private static void AddBoundsSegments(Bounds bounds, string source)
	{
	}

	private static void AddSegment(Vector2 a, Vector2 b, string source)
	{
	}

	private static Vector2 ToWorld(Vector2 local, Transform transform)
	{
		return default(Vector2);
	}

	private static void InsetLine(ref Vector2 from, ref Vector2 to)
	{
	}

	private static bool SegmentsIntersect(Vector2 a, Vector2 b, Vector2 c, Vector2 d)
	{
		return false;
	}

	private static float Cross(Vector2 a, Vector2 b, Vector2 c)
	{
		return 0f;
	}

	private static bool OnSegment(Vector2 a, Vector2 b, Vector2 p)
	{
		return false;
	}

	private static void WriteSvg(string layoutKey)
	{
	}

	private static string BuildSvg(string layoutKey)
	{
		return null;
	}

	private static Bounds CalculateBounds()
	{
		return default(Bounds);
	}

	private static Vector2 ToSvg(Vector2 point, Bounds bounds, float height)
	{
		return default(Vector2);
	}

	private static string GetLayoutKey()
	{
		return null;
	}

	private static void AddSnapWhitelistPoints(List<Vector2> snapPoints)
	{
	}

	private static void AddUniquePoint(List<Vector2> points, Vector2 point)
	{
	}

	private static string GetHierarchyName(GameObject gameObject)
	{
		return null;
	}

	private static string SanitizeFileName(string value)
	{
		return null;
	}

	private static string XmlEscape(string value)
	{
		return null;
	}

	private static string Format(float value)
	{
		return null;
	}
}
