using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour, IBehaviour
{
    public State CurrentState {get; set;}
    public Dictionary<StateType, State> States {get; set;}

    [HideInInspector]
    public Transform SpawnPos;
    public Transform EndPos;
    
    [HideInInspector]
    public Transform PlayerPos;

    public GameObject Bullet;
    public bool Invincible = false;
    public float MovementSpeed = 1.0f;
    public int Health = 10;

    [SerializeField] private GameObject _explosion;

    private void Awake()
    {
        SpawnPos = transform;
        PlayerPos = GameObject.FindWithTag("Player").transform;

        States = new Dictionary<StateType, State>();
    }

    private void OnTriggerEnter(Collider other)
    {
        Player player = other.transform.GetComponent<Player>();
        player?.TakeDamage();
    }

    protected virtual void OnDeath()
    {
        Instantiate(_explosion, transform.position, Quaternion.identity);
    }

    public void TakeDamage()
    {
        if (Invincible) return;
        Debug.Log(Health);
        Health--;
        if (Health <= 0)
        {
            OnDeath();
            Destroy(this.gameObject);
        }
    }

    public void ShootBullet(Vector3 pos)
    {
        Vector3 dir = (pos - transform.position).normalized;
        Quaternion q = Quaternion.LookRotation(dir);
        GameObject b = Instantiate(Bullet, transform.position, q);
    }

    private void Update()
    {
        if (transform.position.x < -20.0f || transform.position.x > 20.0f
            || transform.position.y < -20.0f || transform.position.y > 20.0f
            || transform.position.z < -10.0f || transform.position.z > 65.0f) Destroy(this.gameObject);
        CurrentState.Update(Time.deltaTime);
    }
}
