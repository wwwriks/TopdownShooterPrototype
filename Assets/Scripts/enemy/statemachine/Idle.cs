using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Idle : State
{
    public Idle(IBehaviour behaviour, Enemy e) : base(behaviour, e) {}
}
