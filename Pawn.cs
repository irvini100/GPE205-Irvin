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
//Variable to hold our shooter.
public Shooter shooter;
//Variable for our shellPreFab.
public GameObject Bullet;
//Variable for our firing force.
public float fireForce;
//Variable for our damage done.
public float damageDone;
//Variable for how long our bullets survive if they don't collide.
public float shellLifeSpan;

    
   
 
    public Mover mover;
   public TankPawn tankPawn;
   public TankShooter tankShooter;
    

    // Start is called before the first frame update
    public virtual void Start()
    {
       
       
        mover = GetComponent<Mover>();
        tankPawn = GetComponent<TankPawn>();
        tankShooter = GetComponent<TankShooter>();
        shooter = GetComponent<Shooter>();
    
    }

    // Update is called once per frame
    public virtual void Update()
    {
     
    }

    public abstract void MoveForward();
    public abstract void MoveBackward();
    public abstract void RotateClockwise();
    public abstract void RotateCounterClockwise();
    public abstract void Shoot();
    public abstract void RotateTowards(Vector3 targetPosition);
}
