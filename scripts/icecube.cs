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

	public EIceCubeHP HealthPoints;

	private Vector3 SinkVector;
	private const float SinkSpeed = 1;
	private const float RotateSpeed = 1;

	protected void Start()
	{
		SinkVector = new Vector3 (Random.Range (0f, 10f), Random.Range (0f, 10f), 0);
	}

	public void Damage(int hp)
	{
		HealthPoints -= hp;
	}

	public void Kill()
	{
		HealthPoints = 0;
	}

	// Fait couler le bloc
	private void Sink(float deltaTime)
	{
		transform.Rotate (SinkVector * (RotateSpeed * deltaTime));
		transform.Translate (Vector3.down * (SinkSpeed * deltaTime));
	}

	protected void Update()
	{
		if (HealthPoints <= 0) 
		{
			Sink(Time.deltaTime);
		}
	}
}
