// http://www.sonity.org/ Created by Victor Engstr�m
// Copyright 2023 Sonigon AB - All Rights Reserved

#if UNITY_EDITOR

using UnityEditor;

namespace Sonity.Internal {

    [CustomPropertyDrawer(typeof(SoundPicker))]
    public class SoundPickerEditor : SoundPickerEditorBase {

    }
}
#endif