// http://www.sonity.org/ Created by Victor Engstr�m
// Copyright 2023 Sonigon AB - All Rights Reserved

#if UNITY_EDITOR

using UnityEditor;

namespace Sonity.Internal {

    [CustomEditor(typeof(SoundMix))]
    [CanEditMultipleObjects]
    public class SoundMixEditor : SoundMixEditorBase {

    }
}
#endif