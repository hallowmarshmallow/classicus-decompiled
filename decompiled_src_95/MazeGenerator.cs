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
	}

	public void GenerateMaze(int rows, int columns)
	{
	}

	public void CreateLayout()
	{
	}

	public void RunAlgorithm()
	{
	}

	public List<Cell> GetUnvisitedNeighbours(Cell curCell)
	{
		return null;
	}

	public void CompareWalls(Cell cCell, Cell nCell)
	{
	}

	public void RemoveWall(CellScript cScript, int wallID)
	{
	}

	public void CreateCentre()
	{
	}

	public Vector2 GetRandomRoomCenterPosition()
	{
		return default(Vector2);
	}

	private Vector2 GetRoomCenterPosition(int roomColumn, int roomRow)
	{
		return default(Vector2);
	}

	public void GenerateCell(Vector2 pos, Vector2 keyPos)
	{
	}

	public void DeleteMaze()
	{
	}

	public void InitValues()
	{
	}

	public bool IsOdd(int value)
	{
		return false;
	}
}
