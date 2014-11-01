using UnityEngine;
using System.Collections;

public class DeathZone : MonoBehaviour {

	protected void OnTriggerEnter(Collider collider)
	{
		if (collider.gameObject.tag == "IceCube")
		{
			Destroy(collider.gameObject);
		}
	}
}
