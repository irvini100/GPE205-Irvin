using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPickup : MonoBehaviour
{
 private GameObject spawnedPickup;
 
  
  public HealthPowerup powerup;
  
  
  
  
  
  

  public  void Start()
  {

  }

  public void Update()
  {

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
