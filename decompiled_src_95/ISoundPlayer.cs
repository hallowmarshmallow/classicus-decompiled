using UnityEngine;

public interface ISoundPlayer
{
	string Name { get; }

	AudioSource Player { get; }

	void Update(float dt);
}
