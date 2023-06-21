using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : State
{
    private Vector3 _currentPoint;
    private Vector3 _lastPoint;
    private float _elapsedTime;
    public MovePlayer(IBehaviour behaviour, Enemy e) : base(behaviour, e){}

    public override void Enter()
    {
        _currentPoint = _enemy.transform.position;
        _lastPoint = _currentPoint;
        _currentPoint = _enemy.PlayerPos.position;
        Vector3 d = (_currentPoint - _lastPoint);
        d = d.normalized * d.magnitude * 2.0f;
        _currentPoint += d;
        _elapsedTime = 0.0f;
    }

    public override void Update(float deltaTime)
    {
        // if (_elapsedTime >= 1.0f) ToState(StateType.IDLE);
        _enemy.transform.position = Vector3.Lerp(_lastPoint, _currentPoint, _elapsedTime);
        _elapsedTime += (_enemy.MovementSpeed * deltaTime) / Vector3.Distance(_lastPoint, _currentPoint);
    }
}
