using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum StateType
{
    IDLE,
    SHOOT,
    MOVE_IN,
    MOVE_OUT,
    MOVE_PLAYER,
    BOSS_MOVE_IN,
    BOSS_IDLE,
    BOSS_SUB_SHOOT,
    BOSS_SUB_WAIT
}

public interface IBehaviour
{
    public State CurrentState { get; set; }
    public Dictionary<StateType, State> States { get; set; }
}
