using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveHandler : MonoBehaviour
{
    public Wave[] Waves;
    private float _timer;
    private float _spawnDelayTimer;
    private float _spawnTimer;
    private int _index;
    private int _enemyIndex;
    private bool _spawned;

    private void Start()
    {
        _timer = 0.0f;
        _spawnDelayTimer = 0.0f;
        _spawnTimer = 0.0f;
        _index = 0;
        _enemyIndex = 0;
    }

    

    private void Update()
    {
        if (_index >= Waves.Length) return;
        _timer += Time.deltaTime;
        _spawnDelayTimer += Time.deltaTime;
        if (_spawnDelayTimer < Waves[_index].WaveDelay) return;
        _spawnTimer += Time.deltaTime;
        if (_spawnTimer >= Waves[_index].SpawnDelay)
        {
            Enemy e = Instantiate(Waves[_index].Enemies[_enemyIndex], Waves[_index].SpawnPos.position, Quaternion.identity);
            e.EndPos = Waves[_index].EndPos;
            _spawnTimer = 0.0f;
            _enemyIndex++;
            if (_enemyIndex >= Waves[_index].Enemies.Length)
            {
                _timer = 0.0f;
                _spawnDelayTimer = 0.0f;
                _spawnTimer = 0.0f;
                _enemyIndex = 0;
                _index++;
            }
        }
    }
}
