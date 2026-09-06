using System;

[Serializable]
public class GitHubRelease
{
	public string tag_name;

	public string name;

	public string body;

	public GitHubReleaseAsset[] assets;
}
