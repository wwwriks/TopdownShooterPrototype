using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossSubShoot : State
{
    private float _timer;
    private float _shootTimer;
    private Vector3 _playerPos;
    public BossSubShoot(IBehaviour behaviour, Enemy e) : base(behaviour, e){}
    public override void Enter()
    {
        _timer = 0.0f;
        _shootTimer = 0.0f;
        _playerPos = _enemy.PlayerPos.position;
    }

    public override void Update(float deltaTime)
    {
        if (_timer >= 1.6f) ToState(StateType.BOSS_SUB_WAIT);
        
        if (_shootTimer >= 0.3f)
        {
            _enemy.ShootBullet(_playerPos);
            _shootTimer = 0.0f;
        }

        _timer += deltaTime;
        _shootTimer += deltaTime;
    }
}
