using UnityEngine;

public class ShipRoom : MonoBehaviour
{
	public SystemTypes RoomId;

	public SurvCamera survCamera;

	public Collider2D roomArea;

	public AudioClip AmbientSound;

	public float AmbientVolume;

	public float AmbientMaxDist;

	public Vector2 AmbientOffset;

	public SoundGroup FootStepSounds;

	public ShipRoom()
	{
		throw null;
	}
}
