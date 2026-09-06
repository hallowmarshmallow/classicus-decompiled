using System.Collections.Generic;
using System.Text;
using UnityEngine;

public class SettingMenu : MonoBehaviour
{
	public class MenuOption
	{
		private StringNames _003CTitle_003Ek__BackingField;

		private string _003CCustomName_003Ek__BackingField;

		public StringNames Title
		{
			get
			{
				return _003CTitle_003Ek__BackingField;
			}
			set
			{
				_003CTitle_003Ek__BackingField = value;
			}
		}

		public string CustomName
		{
			get
			{
				return _003CCustomName_003Ek__BackingField;
			}
			private set
			{
				_003CCustomName_003Ek__BackingField = value;
			}
		}

		public MenuOption(StringNames title, string customName = "")
		{
		}
	}

	public class RoleMenuOption : MenuOption
	{
		private RoleBehaviour _003CRole_003Ek__BackingField;

		public RoleBehaviour Role
		{
			get
			{
				return _003CRole_003Ek__BackingField;
			}
			set
			{
				_003CRole_003Ek__BackingField = value;
			}
		}

		public RoleMenuOption(StringNames title, string customName, RoleBehaviour role)
			: base(default(StringNames), null)
		{
		}
	}

	public class RoleSettingMenuOption : MenuOption
	{
		private RoleOption _003COption_003Ek__BackingField;

		private RoleBehaviour _003CRole_003Ek__BackingField;

		public RoleOption Option
		{
			get
			{
				return _003COption_003Ek__BackingField;
			}
			set
			{
				_003COption_003Ek__BackingField = value;
			}
		}

		public RoleBehaviour Role
		{
			get
			{
				return _003CRole_003Ek__BackingField;
			}
			set
			{
				_003CRole_003Ek__BackingField = value;
			}
		}

		public RoleSettingMenuOption(StringNames title, RoleOption option, RoleBehaviour role)
			: base(default(StringNames), null)
		{
		}
	}

	public List<MenuOption> AllOptions;

	public List<Transform> AllItems;

	public float YStart;

	public float YOffset;

	public NumberOption keyvaluePrefab;

	public RoleGameOption roleOptionPrefab;

	public RoleSettingGameOption roleSettingPrefab;

	public GameOptionsMenu menu;

	public Collider2D ClickMask;

	private readonly List<RoleGameOption> roleRows;

	private readonly List<RoleSettingGameOption> roleSettingRows;

	private readonly StringBuilder signatureBuilder;

	private string builtSignature;

	private Scroller scroller;

	public virtual void SetupFromData()
	{
	}

	public void OnEnable()
	{
	}

	private bool ItemsAreAlive()
	{
		return false;
	}

	private string BuildSignature()
	{
		return null;
	}

	private static string RoleKey(RoleBehaviour role)
	{
		return null;
	}

	public void RepositionChildren()
	{
	}
}
