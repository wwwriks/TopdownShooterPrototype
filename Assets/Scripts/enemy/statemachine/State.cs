using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class State
{
    protected IBehaviour _behaviour;
    protected Enemy _enemy;
    
    public State(IBehaviour behaviour, Enemy e)
    {
        _behaviour = behaviour;
        _enemy = e;
    }

    public virtual void Enter(){}
    protected virtual void Exit(){}
    protected virtual void NextState(){}

    public virtual void Update(float deltaTime){}
}
