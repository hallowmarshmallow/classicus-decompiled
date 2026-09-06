public class RoleOption
{
	public enum ValueTypes
	{
		Int,
		Float,
		Bool
	}

	private string _003CDisplayName_003Ek__BackingField;

	private object _003CValue_003Ek__BackingField;

	private ValueTypes _003CValueType_003Ek__BackingField;

	private FloatRange _003CFloatRange_003Ek__BackingField;

	private float _003CDecreaseIncrease_003Ek__BackingField;

	private bool _003CZeroMeansInfinity_003Ek__BackingField;

	public string DisplayName => _003CDisplayName_003Ek__BackingField;

	public object Value
	{
		get
		{
			return _003CValue_003Ek__BackingField;
		}
		set
		{
			_003CValue_003Ek__BackingField = value;
		}
	}

	public float FloatValue => 0f;

	public ValueTypes ValueType => _003CValueType_003Ek__BackingField;

	public FloatRange FloatRange => _003CFloatRange_003Ek__BackingField;

	public float DecreaseIncrease => _003CDecreaseIncrease_003Ek__BackingField;

	public bool ZeroMeansInfinity => _003CZeroMeansInfinity_003Ek__BackingField;
}
