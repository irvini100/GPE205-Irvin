using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Pawn : MonoBehaviour
{
    public float speed;
public float turnSpeed;
public float moveSpeed;
public float health;
public float maxHealth;
public float fireRate;

    
   
 
    public Mover mover;
   public TankPawn tankPawn;
   public TankShooter tankShooter;
    

    // Start is called before the first frame update
    public virtual void Start()
    {
       
       
        mover = GetComponent<Mover>();
        tankPawn = GetComponent<TankPawn>();
        tankShooter = GetComponent<TankShooter>();
    
    }

    // Update is called once per frame
    public virtual void Update()
    {
     
    }

    public abstract void MoveForward();
    public abstract void MoveBackward();
    public abstract void RotateClockwise();
    public abstract void RotateCounterClockwise();
}
