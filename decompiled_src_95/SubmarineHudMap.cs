using UnityEngine;

public class SubmarineHudMap : MonoBehaviour
{
	public enum Position
	{
		Up,
		Down
	}

	public GameObject UpArrow;

	public GameObject DownArrow;

	public GameObject MapHud;

	public GameObject DeadButtons;

	public Position pos;

	public SubmergedStatus Ship => null;

	public void OnEnable()
	{
	}

	public void TeleportUp()
	{
	}

	public void TeleportDown()
	{
	}

	public void MoveMapUp()
	{
	}

	public void MoveMapDown()
	{
	}
}
