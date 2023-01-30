using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEditor;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

namespace Scriptweener.Editor
{
    [CustomEditor(typeof(Scriptween), true)]
    public class ScriptweenEditor : UnityEditor.Editor
    {
        private Scriptween _scriptween;
        private SerializedProperty _optionsProperty;
        private StringListSearchProvider _tweenSearchProvider;

        private void OnEnable()
        {
            if (!target) return;

            _optionsProperty = serializedObject.FindProperty("_optionCatalogue");
            _scriptween = target as Scriptween;

            _scriptween.TweenSelected();
        }

        public override void OnInspectorGUI()
        {
            if (!target) return;

            serializedObject.Update();

            if (_tweenSearchProvider == null)
            {
                _tweenSearchProvider = new StringListSearchProvider();
            }

            EditorGUILayout.BeginHorizontal();
            EditorGUILayout.LabelField("Tween", GUILayout.ExpandWidth(false), GUILayout.Width(EditorGUIUtility.labelWidth));
            var lastRect = GUILayoutUtility.GetLastRect();
            lastRect.y += EditorGUIUtility.singleLineHeight * 2;
            lastRect.x += EditorGUIUtility.labelWidth + 125;
            if (GUILayout.Button(_scriptween.Tween, EditorStyles.popup))
            {
                var options = Scriptween.TweenNames.ToArray();
                _tweenSearchProvider.Load("Tween", options, x =>
                {
                    var newTween = x;
                    if (_scriptween.Tween != newTween)
                    {
                        _scriptween.Tween = newTween;
                        _scriptween.TweenSelected();
                    }
                });

                SearchWindow.Open(new SearchWindowContext(GUIUtility.GUIToScreenPoint(lastRect.position)), _tweenSearchProvider);
            }

            EditorGUILayout.EndHorizontal();

            EditorGUILayout.Space(8);

            var selectedTweenProperty = serializedObject.FindProperty(nameof(Scriptween.SelectedTween));
            while (selectedTweenProperty.NextVisible(true))
            {
                EditorGUI.BeginChangeCheck();
                EditorGUILayout.PropertyField(selectedTweenProperty);
                if (EditorGUI.EndChangeCheck())
                {
                    serializedObject.ApplyModifiedProperties();
                }
            }

            EditorGUI.BeginChangeCheck();
            EditorGUILayout.PropertyField(_optionsProperty, GUIContent.none);
            if (EditorGUI.EndChangeCheck())
            {
                serializedObject.ApplyModifiedProperties();
            }

            serializedObject.ApplyModifiedProperties();
        }
    }
}
