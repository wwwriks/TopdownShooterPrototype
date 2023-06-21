using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : State
{
    private float _timer;
    private float _shootTimer;
    private Vector3 _playerPos;
    public Shoot(IBehaviour behaviour, Enemy e) : base(behaviour, e) {}

    public override void Enter()
    {
        _timer = 0.0f;
        _shootTimer = 0.0f;
        _playerPos = _enemy.PlayerPos.position;
    }

    public override void Update(float deltaTime)
    {
        if (_timer >= 1.8f) ToState(StateType.MOVE_OUT);
        
        if (_shootTimer >= 0.5f)
        {
            _enemy.ShootBullet(_playerPos);
            _shootTimer = 0.0f;
        }

        _timer += deltaTime;
        _shootTimer += deltaTime;
    }
}
