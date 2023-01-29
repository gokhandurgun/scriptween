using DG.Tweening;
using System.Linq;
using UnityEditor;
using UnityEngine;

namespace Scriptweener.Editor
{
    [CustomPropertyDrawer(typeof(ScriptweenObserver), true)]
    public class ScriptweenObserverEditor : PropertyDrawer
    {
        private UnityEditor.Editor m_Editor;
        private bool m_Initialized = false;

        private ScriptweenObserver m_ScriptweenObserver;
        private SerializedProperty m_ListenersProperty;

        private void OnEnable(SerializedProperty property)
        {
            m_ScriptweenObserver = fieldInfo.GetValue(property.serializedObject.targetObject) as ScriptweenObserver;
            m_ListenersProperty = property.FindPropertyRelative(nameof(ScriptweenObserver.Listeners));

            m_Initialized = true;
        }

        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            if (!m_Initialized)
            {
                OnEnable(property);
            }

            var totalWidth = position.width;

            EditorGUI.BeginProperty(position, label, property);

            //Space
            position.y += 8;

            property.isExpanded = EditorGUI.Foldout(position, property.isExpanded, label, false);

            position.width = 105;
            position.x = totalWidth - position.width;
            if (GUI.Button(position, "Add Sequence"))
            {
                if (m_ScriptweenObserver.Listeners == null)
                {
                    m_ScriptweenObserver.Listeners = new System.Collections.Generic.List<IBaseScriptweenEntry>();
                }
                m_ScriptweenObserver.Listeners.Add(new NestedScriptweenEntry());
                property.serializedObject.ApplyModifiedProperties();
            }

            position.x -= position.width;
            if (GUI.Button(position, "Add Tween"))
            {
                if (m_ScriptweenObserver.Listeners == null)
                {
                    m_ScriptweenObserver.Listeners = new System.Collections.Generic.List<IBaseScriptweenEntry>();
                }
                m_ScriptweenObserver.Listeners.Add(new ScriptweenEntry());
                property.serializedObject.ApplyModifiedProperties();
            }

            if (Application.isPlaying)
            {
                position.width = 55;
                position.x -= position.width;
                if (GUI.Button(position, "Pause"))
                {
                    foreach (var tween in m_ScriptweenObserver.Tweens)
                    {
                        tween.Kill();
                    }

                    m_ScriptweenObserver.Tweens.Clear();
                }
                position.x -= position.width;
                if (GUI.Button(position, "Play"))
                {
                    var newTweens = m_ScriptweenObserver.InvokeAll();

                    m_ScriptweenObserver.Tweens = m_ScriptweenObserver.Tweens.Where(x => x.active).Concat(newTweens).ToList();
                }
            }


            position.x = 0;
            position.width = totalWidth;
            position.y += EditorGUIUtility.singleLineHeight + EditorGUIUtility.standardVerticalSpacing;

            EditorGUILayout.LabelField("", GUI.skin.horizontalSlider);

            if (property.isExpanded)
            {
                var arraySize = m_ListenersProperty.arraySize;
                for (var i = 0; i < arraySize; i++)
                {
                    var arrayElement = m_ListenersProperty.GetArrayElementAtIndex(i);
                    if (arrayElement != null)
                    {
                        EditorGUILayout.BeginHorizontal("box");

                        {
                            EditorGUILayout.BeginVertical(GUILayout.Width(25));

                            var style = new GUIStyle(GUI.skin.label);
                            style.richText = true;
                            style.fontStyle = FontStyle.Bold;
                            EditorGUILayout.LabelField($@"#{i}", style, GUILayout.Width(25));

                            GUILayout.EndVertical();
                        }

                        {
                            EditorGUILayout.BeginVertical();

                            GUILayout.FlexibleSpace();

                            EditorGUI.BeginChangeCheck();
                            EditorGUILayout.PropertyField(arrayElement, true);
                            if (EditorGUI.EndChangeCheck())
                            {
                                arrayElement.serializedObject.ApplyModifiedProperties();
                            }

                            GUILayout.FlexibleSpace();

                            GUILayout.EndVertical();
                        }
                        {
                            EditorGUILayout.BeginVertical(GUILayout.Width(20));

                            GUILayout.FlexibleSpace();

                            if (GUILayout.Button("\u2715", GUILayout.Width(20), GUILayout.Height(20)))
                            {
                                m_ScriptweenObserver.Listeners.RemoveAt(i);
                                i--;
                                arraySize--;
                                property.serializedObject.ApplyModifiedProperties();
                            }

                            GUILayout.FlexibleSpace();

                            GUILayout.EndVertical();
                        }
                        EditorGUILayout.EndHorizontal();
                    }
                }
            }

            EditorGUILayout.Space(8);

            EditorGUI.EndProperty();
        }
    }
}
