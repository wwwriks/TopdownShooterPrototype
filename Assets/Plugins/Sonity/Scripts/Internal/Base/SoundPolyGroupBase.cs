// http://www.sonity.org/ Created by Victor Engström
// Copyright 2023 Sonigon AB - All Rights Reserved

using UnityEngine;
using System;

namespace Sonity.Internal {

    public abstract class SoundPolyGroupBase : ScriptableObject {

        public SoundPolyGroupInternals internals = new SoundPolyGroupInternals();
    }
}