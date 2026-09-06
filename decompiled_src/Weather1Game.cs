using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class Weather1Game : Minigame
{
	private static int[] BarrierValidX;

	private static int[] BarrierValidY;

	private const int MinX = -10;

	private const int MaxX = 8;

	private const int MinY = -3;

	private const int MaxY = 3;

	public Tilemap BarrierMap;

	public Tile fillTile;

	public Tile controlTile;

	public Tile barrierTile;

	public SpriteRenderer pulseCircle1;

	public SpriteRenderer pulseCircle2;

	public AudioClip NodeMove;

	private Controller control;

	private bool inControl;

	private Vector3Int controlTilePos;

	private static Vector3Int[] Directions;

	private float moveCooldown;

	public void Start()
	{
		throw null;
	}

	private bool SolveMaze(Vector3Int curPos, HashSet<Vector3Int> solution)
	{
		throw null;
	}

	public void Update()
	{
		throw null;
	}

	private void FillLine(Vector3Int controlTilePos, Vector3Int touchCellPos)
	{
		throw null;
	}

	private bool AnythingBetween(Vector3Int controlTilePos, Vector3Int touchCellPos)
	{
		throw null;
	}

	private bool PointIsValid(Vector3Int touchCellPos)
	{
		throw null;
	}

	private bool Contains<T>(T[] self, T item) where T : IComparable
	{
		throw null;
	}

	public Weather1Game()
	{
		throw null;
	}

	static Weather1Game()
	{
		throw null;
	}
}
