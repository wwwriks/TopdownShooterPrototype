using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : State
{
    public Shoot(IBehaviour behaviour, Enemy e) : base(behaviour, e) {}
}
