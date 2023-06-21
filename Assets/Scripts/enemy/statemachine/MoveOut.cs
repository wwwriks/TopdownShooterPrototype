using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveOut : State
{
    private Vector3 _currentPoint;
    private Vector3 _lastPoint;
    private float _elapsedTime;
    public MoveOut(IBehaviour behaviour, Enemy e) : base(behaviour, e){}
}
