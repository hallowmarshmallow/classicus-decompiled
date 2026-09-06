public interface IUsable
{
	float PercentCool { get; }

	void SetOutline(bool on, bool mainTarget);

	float CanUse(GameData.PlayerInfo pc, out bool canUse, out bool couldUse);

	void Use();
}
