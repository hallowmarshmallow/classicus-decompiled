using UnityEngine;

public class StaticDoor : MonoBehaviour
{
	public Sprite OpenDoorImage;

	public Sprite CloseDoorImage;

	private bool _003CIsOpen_003Ek__BackingField;

	public bool IsOpen
	{
		get
		{
			return _003CIsOpen_003Ek__BackingField;
		}
		private set
		{
			_003CIsOpen_003Ek__BackingField = value;
		}
	}

	public void SetOpen(bool isOpen)
	{
	}
}
