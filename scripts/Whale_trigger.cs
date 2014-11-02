using UnityEngine;
using System.Collections;

public class Whale_trigger : MonoBehaviour {

	public GameObject Whale;
	//public AudioSource SoundSource;

	// Use this for initialization
	void Start () {
		Whale.GetComponent<MeshRenderer> ().enabled = false;
		//SoundSource.Stop ();
	}

	void OnTriggerEnter()
	{
		if (!Whale.GetComponent<Whale> ().Played && !Whale.GetComponent<Whale> ().Playing)
		{
			Whale.GetComponent<Whale> ().Played = true;
			Whale.GetComponent<MeshRenderer> ().enabled = true;
			Whale.GetComponent<Animation> ().Play ();
		
			//SoundSource.Play ();
		}


	}
}
