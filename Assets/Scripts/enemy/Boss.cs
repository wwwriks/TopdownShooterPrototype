using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss : Enemy
{
    private void Start()
    {
        States[StateType.BOSS_MOVE_IN] = new BossMoveIn(this, this);
        States[StateType.BOSS_IDLE] = new BossIdle(this, this);
        CurrentState = States[StateType.BOSS_MOVE_IN];
        CurrentState.Enter();
    }
}
