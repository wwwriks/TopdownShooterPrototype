// http://www.sonity.org/ Created by Victor Engström
// Copyright 2023 Sonigon AB - All Rights Reserved

#if UNITY_EDITOR

using UnityEngine;
using UnityEditor;

namespace Sonity.Internal {

    public abstract class SoundPolyGroupEditorBase : Editor {

        public SoundPolyGroupBase mTarget;
        public SoundPolyGroupBase[] mTargets;

        public float pixelsPerIndentLevel = 10f;

        public SerializedProperty internals;
        public SerializedProperty polyphonyLimit;

        public void OnEnable() {
            FindProperties();
        }

        public void FindProperties() {
            internals = serializedObject.FindProperty(nameof(SoundPolyGroupBase.internals));
            polyphonyLimit = internals.FindPropertyRelative(nameof(SoundPolyGroupInternals.polyphonyLimit));
        }

        public void BeginChange() {
            serializedObject.Update();
            EditorGUI.BeginChangeCheck();
        }

        public void EndChange() {
            if (EditorGUI.EndChangeCheck()) {
                serializedObject.ApplyModifiedProperties();
            }
        }

        public Color defaultGuiColor;
        public GUIStyle guiStyleBoldCenter = new GUIStyle();

        public void StartBackgroundColor(Color color) {
            GUI.color = color;
            EditorGUILayout.BeginVertical("Button");
            GUI.color = defaultGuiColor;
        }

        public void StopBackgroundColor() {
            EditorGUILayout.EndVertical();
        }

        public override void OnInspectorGUI() {
            
            mTarget = (SoundPolyGroupBase)target;

            mTargets = new SoundPolyGroupBase[targets.Length];
            for (int i = 0; i < targets.Length; i++) {
                mTargets[i] = (SoundPolyGroupBase)targets[i];
            }

            defaultGuiColor = GUI.color;

            guiStyleBoldCenter.fontSize = 16;
            guiStyleBoldCenter.fontStyle = FontStyle.Bold;
            guiStyleBoldCenter.alignment = TextAnchor.MiddleCenter;
            if (EditorGUIUtility.isProSkin) {
                guiStyleBoldCenter.normal.textColor = EditorColor.GetDarkSkinTextColor();
            }

            EditorGUI.indentLevel = 0;

            StartBackgroundColor(Color.white);
            if (GUILayout.Button(new GUIContent($"Sonity" + NameOf.Type + $" - {nameof(NameOf.SoundPolyGroup)}\n{mTarget.name}", EditorTextSoundPolyGroup.soundPolyGroupTooltip), guiStyleBoldCenter, GUILayout.ExpandWidth(true), GUILayout.Height(40))) {
                EditorGUIUtility.PingObject(target);
            }
            StopBackgroundColor();

            EditorGUILayout.Separator();

            StartBackgroundColor(EditorColor.GetSettings(EditorColor.GetCustomEditorBackgroundAlpha()));

            BeginChange();
            EditorGUILayout.PropertyField(polyphonyLimit, new GUIContent(EditorTextSoundPolyGroup.polyphonyLimitLabel, EditorTextSoundPolyGroup.polyphonyLimitTooltip));
            if (polyphonyLimit.intValue < 1) {
                polyphonyLimit.intValue = 1;
            }
            EndChange();

            StopBackgroundColor();
        }
    }
}
#endif