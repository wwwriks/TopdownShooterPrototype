// http://www.sonity.org/ Created by Victor Engstr�m
// Copyright 2023 Sonigon AB - All Rights Reserved

using System;

namespace Sonity.Internal {

    [Serializable]
    public abstract class SoundPickerBase {

        public SoundPickerInternals internals = new SoundPickerInternals();
    }
}