using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TaskAdderGame : Minigame
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Func<TaskFolder, string> _003C_003E9__17_0;

		public static Func<RoleBehaviour, bool> _003C_003E9__21_0;

		public static Func<RoleBehaviour, bool> _003C_003E9__21_1;

		public static Func<RoleBehaviour, bool> _003C_003E9__21_2;

		public static Func<RoleBehaviour, bool> _003C_003E9__21_3;

		public static Func<PlayerTask, string> _003C_003E9__24_0;

		internal string _003CBegin_003Eb__17_0(TaskFolder f)
		{
			return null;
		}

		internal bool _003COpenRoleFolder_003Eb__21_0(RoleBehaviour r)
		{
			return false;
		}

		internal bool _003COpenRoleFolder_003Eb__21_1(RoleBehaviour r)
		{
			return false;
		}

		internal bool _003COpenRoleFolder_003Eb__21_2(RoleBehaviour r)
		{
			return false;
		}

		internal bool _003COpenRoleFolder_003Eb__21_3(RoleBehaviour r)
		{
			return false;
		}

		internal string _003CShowFolder_003Eb__24_0(PlayerTask t)
		{
			return null;
		}
	}

	public TextRenderer PathText;

	public TaskFolder RootFolderPrefab;

	public TaskAddButton TaskPrefab;

	public Transform TaskParent;

	public TaskAddButton RoleButton;

	public TaskAddButton OptionsButton;

	public CustomPlayerMenu Options;

	public List<TaskFolder> Heirarchy;

	public List<Transform> ActiveItems;

	public float folderWidth;

	public float fileWidth;

	public float lineWidth;

	public float lineHeight;

	public TextMeshPro TitleText;

	public Scroller scroller;

	public Collider2D ClickMask;

	private TaskFolder Root;

	public override void Begin(PlayerTask t)
	{
	}

	public void ApplyClickMask()
	{
	}

	private TaskFolder AddFolder(string folderName, bool isRole, TaskFolder rootFolder, Dictionary<SystemTypes, TaskFolder> folders)
	{
		return null;
	}

	private void PopulateRoot(TaskFolder rootFolder, Dictionary<SystemTypes, TaskFolder> folders, NormalPlayerTask[] taskList)
	{
	}

	public void OpenRoleFolder()
	{
	}

	public void GoToRoot()
	{
	}

	public void GoUpOne()
	{
	}

	public void ShowFolder(TaskFolder taskFolder)
	{
	}

	private void AddFileAsChild(TaskAddButton item, ref float xCursor, ref float yCursor)
	{
	}
}
