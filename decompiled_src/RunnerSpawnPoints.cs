using System;
using UnityEngine;

public sealed class RunnerSpawnPoints : ScriptableObject
{
	[Serializable]
	public sealed class MapPoints
	{
		public string MapName;

		public Vector2[] Points;

		public MapPoints()
		{
			throw null;
		}
	}

	public MapPoints[] Maps;

	public Vector2[] For(string mapName)
	{
		throw null;
	}

	public string DescribeContents()
	{
		throw null;
	}

	public RunnerSpawnPoints()
	{
		throw null;
	}
}
