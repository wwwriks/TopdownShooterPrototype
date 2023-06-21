using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Idle : State
{
    private float _timer;
    public Idle(IBehaviour behaviour, Enemy e) : base(behaviour, e) {}

    public override void Enter()
    {
        _timer = 0.0f;
    }

    public override void Update(float deltaTime)
    {
        if (_timer >= 3.0f) ToState(StateType.MOVE_PLAYER);
        _timer += deltaTime;
    }
}
