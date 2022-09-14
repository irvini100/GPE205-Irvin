using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerupSpawner : MonoBehaviour
{

public GameObject pickupPreFab;
public float spawnDelay;
public float nextSpawnTime;
private Transform tf;

public GameObject spawnedPickup;
    // Start is called before the first frame update
    void Start()
    {
        nextSpawnTime = Time.time + spawnDelay;
    }

    // Update is called once per frame
    void Update()
    {

    if (spawnedPickup == null)
    {
        if (Time.time > nextSpawnTime)
        {
            spawnedPickup = Instantiate(pickupPreFab, transform.position, Quaternion.identity) as GameObject;
            nextSpawnTime = Time.time + spawnDelay;
        }
    }
    else
    {
        nextSpawnTime = Time.time + spawnDelay;
    }
        
    }
}
