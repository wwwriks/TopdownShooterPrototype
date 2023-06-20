// http://www.sonity.org/ Created by Victor Engström
// Copyright 2023 Sonigon AB - All Rights Reserved

#if UNITY_EDITOR

using System.Collections.Generic;

namespace Sonity.Internal {

    public class EditorPreviewSoundData {

        public SoundContainerBase soundContainer;
        public List<SoundEventModifier> soundEventModifierList = new List<SoundEventModifier>();
        public SoundEventTimelineData timelineSoundContainerData = new SoundEventTimelineData();
        public SoundEventBase soundEvent;
    }
}
#endif