using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) ;//Player Take Damage
    }
    private void Update()
    {
        if (transform.position.x < -20.0f || transform.position.x > 20.0f
            || transform.position.y < -10.0f || transform.position.y > 10.0f
            || transform.position.z < -10.0f || transform.position.z > 10.0f) Destroy(this.gameObject);
        transform.position += transform.forward * 5.0f * Time.deltaTime;
    }
}
