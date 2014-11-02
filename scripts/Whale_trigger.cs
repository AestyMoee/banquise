using UnityEngine;
using System.Collections;

public class Whale_trigger : MonoBehaviour {

	public GameObject Whale;

	private Whale WhaleClass;
	//public AudioSource SoundSource;

	// Use this for initialization
	void Start () {
		Whale.GetComponent<MeshRenderer> ().enabled = false;
		WhaleClass = Whale.GetComponent<Whale> ();
		//SoundSource.Stop ();
	}

	void OnTriggerEnter()
	{
		if (!WhaleClass.Played && !WhaleClass.Playing)
		{
			WhaleClass.Played = true;
			Whale.GetComponent<MeshRenderer> ().enabled = true;
			Whale.GetComponent<Animation> ().Play ();
		
			//SoundSource.Play ();
		}


	}
}
