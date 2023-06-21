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
    MOVE_PLAYER
}

public interface IBehaviour
{
    public State CurrentState { get; set; }
    public Dictionary<StateType, State> States { get; set; }
}
