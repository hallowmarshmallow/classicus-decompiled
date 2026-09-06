using System;

namespace LevelImposter.Api;

[Serializable]
public class LIElement
{
	private Guid _003Cid_003Ek__BackingField;

	private string _003Cname_003Ek__BackingField;

	private string _003Ctype_003Ek__BackingField;

	private float _003Cx_003Ek__BackingField;

	private float _003Cy_003Ek__BackingField;

	private float _003Cz_003Ek__BackingField;

	private float _003CxScale_003Ek__BackingField;

	private float _003CyScale_003Ek__BackingField;

	private float _003Crotation_003Ek__BackingField;

	private LIProperties _003Cproperties_003Ek__BackingField;

	public Guid id => _003Cid_003Ek__BackingField;

	public string name => _003Cname_003Ek__BackingField;

	public string type => _003Ctype_003Ek__BackingField;

	public LIProperties properties => _003Cproperties_003Ek__BackingField;

	public override string ToString()
	{
		return null;
	}
}
