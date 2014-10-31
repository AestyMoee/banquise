using UnityEngine;
using System.Collections;

public class ropeBehavior : MonoBehaviour {
	
	public GameObject player1;
	public GameObject player2;
	public Camera camera;

	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update () {
		Vector3 newPos = Vector3.Lerp(player1.transform.position, player2.transform.position, 0.5f);
		newPos.y = 10;
		newPos.z = newPos.z - 10;
		camera.transform.position = newPos;
	}
}
