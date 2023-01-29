using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

namespace Scriptweener.Editor
{
    [CustomPropertyDrawer(typeof(ScriptweenEntry), true)]
    public class ScriptweenEntryEditor : NestablePropertyDrawer
    {
        private Dictionary<Object, UnityEditor.Editor> _editors;

        private ScriptweenEntry _scriptweenEntry;

        private SerializedProperty _scriptweenProperty;

        protected override void OnEnable(SerializedProperty property)
        {
            base.OnEnable(property);

            _scriptweenEntry = _currentPropertyObject as ScriptweenEntry;
            _scriptweenProperty = property.FindPropertyRelative(nameof(ScriptweenEntry.Scriptween));

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

            _scriptweenProperty.serializedObject.Update();

            var rect = position;
            if (_scriptweenProperty.objectReferenceValue)
            {
                _scriptweenProperty.isExpanded
                    = EditorGUI.Foldout(rect, _scriptweenProperty.isExpanded, GUIContent.none);
            }


            EditorGUI.BeginChangeCheck();
            EditorGUI.PropertyField(rect, _scriptweenProperty);
            if (EditorGUI.EndChangeCheck())
            {
                _scriptweenProperty.serializedObject.ApplyModifiedProperties();

                _scriptweenEntry.ScriptweenChanged();
                var entryOptionsProperty = property.FindPropertyRelative(nameof(ScriptweenEntry.EntryOptions));
                entryOptionsProperty.managedReferenceValue = _scriptweenEntry.EntryOptions;

                _scriptweenProperty.serializedObject.ApplyModifiedProperties();
            }

            if (_scriptweenProperty.isExpanded && _scriptweenProperty.objectReferenceValue)
            {
                UnityEditor.Editor editor;
                if (!_editors.TryGetValue(_scriptweenProperty.objectReferenceValue, out editor))
                {
                    UnityEditor.Editor.CreateCachedEditor(_scriptweenProperty.objectReferenceValue, null, ref editor);
                    if (editor)
                    {
                        _editors.Add(_scriptweenProperty.objectReferenceValue, editor);
                    }
                }

                if (editor)
                {
                    EditorGUILayout.BeginVertical(EditorStyles.helpBox);
                    EditorGUI.indentLevel++;

                    EditorGUI.BeginChangeCheck();

                    editor.OnInspectorGUI();

                    if (EditorGUI.EndChangeCheck())
                    {
                        _scriptweenProperty.serializedObject.ApplyModifiedProperties();

                        _scriptweenEntry.ScriptweenChanged();

                        _scriptweenProperty.serializedObject.ApplyModifiedProperties();
                    }

                    EditorGUI.indentLevel--;
                    EditorGUILayout.EndVertical();
                }
            }

            if (_scriptweenProperty.objectReferenceValue)
            {
                var entryOptionsProperty = property.FindPropertyRelative(nameof(ScriptweenEntry.EntryOptions));
                var validDepth = entryOptionsProperty.depth + 1;
                while (entryOptionsProperty.NextVisible(true) && entryOptionsProperty.depth == validDepth)
                {
                    EditorGUILayout.PropertyField(entryOptionsProperty, true);
                }
            }

            _scriptweenProperty.serializedObject.ApplyModifiedProperties();

            EditorGUI.EndProperty();
        }
    }
}
