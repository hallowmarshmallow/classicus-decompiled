using System;

public class PolusShipStatus : ShipStatus
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Func<ISystemType, bool> _003C_003E9__1_0;

		internal bool _003CAddSystems_003Eb__1_0(ISystemType i)
		{
			return false;
		}
	}

	public override void Awake()
	{
	}

	public override void AddSystems()
	{
	}

	public override void SetupCustomStrings()
	{
	}
}
