using System;
using System.Collections.Generic;
using UnityEngine;

public class MazeGenerator : MonoBehaviour
{
	public class Cell
	{
		public Vector2 gridPos;

		public GameObject cellObject;

		public CellScript cScript;

		public Cell()
		{
			throw null;
		}
	}

	public int mazeRows;

	public int mazeColumns;

	public float mazeScale;

	private GameObject cellPrefab;

	public bool disableCellSprite;

	public int seed;

	private int centreSize;

	private Dictionary<Vector2, Cell> allCells;

	private List<Cell> unvisited;

	private List<Cell> stack;

	private Cell[] centreCells;

	private Cell currentCell;

	private Cell checkCell;

	private Vector2[] neighbourPositions;

	private float cellSize;

	private GameObject mazeParent;

	private System.Random random;

	public void GenerateDefaultMaze()
	{
		throw null;
	}

	public void GenerateMaze(int rows, int columns)
	{
		throw null;
	}

	public void CreateLayout()
	{
		throw null;
	}

	public void RunAlgorithm()
	{
		throw null;
	}

	public List<Cell> GetUnvisitedNeighbours(Cell curCell)
	{
		throw null;
	}

	public void CompareWalls(Cell cCell, Cell nCell)
	{
		throw null;
	}

	public void RemoveWall(CellScript cScript, int wallID)
	{
		throw null;
	}

	public void CreateCentre()
	{
		throw null;
	}

	public Vector2 GetRandomRoomCenterPosition()
	{
		throw null;
	}

	private Vector2 GetRoomCenterPosition(int roomColumn, int roomRow)
	{
		throw null;
	}

	public void GenerateCell(Vector2 pos, Vector2 keyPos)
	{
		throw null;
	}

	public void DeleteMaze()
	{
		throw null;
	}

	public void InitValues()
	{
		throw null;
	}

	public bool IsOdd(int value)
	{
		throw null;
	}

	public MazeGenerator()
	{
		throw null;
	}
}
