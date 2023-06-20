// http://www.sonity.org/ Created by Victor Engström
// Copyright 2023 Sonigon AB - All Rights Reserved

using System;

namespace Sonity.Internal {

    [Serializable]
    public class SoundEventSoundTagGroup {
        public SoundTagBase soundTag;
        public SoundEventModifier soundEventModifierBase = new SoundEventModifier();
        public SoundEventModifier soundEventModifierSoundTag = new SoundEventModifier();
        public SoundEventBase[] soundEvent = new SoundEventBase[1];
    }
}