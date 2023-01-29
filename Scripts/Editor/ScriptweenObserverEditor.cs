using DG.Tweening;
using System.Linq;
using UnityEditor;
using UnityEngine;

namespace Scriptweener.Editor
{
    [CustomPropertyDrawer(typeof(ScriptweenObserver), true)]
    public class ScriptweenObserverEditor : PropertyDrawer
    {
        private bool _initialized = false;

        private ScriptweenObserver _scriptweenObserver;
        private SerializedProperty _listenersProperty;

        private void OnEnable(SerializedProperty property)
        {
            _scriptweenObserver = fieldInfo.GetValue(property.serializedObject.targetObject) as ScriptweenObserver;
            _listenersProperty = property.FindPropertyRelative(nameof(ScriptweenObserver.Listeners));

            _initialized = true;
        }

        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            if (!_initialized)
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
                if (_scriptweenObserver.Listeners == null)
                {
                    _scriptweenObserver.Listeners = new System.Collections.Generic.List<IBaseScriptweenEntry>();
                }
                _scriptweenObserver.Listeners.Add(new NestedScriptweenEntry());
                property.serializedObject.ApplyModifiedProperties();
            }

            position.x -= position.width;
            if (GUI.Button(position, "Add Tween"))
            {
                if (_scriptweenObserver.Listeners == null)
                {
                    _scriptweenObserver.Listeners = new System.Collections.Generic.List<IBaseScriptweenEntry>();
                }
                _scriptweenObserver.Listeners.Add(new ScriptweenEntry());
                property.serializedObject.ApplyModifiedProperties();
            }

            if (Application.isPlaying)
            {
                position.width = 55;
                position.x -= position.width;
                if (GUI.Button(position, "Pause"))
                {
                    foreach (var tween in _scriptweenObserver.Tweens)
                    {
                        tween.Kill();
                    }

                    _scriptweenObserver.Tweens.Clear();
                }
                position.x -= position.width;
                if (GUI.Button(position, "Play"))
                {
                    var newTweens = _scriptweenObserver.InvokeAll();

                    _scriptweenObserver.Tweens = _scriptweenObserver.Tweens.Where(x => x.active).Concat(newTweens).ToList();
                }
            }


            position.x = 0;
            position.width = totalWidth;
            position.y += EditorGUIUtility.singleLineHeight + EditorGUIUtility.standardVerticalSpacing;

            EditorGUILayout.LabelField("", GUI.skin.horizontalSlider);

            if (property.isExpanded)
            {
                var arraySize = _listenersProperty.arraySize;
                for (var i = 0; i < arraySize; i++)
                {
                    var arrayElement = _listenersProperty.GetArrayElementAtIndex(i);
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
                                _scriptweenObserver.Listeners.RemoveAt(i);
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
