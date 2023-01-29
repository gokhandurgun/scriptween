using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

namespace Scriptweener.Editor
{
    [CustomPropertyDrawer(typeof(NestedScriptweenEntry), true)]
    public class NestedScriptweenEntryEditor : NestablePropertyDrawer
    {
        private Dictionary<Object, UnityEditor.Editor> _editors;

        private NestedScriptweenEntry _scriptweenEntry;

        private SerializedProperty _scriptweenProperty;

        protected override void OnEnable(SerializedProperty property)
        {
            base.OnEnable(property);

            _scriptweenEntry = _currentPropertyObject as NestedScriptweenEntry;
            _scriptweenProperty = property.FindPropertyRelative(nameof(NestedScriptweenEntry.Scriptween));

            if (_newlyInitialized)
            {
                _scriptweenEntry.ScriptweenChanged();
                _scriptweenProperty.serializedObject.ApplyModifiedProperties();
            }

            if (_editors == null)
            {
                _editors = new Dictionary<Object, UnityEditor.Editor>();
            }
        }

        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            base.OnGUI(position, property, label);

            EditorGUI.BeginProperty(position, label, property);

            EditorGUILayout.Space(-EditorGUIUtility.standardVerticalSpacing - EditorGUIUtility.singleLineHeight);

            _scriptweenProperty.serializedObject.Update();

            _scriptweenProperty.isExpanded = EditorGUILayout.Foldout(_scriptweenProperty.isExpanded, "Sequence");

            if (_scriptweenProperty.isExpanded)
            {
                EditorGUI.indentLevel++;

                EditorGUILayout.BeginVertical(EditorStyles.helpBox);
                EditorGUI.BeginChangeCheck();
                EditorGUILayout.PropertyField(_scriptweenProperty, true);
                if (EditorGUI.EndChangeCheck())
                {
                    _scriptweenProperty.serializedObject.ApplyModifiedProperties();

                    _scriptweenEntry.ScriptweenChanged();

                    _scriptweenProperty.serializedObject.ApplyModifiedProperties();
                }

                var entryOptionsProperty = property.FindPropertyRelative(nameof(NestedScriptweenEntry.EntryOptions));
                var validDepth = entryOptionsProperty.depth + 1;
                while (entryOptionsProperty.NextVisible(true) && entryOptionsProperty.depth == validDepth)
                {
                    EditorGUILayout.PropertyField(entryOptionsProperty, true);
                }

                EditorGUILayout.EndVertical();
                EditorGUI.indentLevel--;
            }
            _scriptweenProperty.serializedObject.ApplyModifiedProperties();

            EditorGUI.EndProperty();
        }
    }
}
