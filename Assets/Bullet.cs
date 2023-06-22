using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private float speed = 5;

    private void Update()
    {
        transform.position += transform.forward * speed * Time.deltaTime;
    }

    private void OnCollisionEnter(Collision collision)
    {
        Enemy enemy = collision.transform.GetComponent<Enemy>();
        //enemy?.
        Destroy(gameObject);
    }
}
