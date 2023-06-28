using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletDud : MonoBehaviour
{
    [SerializeField] private float speed = 5;
    private Vector3 _currentPoint;
    private Vector3 _lastPoint;
    private float _elapsedTime;
    public Vector3 CurrentPoint {get => _currentPoint; set => _currentPoint = value;}

    private void Start()
    {
        _lastPoint = transform.position;
        _elapsedTime = 0.0f;
    }

    private void Update()
    {
        if (_elapsedTime >= 1.0f) Destroy(this.gameObject);
        transform.position = Vector3.Lerp(_lastPoint, _currentPoint, _elapsedTime);
        _elapsedTime += (speed * Time.deltaTime) / Vector3.Distance(_lastPoint, _currentPoint);
    }
}
