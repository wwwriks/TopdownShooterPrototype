using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour
{
    private float _timer = 0.0f;
    private Vector3 _scale = new Vector3(0.0f, 0.0f, 0.0f);
    private void Update()
    {
        _timer += Time.deltaTime;
        _scale = Vector3.Lerp(new Vector3(0.0f, 0.0f, 0.0f), new Vector3(2.0f, 2.0f, 2.0f), _timer / 0.2f);
        transform.localScale = _scale;
        if (_timer > 0.2f) Destroy(this.gameObject);
    }
}
