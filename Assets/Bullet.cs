using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private float speed = 5;
    private float timer;

    private void Start()
    {
        timer = 0.0f;
    }

    private void Update()
    {
        transform.position += transform.forward * speed * Time.deltaTime;
        timer += Time.deltaTime;
        if (timer > 4.0f) Destroy(this.gameObject);
    }

    private void OnTriggerEnter(Collider collision)
    {
        Enemy enemy = collision.transform.GetComponent<Enemy>();
        enemy?.TakeDamage();
        Destroy(gameObject);
    }
}
