// http://www.sonity.org/ Created by Victor Engström
// Copyright 2023 Sonigon AB - All Rights Reserved

using System;

namespace Sonity.Internal {

    [Serializable]
    public class SoundPhysicsPart {
        public SoundEventBase soundEvent;
        public bool collisionTagUse = false;
        public string[] collisionTags = { "Untagged" };
    }
}