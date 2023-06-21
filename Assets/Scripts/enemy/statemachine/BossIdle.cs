using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossIdle : State
{
    private Vector3 _currentPoint;
    private Vector3 _lastPoint;
    private float _elapsedTime;
    public BossIdle(IBehaviour behaviour, Enemy e) : base(behaviour, e){}

    public override void Enter()
    {
        _currentPoint = _enemy.transform.position;
        _lastPoint = _currentPoint;
        _currentPoint = _enemy.EndPos.position;
        _elapsedTime = 0.0f;
    }

    public override void Update(float deltaTime)
    {
    }
}
