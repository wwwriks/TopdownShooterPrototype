using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossMoveIn : State
{
    private Vector3 _currentPoint;
    private Vector3 _lastPoint;
    private float _elapsedTime;
    public BossMoveIn(IBehaviour behaviour, Enemy e) : base(behaviour, e){}

    public override void Enter()
    {
        _currentPoint = _enemy.transform.position;
        _lastPoint = _currentPoint;
        _currentPoint = _enemy.EndPos.position;
        _elapsedTime = 0.0f;
        _enemy.Invincible = true;
    }

    protected override void Exit()
    {
        _enemy.Invincible = false;
    }

    public override void Update(float deltaTime)
    {
        if (_elapsedTime >= 1.0f) ToState(StateType.BOSS_IDLE);
        _enemy.transform.position = Vector3.Lerp(_lastPoint, _currentPoint, _elapsedTime);
        _elapsedTime += (_enemy.MovementSpeed * deltaTime) / Vector3.Distance(_lastPoint, _currentPoint);
    }
}
