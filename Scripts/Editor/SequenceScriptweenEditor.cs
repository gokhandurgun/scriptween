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
        private UnityEditor.Editor m_Editor;

        private SequenceScriptween m_SequenceScriptween;
        private SerializedProperty m_EntriesProperty;
        private SerializedProperty m_OptionsProperty;

        protected override void OnEnable(SerializedProperty property)
        {
            base.OnEnable(property);

            m_SequenceScriptween = _currentPropertyObject as SequenceScriptween;

            m_OptionsProperty = property.FindPropertyRelative("m_OptionCatalogue");
            m_EntriesProperty = property.FindPropertyRelative(nameof(SequenceScriptween.Entries));
        }

        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            base.OnGUI(position, property, label);

            EditorGUI.BeginProperty(position, label, property);

            property.serializedObject.Update();

            var rect = position;
            var totalWidth = position.width;

            EditorGUI.LabelField(rect, m_EntriesProperty.displayName);

            rect.width = 55;

            rect.x = totalWidth;
            if (GUI.Button(rect, "Add"))
            {
                if (m_SequenceScriptween.Entries == null)
                {
                    m_SequenceScriptween.Entries = new List<SequenceScriptweenEntry>();
                }
                m_SequenceScriptween.Entries.Add(new SequenceScriptweenEntry());
                m_EntriesProperty.serializedObject.ApplyModifiedProperties();
            }

            EditorGUILayout.LabelField("", GUI.skin.horizontalSlider);

            {
                EditorGUI.indentLevel++;

                var arraySize = m_EntriesProperty.arraySize;
                for (var i = 0; i < arraySize; i++)
                {
                    var arrayElement = m_EntriesProperty.GetArrayElementAtIndex(i);
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
                                var item = m_SequenceScriptween.Entries[i];
                                m_SequenceScriptween.Entries.RemoveAt(i);
                                m_SequenceScriptween.Entries.Insert(i - 1, item);

                                m_EntriesProperty.serializedObject.ApplyModifiedProperties();
                            }

                            if (GUILayout.Button("\u2715", GUILayout.Width(22), GUILayout.Height(20)))
                            {
                                m_SequenceScriptween.Entries.RemoveAt(i);
                                i--;
                                arraySize--;
                                m_EntriesProperty.serializedObject.ApplyModifiedProperties();
                            }

                            if (i == arraySize - 1)
                            {
                                EditorGUILayout.Space(20 + EditorGUIUtility.standardVerticalSpacing);
                            }
                            else if (GUILayout.Button("\u25BC", GUILayout.Width(22), GUILayout.Height(20)))
                            {
                                var item = m_SequenceScriptween.Entries[i];
                                m_SequenceScriptween.Entries.RemoveAt(i);
                                m_SequenceScriptween.Entries.Insert(i + 1, item);

                                m_EntriesProperty.serializedObject.ApplyModifiedProperties();
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
            EditorGUILayout.PropertyField(m_OptionsProperty, GUIContent.none);
            if (EditorGUI.EndChangeCheck())
            {
                property.serializedObject.ApplyModifiedProperties();
            }

            property.serializedObject.ApplyModifiedProperties();

            EditorGUI.EndProperty();
        }
    }
}
