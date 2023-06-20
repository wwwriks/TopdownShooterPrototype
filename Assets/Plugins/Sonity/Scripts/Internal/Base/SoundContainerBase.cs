// http://www.sonity.org/ Created by Victor Engström
// Copyright 2023 Sonigon AB - All Rights Reserved

using UnityEngine;
using System;

namespace Sonity.Internal {

    [Serializable]
    public abstract class SoundContainerBase : ScriptableObject {

        public SoundContainerInternals internals = new SoundContainerInternals();
    }
}