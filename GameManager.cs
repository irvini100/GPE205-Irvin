using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
public List<TankPawn> tanks;
public List<PlayerController> players;
public float TankMover;
public float TankShooter;
public static GameManager instance;
public GameObject playerControllerPrefab;
public GameObject tankPawnPrefab;
public Transform playerSpawnTransform;

//Awake is called when the object is first created - before even Start can run!
private void Awake()
{
    instance = this;

    //If the instance doesn't exist yet...
    if (instance == null)
    {
        //This is the instance.
        instance = this;
        //Don't destroy it if we load a new scene.
        DontDestroyOnLoad(gameObject);

    }
    else 
    {
        //Otherwise, there is already an instance, so distroy this gameObject.
        Destroy(gameObject);
    }
}
    // Start is called before the first frame update
    void Start()
    {
        //Temp code-for now, we spawn player as soon as the GameManager starts.
        SpawnPlayer();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpawnPlayer()
    {
        //Spawn the player controller at (0,0,0) with no rotation.
        GameObject newPlayerObj = Instantiate(playerControllerPrefab, Vector3.zero, Quaternion.identity) as GameObject;

        //Spawn the Pawn and connect it to the Controller.
        GameObject newPawnObj = Instantiate(tankPawnPrefab, playerSpawnTransform.position, playerSpawnTransform.rotation) as GameObject;

        //Get the Player Controller component and Pawn component.
        Controller newController = newPlayerObj.GetComponent<Controller>();
        Pawn newPawn = newPawnObj.GetComponent<Pawn>();

        //Hook them up.
        newController.pawn = newPawn;
    }
}
