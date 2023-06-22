using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossIdle : State, IBehaviour
{
    public State CurrentState { get; set; }
    public Dictionary<StateType, State> States { get; set; }

    private Vector3 _currentPoint;
    private Vector3 _lastPoint;
    private Vector3 _target;
    private float _elapsedTime;
    public BossIdle(IBehaviour behaviour, Enemy e) : base(behaviour, e)
    {
        States = new Dictionary<StateType, State>();
        States[StateType.BOSS_SUB_SHOOT] = new BossSubShoot(this, e);
        States[StateType.BOSS_SUB_WAIT] = new BossSubWait(this, e);
        CurrentState = States[StateType.BOSS_SUB_SHOOT];
        CurrentState.Enter();
    }

    public override void Enter()
    {
        _currentPoint = _enemy.transform.position;
        _lastPoint = _currentPoint;
        _target = new Vector3(5.0f, _enemy.EndPos.position.y, _enemy.EndPos.position.z);
        _currentPoint = _target;
        _elapsedTime = 0.0f;
    }

    public override void Update(float deltaTime)
    {
        CurrentState.Update(deltaTime);
        if (_elapsedTime >= 1.0f)
        {
            _currentPoint = _enemy.transform.position;
            _lastPoint = _currentPoint;
            _target.x *= -1;
            _currentPoint = _target;
            _elapsedTime = 0.0f;
        }
        _enemy.transform.position = Vector3.Lerp(_lastPoint, _currentPoint, _elapsedTime);
        _elapsedTime += (_enemy.MovementSpeed * deltaTime) / Vector3.Distance(_lastPoint, _currentPoint);
    }
}
