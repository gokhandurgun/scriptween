using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEditor;
using UnityEngine;

namespace Scriptweener.Editor
{
    [CustomPropertyDrawer(typeof(SequenceScriptween), true)]
    public class SequenceScriptweenEditor : NestablePropertyDrawer
    {
        private SequenceScriptween _sequenceScriptween;
        private SerializedProperty _entriesProperty;
        private SerializedProperty _optionsProperty;

        protected override void OnEnable(SerializedProperty property)
        {
            base.OnEnable(property);

            _sequenceScriptween = _currentPropertyObject as SequenceScriptween;

            _optionsProperty = property.FindPropertyRelative("_optionCatalogue");
            _entriesProperty = property.FindPropertyRelative(nameof(SequenceScriptween.Entries));
        }

        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            base.OnGUI(position, property, label);

            EditorGUI.BeginProperty(position, label, property);

            property.serializedObject.Update();

            var rect = position;
            var totalWidth = position.width;

            EditorGUI.LabelField(rect, _entriesProperty.displayName);

            rect.width = 55;

            rect.x = totalWidth;
            if (GUI.Button(rect, "Add"))
            {
                if (_sequenceScriptween.Entries == null)
                {
                    _sequenceScriptween.Entries = new List<SequenceScriptweenEntry>();
                }
                _sequenceScriptween.Entries.Add(new SequenceScriptweenEntry());
                _entriesProperty.serializedObject.ApplyModifiedProperties();
            }

            EditorGUILayout.LabelField("", GUI.skin.horizontalSlider);

            {
                EditorGUI.indentLevel++;

                var arraySize = _entriesProperty.arraySize;
                for (var i = 0; i < arraySize; i++)
                {
                    var arrayElement = _entriesProperty.GetArrayElementAtIndex(i);
                    if (arrayElement != null)
                    {
                        EditorGUILayout.BeginHorizontal("box");
                        {
                            EditorGUILayout.BeginVertical();

                            EditorGUI.BeginChangeCheck();
                            EditorGUILayout.PropertyField(arrayElement, true);
                            if (EditorGUI.EndChangeCheck())
                            {
                                arrayElement.serializedObject.ApplyModifiedProperties();
                            }

                            GUILayout.EndVertical();
                        }
                        {
                            EditorGUILayout.BeginVertical(GUILayout.Width(22));

                            GUILayout.FlexibleSpace();

                            if (i == 0)
                            {
                                EditorGUILayout.Space(20 + EditorGUIUtility.standardVerticalSpacing);
                            }
                            else if (GUILayout.Button("\u25B2", GUILayout.Width(22), GUILayout.Height(20)))
                            {
                                var item = _sequenceScriptween.Entries[i];
                                _sequenceScriptween.Entries.RemoveAt(i);
                                _sequenceScriptween.Entries.Insert(i - 1, item);

                                _entriesProperty.serializedObject.ApplyModifiedProperties();
                            }

                            if (GUILayout.Button("\u2715", GUILayout.Width(22), GUILayout.Height(20)))
                            {
                                _sequenceScriptween.Entries.RemoveAt(i);
                                i--;
                                arraySize--;
                                _entriesProperty.serializedObject.ApplyModifiedProperties();
                            }

                            if (i == arraySize - 1)
                            {
                                EditorGUILayout.Space(20 + EditorGUIUtility.standardVerticalSpacing);
                            }
                            else if (GUILayout.Button("\u25BC", GUILayout.Width(22), GUILayout.Height(20)))
                            {
                                var item = _sequenceScriptween.Entries[i];
                                _sequenceScriptween.Entries.RemoveAt(i);
                                _sequenceScriptween.Entries.Insert(i + 1, item);

                                _entriesProperty.serializedObject.ApplyModifiedProperties();
                            }

                            GUILayout.FlexibleSpace();

                            GUILayout.EndVertical();
                        }
                        EditorGUILayout.EndHorizontal();
                    }
                }

                EditorGUI.indentLevel--;
            }

            EditorGUI.BeginChangeCheck();
            EditorGUILayout.PropertyField(_optionsProperty, GUIContent.none);
            if (EditorGUI.EndChangeCheck())
            {
                property.serializedObject.ApplyModifiedProperties();
            }

            property.serializedObject.ApplyModifiedProperties();

            EditorGUI.EndProperty();
        }
    }
}
