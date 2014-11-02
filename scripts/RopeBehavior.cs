using UnityEngine;
using System.Collections;

public class RopeBehavior : MonoBehaviour {
	
	public GameObject player1;
	public GameObject player2;
	public Camera camera;
	public float slowDistance;

	// Use this for initialization
	void Start ()
	{
		float distancePlayers = Vector3.Distance(player1.transform.position,player2.transform.position);
	}

	// Update is called once per frame
	void Update ()
	{
		Vector3 newPos = Vector3.Lerp(player1.transform.position, player2.transform.position, 0.5f);
		newPos.y = 20;
		newPos.z += 20;
		camera.transform.position = newPos;


		/*float distancePlayers = Vector3.Distance(player1.transform.position,player2.transform.position);
		Debug.Log(distancePlayers);
		if(distancePlayers > slowDistance)
				player1.SendMessage("farfaraway",distancePlayers);*/
	}
}
