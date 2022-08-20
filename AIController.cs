using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIController : Controller
{
private float lastStateChangeTime;
public GameObject target;
public enum AIStates { Idle, Guard, Chase, Flee, Patrol, Attack, Scan, BackToPost };
public AIStates currentState;
    // Start is called before the first frame update
    public override void Start()
    {
        //Run the parent base start.
        base.Start();
        ChangeState(AIStates.Idle);
    }

    // Update is called once per frame
    public override void Update()
    {
        //Make decisions
        MakeDecisions();
        //Run the parent base update.
        base.Update();
        currentState = AIStates.Guard;
    }

    public void MakeDecisions()
    {
        Debug.Log("Making Decisions");
    }

    protected void DoIdleState()
    {
        //Do Nothing
    }
    
    public void Seek(Vector3 targetPosition)
    {
      //Do Seek
    }

    public void DoSeekState()
    {
        //Seek our target.
        Seek(target);
    }

    public void Seek(GameObject target)
    {
        pawn.RotateTorwards(target.transform.position);
        //Move Forward
        pawn.MoveForward();
    }

    public virtual void ChangeState(AIStates newState)
    {
        //Change the current state
        currentState = newState;
        //Save the time when we changed states.
        lastStateChangeTime = Time.time;
    }

    protected bool IsDistanceLessThan(GameObject target, float distance)
    {
        if (Vector3.distance (pawn.transform.position, target.transform.position) < distance)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
