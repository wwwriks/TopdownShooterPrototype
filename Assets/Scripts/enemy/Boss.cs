using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Boss : Enemy
{
    private void Start()
    {
        States[StateType.BOSS_MOVE_IN] = new BossMoveIn(this, this);
        States[StateType.BOSS_IDLE] = new BossIdle(this, this);
        CurrentState = States[StateType.BOSS_MOVE_IN];
        CurrentState.Enter();
    }
    protected override void OnDeath()
    {
        SceneManager.LoadScene("Win");
    }
}
