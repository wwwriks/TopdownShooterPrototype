using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PillarMoveIn : State
{
    private Vector3 _currentPoint;
    private Vector3 _lastPoint;
    private float _elapsedTime;
    public PillarMoveIn(IBehaviour behaviour, Enemy e) : base(behaviour, e){}

    public override void Enter()
    {
        _currentPoint = _enemy.transform.position;
        _lastPoint = _currentPoint;
        _currentPoint = new Vector3(_lastPoint.x, 0.0f, 0.0f);
        _elapsedTime = 0.0f;
    }

    public override void Update(float deltaTime)
    {
        if (_elapsedTime >= 1.0f) ToState(StateType.MOVE_OUT);
        _enemy.transform.position = Vector3.Lerp(_lastPoint, _currentPoint, _elapsedTime);
        _elapsedTime += (_enemy.MovementSpeed * deltaTime) / Vector3.Distance(_lastPoint, _currentPoint);
    }
}
