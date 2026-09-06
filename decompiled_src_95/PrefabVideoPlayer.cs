using UnityEngine;
using UnityEngine.Video;

public class PrefabVideoPlayer : MonoBehaviour
{
	public VideoClip videoClip;

	public bool playOnAwake;

	public bool loop;

	public int width;

	public int height;

	private VideoPlayer videoPlayer;

	private RenderTexture renderTexture;

	private void Awake()
	{
	}

	public void Play()
	{
	}

	public void Pause()
	{
	}

	public void Stop()
	{
	}

	private void OnDestroy()
	{
	}
}
