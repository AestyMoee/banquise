using UnityEngine;
using System.Collections;

public class Whale : MonoBehaviour {

	[HideInInspector]
	public bool Played = false;
	[HideInInspector]
	public bool Playing = false;

	private Animation WhaleAnimation;

	void Start()
	{
		WhaleAnimation = GetComponent<Animation> ();
	}

	void Update()
	{
		Playing = WhaleAnimation.isPlaying;
	}
}
