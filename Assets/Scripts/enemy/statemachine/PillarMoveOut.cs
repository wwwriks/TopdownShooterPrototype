using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PillarMoveOut : State
{
    private Vector3 _currentPoint;
    private Vector3 _lastPoint;
    private float _elapsedTime;
    public PillarMoveOut(IBehaviour behaviour, Enemy e) : base(behaviour, e){}

    public override void Enter()
    {
        _currentPoint = _enemy.transform.position;
        _lastPoint = _currentPoint;
        _currentPoint = _enemy.EndPos.position;
        _elapsedTime = 0.0f;
    }

    public override void Update(float deltaTime)
    {
        if (_elapsedTime >= 1.0f) _enemy.transform.position -= new Vector3(0.0f, 20.0f, 0.0f);
        _enemy.transform.position = Vector3.Lerp(_lastPoint, _currentPoint, _elapsedTime);
        _elapsedTime += (_enemy.MovementSpeed * deltaTime) / Vector3.Distance(_lastPoint, _currentPoint);
    }
}
