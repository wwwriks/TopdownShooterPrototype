using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour, IBehaviour
{
    public State CurrentState {get; set;}
    public Dictionary<StateType, State> States {get; set;}

    public Transform SpawnPos;
    public Transform EndPos;
    public Transform PlayerPos;

    public float MovementSpeed = 1.0f;

    private void Awake()
    {
        transform.position = SpawnPos.position;
        PlayerPos = GameObject.FindWithTag("Player").transform;

        States = new Dictionary<StateType, State>();
    }

    private void Update()
    {
        CurrentState.Update(Time.deltaTime);
    }
}
