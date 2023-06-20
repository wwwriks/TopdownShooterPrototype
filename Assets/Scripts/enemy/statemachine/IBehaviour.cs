using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum StateType
{
    IDLE,
    STAND,
    WALK,
}

public interface IBehaviour
{
    public State CurrentState { get; set; }
    public Dictionary<StateType, State> States { get; set; }
}
