using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(menuName = "Wave")]
public class Wave : ScriptableObject
{
    public Enemy[] Enemies;
    public Transform[] SpawnPos;
    public Transform[] EndPos;
    public float SpawnDelay = 0.1f;
    public float WaveDelay = 5.0f;
}
