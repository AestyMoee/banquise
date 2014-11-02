using UnityEngine;
using System.Collections;

public enum EIceCubeHP
{
	creuvasse = 10,
	fragile = 100,
	moyen = 200,
	solide = 300,
	indestructible = 1000
}

public class IceCube : MonoBehaviour {

	public GameObject CrackFragilePrefab;
	public GameObject CrackMoyenPrefab;

	public int CurrentHP;
	public EIceCubeHP HealthPoints;

	private Vector3 SinkVector;
	private const float SinkSpeed = 0.1f;
	private const float RotateSpeed = 0.1f;

	//private GameObject CrackFragileInstance;
	//private GameObject CrackMoyenInstance;
	//private Projector CrackFragileProjector;
	//private Projector CrackMoyenProjector;

	protected void Start()
	{
		SinkVector = new Vector3 (Random.Range (0f, 10f), Random.Range (0f, 10f), 0);
		//CrackFragileInstance = (GameObject)Instantiate (CrackFragilePrefab);
		//CrackFragileInstance.transform.position = transform.position + new Vector3 (0, 10, 0);
		//CrackFragileInstance.gameObject.transform.parent = gameObject.transform;
		//CrackFragileProjector = CrackFragileInstance.GetComponent<Projector> ();

		//CrackMoyenInstance = (GameObject)Instantiate (CrackMoyenPrefab);
		//CrackMoyenInstance.transform.position = transform.position + new Vector3 (0, 10, 0);
		//CrackMoyenInstance.gameObject.transform.parent = gameObject.transform;
		//CrackMoyenProjector = CrackMoyenInstance.GetComponent<Projector> ();
	}

	public void Damage(int hp)
	{
		//Debug.Log("Message received : param = " + hp);
		HealthPoints -= hp;

		CurrentHP = (int)HealthPoints;
		/*if (HealthPoints <= EIceCubeHP.fragile && HealthPoints > 0)
		{
			CrackFragileProjector.enabled = true;
			CrackMoyenProjector.enabled = false;
		}
		else if (HealthPoints > EIceCubeHP.fragile && HealthPoints <= EIceCubeHP.moyen)
		{
			CrackFragileProjector.enabled = false;
			CrackMoyenProjector.enabled = true;
		}
		else if (HealthPoints <= 0) 
		{
			Sink(Time.deltaTime);
		}
		else if (HealthPoints > EIceCubeHP.moyen)
		{
			CrackFragileProjector.enabled = false;
			CrackMoyenProjector.enabled = false;
		}*/
	}

	public void Kill()
	{
		HealthPoints = 0;
	}

	// Fait couler le bloc
	private void Sink(float deltaTime)
	{
		gameObject.transform.Rotate (SinkVector * (RotateSpeed * deltaTime));
		gameObject.transform.Translate (Vector3.down * 2 * (SinkSpeed * deltaTime));
	}

	protected void Update()
	{
		if (HealthPoints <= 0) 
		{
			Sink(Time.deltaTime);
		}
	}
}
