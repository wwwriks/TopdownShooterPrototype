using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    private void Update()
    {
        transform.position += transform.forward * 5.0f * Time.deltaTime;
    }
}
