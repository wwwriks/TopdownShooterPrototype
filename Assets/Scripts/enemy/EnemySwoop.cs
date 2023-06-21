using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySwoop : Enemy
{
    private void Start()
    {
        States[StateType.MOVE_IN] = new MoveIn(this, this);
        States[StateType.IDLE] = new Shoot(this, this);
        States[StateType.MOVE_PLAYER] = new MovePlayer(this, this);
        CurrentState = States[StateType.MOVE_IN];
        CurrentState.Enter();
    }
}
