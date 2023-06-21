using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour, IBehaviour
{
    public State CurrentState {get; set;}
    public Dictionary<StateType, State> States {get; set;}

    public Transform SpawnPos;
    public Transform EndPos;
    
    [HideInInspector]
    public Transform PlayerPos;

    public GameObject Bullet;

    public float MovementSpeed = 1.0f;

    private void Awake()
    {
        transform.position = SpawnPos.position;
        PlayerPos = GameObject.FindWithTag("Player").transform;

        States = new Dictionary<StateType, State>();
    }

    public void ShootBullet(Vector3 pos)
    {
        Vector3 dir = (pos - transform.position).normalized;
        Quaternion q = Quaternion.LookRotation(dir);
        GameObject b = Instantiate(Bullet, transform.position, q);
    }

    private void Update()
    {
        CurrentState.Update(Time.deltaTime);
    }
}
