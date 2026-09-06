using System.Collections.Generic;
using Comms.Modules.Voice.Spatial;
using Hazel;
using UnityEngine;

namespace Comms.Modules.Voice.Networking;

public static class VoiceMapGeometryRpc
{
	public static void Write(MessageWriter writer, string layoutKey, int uploadId, int totalSegments, int segmentOffset, List<VoiceWallGeometry.ServerWallSegment> wallSegments, int segmentCount, int totalSnapPoints, int snapPointOffset, List<Vector2> snapPoints, int snapPointCount)
	{
		throw null;
	}
}
