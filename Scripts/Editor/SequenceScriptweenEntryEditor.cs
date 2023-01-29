using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace Scriptweener.Editor
{
    [CustomPropertyDrawer(typeof(SequenceScriptweenEntry), true)]
    public class SequenceScriptweenEntryEditor : NestablePropertyDrawer
    {
        private SequenceScriptweenEntry _sequenceScriptweenEntry;

        private SerializedProperty _entryMethodProperty;
        private SerializedProperty _scriptweenProperty;
        private SerializedProperty _atPositionProperty;
        private SerializedProperty _intervalProperty;
        private SerializedProperty _callbackProperty;

        protected override void OnEnable(SerializedProperty property)
        {
            base.OnEnable(property);

            _sequenceScriptweenEntry = _currentPropertyObject as SequenceScriptweenEntry;
            _entryMethodProperty = property.FindPropertyRelative(nameof(SequenceScriptweenEntry.EntryMethod));
            _scriptweenProperty = property.FindPropertyRelative(nameof(SequenceScriptweenEntry.Scriptween));
            _atPositionProperty = property.FindPropertyRelative(nameof(SequenceScriptweenEntry.AtPosition));
            _intervalProperty = property.FindPropertyRelative(nameof(SequenceScriptweenEntry.Interval));
            _callbackProperty = property.FindPropertyRelative(nameof(SequenceScriptweenEntry.Callback));
        }


        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            base.OnGUI(position, property, label);

            EditorGUI.BeginProperty(position, label, property);

            //I amnot sure why i need it but by default it creates one line space...
            EditorGUILayout.Space(-EditorGUIUtility.singleLineHeight - EditorGUIUtility.standardVerticalSpacing);  

            property.serializedObject.Update();

            {
                EditorGUILayout.BeginHorizontal();

                EditorGUI.BeginChangeCheck();
                EditorGUILayout.PropertyField(_entryMethodProperty, GUIContent.none, GUILayout.Width(160));
                if (EditorGUI.EndChangeCheck())
                {
                    property.serializedObject.ApplyModifiedProperties();
                }

                if (_sequenceScriptweenEntry.IsAtPositionShown())
                {
                    EditorGUI.BeginChangeCheck();
                    EditorGUILayout.PropertyField(_atPositionProperty, GUIContent.none);
                    if (EditorGUI.EndChangeCheck())
                    {
                        property.serializedObject.ApplyModifiedProperties();
                    }
                }

                if (_sequenceScriptweenEntry.IsIntervalShown())
                {
                    EditorGUI.BeginChangeCheck();
                    EditorGUILayout.PropertyField(_intervalProperty, GUIContent.none, GUILayout.Width(60));
                    if (EditorGUI.EndChangeCheck())
                    {
                        property.serializedObject.ApplyModifiedProperties();
                    }
                }

                EditorGUILayout.EndHorizontal();
            }

            if (_sequenceScriptweenEntry.IsScriptweenShown())
            {
                EditorGUI.BeginChangeCheck();
                EditorGUILayout.PropertyField(_scriptweenProperty, GUIContent.none);
                if (EditorGUI.EndChangeCheck())
                {
                    property.serializedObject.ApplyModifiedProperties();
                }
            }

            if (_sequenceScriptweenEntry.IsCallbackShown())
            {
                EditorGUI.BeginChangeCheck();
                EditorGUILayout.PropertyField(_callbackProperty, GUIContent.none);
                if (EditorGUI.EndChangeCheck())
                {
                    property.serializedObject.ApplyModifiedProperties();
                }
            }

            EditorGUI.EndProperty();
        }
    }
}
