using UnityEngine;

public class exit_button : MonoBehaviour {

	public void ExitApplication()
	{
		Debug.Log ("Exit button clicked");
		Application.Quit ();
	}
}
