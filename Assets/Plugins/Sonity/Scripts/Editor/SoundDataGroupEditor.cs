// http://www.sonity.org/ Created by Victor Engström
// Copyright 2023 Sonigon AB - All Rights Reserved

#if UNITY_EDITOR

using UnityEditor;

namespace Sonity.Internal {

    [CustomEditor(typeof(SoundDataGroup))]
    [CanEditMultipleObjects]
    public class SoundDataGroupEditor : SoundDataGroupEditorBase {

    }
}
#endif