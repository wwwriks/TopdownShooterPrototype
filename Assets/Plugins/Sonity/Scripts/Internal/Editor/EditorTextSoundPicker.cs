﻿// http://www.sonity.org/ Created by Victor Engström
// Copyright 2023 Sonigon AB - All Rights Reserved

#if UNITY_EDITOR


namespace Sonity.Internal {

    public class EditorTextSoundPicker {

        public static string soundPickerTooltip =
            $"{nameof(NameOf.SoundPicker)} is a serializable class for easily selecting multiple {nameof(NameOf.SoundEvent)}s and modifiers." + "\n" +
            "\n" +
            $"Add a serialized or public {nameof(NameOf.SoundPicker)} to a C# script and edit it in the inspector." + "\n" +
            "\n" +
            $"{nameof(NameOf.SoundPicker)} are multi-object editable." + NameOf.Tooltip;

        public static string soundEventLabel = $"{nameof(NameOf.SoundEvent)}";
        public static string soundEventTooltip = $"The {nameof(NameOf.SoundEvent)} to play." + NameOf.Tooltip;
    }
}
#endif