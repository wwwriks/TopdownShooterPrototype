using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShoot : Enemy
{
    private void Start()
    {
        States[StateType.MOVE_IN] = new MoveIn(this, this);
        States[StateType.IDLE] = new Shoot(this, this);
        States[StateType.MOVE_OUT] = new MoveOut(this, this);
        CurrentState = States[StateType.MOVE_IN];
        CurrentState.Enter();
    }
}
