using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TaskFolder : MonoBehaviour
{
	public string FolderName;

	public TextMeshPro Text;

	public TaskAdderGame Parent;

	public List<TaskFolder> SubFolders;

	public List<PlayerTask> Children;

	public bool isRole;

	public void Start()
	{
	}

	public void OnClick()
	{
	}

	public void ShowRoles()
	{
	}

	internal List<TaskFolder> OrderBy()
	{
		return null;
	}
}
