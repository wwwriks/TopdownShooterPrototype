using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveHandler : MonoBehaviour
{
    private float _timer;

    private void Start()
    {
        _timer = 0.0f;
    }

    private void Update()
    {
        _timer += Time.deltaTime;
    }
}
