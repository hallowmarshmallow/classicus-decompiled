using System;
using UnityEngine;

public sealed class RunnerSpawnPoints : ScriptableObject
{
	[Serializable]
	public sealed class MapPoints
	{
		public string MapName;

		public Vector2[] Points;
	}

	public MapPoints[] Maps;

	public Vector2[] For(string mapName)
	{
		return null;
	}

	public string DescribeContents()
	{
		return null;
	}
}
