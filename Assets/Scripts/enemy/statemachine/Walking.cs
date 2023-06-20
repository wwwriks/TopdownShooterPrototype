using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Walking : State
{
    public Walking(IBehaviour behaviour, Enemy e) : base(behaviour, e) {}
}
