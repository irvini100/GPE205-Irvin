using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class HealthPowerup : Powerup
{
  public float healthToAdd;
  public override void Apply(PowerupManager target)
  {
		//Apply health changes.
		Health targetHealth = target.GetComponent<Health>();
		if (targetHealth != null)
		{
			//The second parameter is the pawn who caused the healing - in this case, they healed themselves.
			targetHealth.Heal(healthToAdd, target.GetComponent<Pawn>());
		}
  }

  public override void Remove(PowerupManager target)
  {
		// TODO:  
  }

}
