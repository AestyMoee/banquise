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

	public int CurrentHP;
	public EIceCubeHP HealthPoints;

	private Vector3 SinkVector;
	private const float SinkSpeed = 0.1f;
	private const float RotateSpeed = 0.1f;

	protected void Start()
	{
		SinkVector = new Vector3 (Random.Range (0f, 10f), Random.Range (0f, 10f), 0);
	}

	public void Damage(int hp)
	{
		//Debug.Log("Message received : param = " + hp);
		HealthPoints -= hp;
	}

	public void Kill()
	{
		HealthPoints = 0;
	}

	// Fait couler le bloc
	private void Sink(float deltaTime)
	{
		gameObject.transform.Rotate (SinkVector * (RotateSpeed * deltaTime));
		gameObject.transform.Translate (Vector3.down*10 * (SinkSpeed * deltaTime));
	}

	protected void Update()
	{
		CurrentHP = (int)HealthPoints;
		if (HealthPoints <= 0) 
		{
			Sink(Time.deltaTime);
		}
	}
}
