using Hazel;

public abstract class OpenableDoor : SomeKindaDoor
{
	public int Id;

	public SystemTypes Room;

	public const float CooldownDuration = 30f;

	public const float ClosedDuration = 10f;

	public float ClosedTimer;

	public float CooldownTimer;

	public abstract bool IsOpen { get; }

	public abstract void Serialize(MessageWriter writer);

	public abstract void Deserialize(MessageReader reader);

	public abstract bool DoUpdate(float deltaTime);
}
