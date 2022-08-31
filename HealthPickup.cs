using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPickup : MonoBehaviour
{
 private GameObject spawnedPickup;
  public GameObject pickupPrefab;
  public float spawnDelay;
  private float nextSpawnTime;
  private Transform tf;
  
  public HealthPowerup powerup;
  
  
  
  
  
  

  public  void Start()
  {
		nextSpawnTime = Time.time + spawnDelay;
  }

  public  void Update()
  {
    //If it is there is nothing spawns.
	if (spawnedPickup == null)
	{
		//And it is time to spawn.
		if (Time.time > nextSpawnTime)
		{
			//Spawn it and set the next time.
			spawnedPickup = Instantiate(pickupPrefab, tf.position, Quaternion.identity) as GameObject;
			nextSpawnTime = Time.time + spawnDelay;
		}
  }
  else
  {
		//Otherwise, the object still exists, so postpone the spawn.
		nextSpawnTime = Time.time + spawnDelay;
  }
  }
  
public void OnTriggerEnter(Collider other)
{
	//Variable to store other object's PowerupController - if it has one.
	PowerupManager powerupManager = other.GetComponent<PowerupManager>();

	//If the other object has a PowerupController.
	if(powerupManager != null)
	{
		//Add the powerup.
		powerupManager.Add(powerup);

		//Destroy this pickup.
		Destroy (gameObject);
	}
}
}
