using System;
using UnityEngine;

public class ModInfo
{
	private string _003CName_003Ek__BackingField;

	private string _003CVersion_003Ek__BackingField;

	private string _003CDescription_003Ek__BackingField;

	private string _003CLocation_003Ek__BackingField;

	private bool _003CClientOnly_003Ek__BackingField;

	private string _003CLogoUrl_003Ek__BackingField;

	private Action<Sprite> m_SpriteChanged;

	private Sprite modSprite;

	public string Name
	{
		get
		{
			return _003CName_003Ek__BackingField;
		}
		set
		{
			_003CName_003Ek__BackingField = value;
		}
	}

	public string Version
	{
		set
		{
			_003CVersion_003Ek__BackingField = value;
		}
	}

	public string Description
	{
		get
		{
			return _003CDescription_003Ek__BackingField;
		}
		set
		{
			_003CDescription_003Ek__BackingField = value;
		}
	}

	public string Location
	{
		get
		{
			return _003CLocation_003Ek__BackingField;
		}
		set
		{
			_003CLocation_003Ek__BackingField = value;
		}
	}

	public bool ClientOnly
	{
		set
		{
			_003CClientOnly_003Ek__BackingField = value;
		}
	}

	public string LogoUrl
	{
		get
		{
			return _003CLogoUrl_003Ek__BackingField;
		}
		set
		{
			_003CLogoUrl_003Ek__BackingField = value;
		}
	}

	public Sprite ModSprite
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public bool IsRemote => false;

	public string FileName => null;

	public event Action<Sprite> SpriteChanged
	{
		add
		{
		}
		remove
		{
		}
	}

	public ModInfo(string name, string description, string version, string location, bool clientOnly, string logoUrl = null)
	{
	}
}
