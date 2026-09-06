using UnityEngine;

namespace PowerTools;

public class SpriteAnimNodes : MonoBehaviour
{
	public static readonly int NUM_NODES;

	private Vector2 m_node0;

	private Vector2 m_node1;

	private Vector2 m_node2;

	private Vector2 m_node3;

	private Vector2 m_node4;

	private Vector2 m_node5;

	private Vector2 m_node6;

	private Vector2 m_node7;

	private Vector2 m_node8;

	private Vector2 m_node9;

	private float m_ang0;

	private float m_ang1;

	private float m_ang2;

	private float m_ang3;

	private float m_ang4;

	private float m_ang5;

	private float m_ang6;

	private float m_ang7;

	private float m_ang8;

	private float m_ang9;

	private SpriteRenderer m_spriteRenderer;

	public Vector3 GetPosition(int nodeId, bool ignoredPivot = false)
	{
		return default(Vector3);
	}

	public Vector3 GetLocalPosition(int nodeId, bool ignoredPivot = false)
	{
		return default(Vector3);
	}

	public float GetAngle(int nodeId)
	{
		return 0f;
	}

	public Vector2 GetPositionRaw(int nodeId)
	{
		return default(Vector2);
	}

	public float GetAngleRaw(int nodeId)
	{
		return 0f;
	}

	public void Reset()
	{
	}
}
