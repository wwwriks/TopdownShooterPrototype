using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pillar : Enemy
{
    private void Start()
    {
        States[StateType.MOVE_IN] = new PillarMoveIn(this, this);
        States[StateType.MOVE_OUT] = new PillarMoveOut(this, this);
        CurrentState = States[StateType.MOVE_IN];
        CurrentState.Enter();
    }
}
