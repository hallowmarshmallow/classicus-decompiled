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
				throw null;
			}
			set
			{
				throw null;
			}
		}

		public string CustomName
		{
			get
			{
				throw null;
			}
			private set
			{
				throw null;
			}
		}

		public MenuOption(StringNames title, string customName = "")
		{
			throw null;
		}
	}

	public class RoleMenuOption : MenuOption
	{
		private RoleBehaviour _003CRole_003Ek__BackingField;

		public RoleBehaviour Role
		{
			get
			{
				throw null;
			}
			set
			{
				throw null;
			}
		}

		public RoleMenuOption(StringNames title, string customName, RoleBehaviour role)
		{
			throw null;
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
				throw null;
			}
			set
			{
				throw null;
			}
		}

		public RoleBehaviour Role
		{
			get
			{
				throw null;
			}
			set
			{
				throw null;
			}
		}

		public RoleSettingMenuOption(StringNames title, RoleOption option, RoleBehaviour role)
		{
			throw null;
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
		throw null;
	}

	public void OnEnable()
	{
		throw null;
	}

	private bool ItemsAreAlive()
	{
		throw null;
	}

	private string BuildSignature()
	{
		throw null;
	}

	private static string RoleKey(RoleBehaviour role)
	{
		throw null;
	}

	public void RepositionChildren()
	{
		throw null;
	}

	public SettingMenu()
	{
		throw null;
	}
}
