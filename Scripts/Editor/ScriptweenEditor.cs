using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEditor;
using UnityEngine;

namespace Scriptweener.Editor
{
    [CustomEditor(typeof(Scriptween), true)]
    public class ScriptweenEditor : UnityEditor.Editor
    {
        private Scriptween _scriptween;
        private SerializedProperty _optionsProperty;

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

            var options = Scriptween.TweenNames.ToArray();

            var selectedIndex = 0;
            for (int i = 0; i < options.Length; i++)
            {
                if (_scriptween.Tween == options[i])
                {
                    selectedIndex = i;
                    break;
                }
            }

            //TODO: Set max height
            EditorGUI.BeginChangeCheck();
            selectedIndex = EditorGUILayout.Popup("Tween", selectedIndex, options);
            if (EditorGUI.EndChangeCheck())
            {
                _scriptween.Tween = options[selectedIndex];
                _scriptween.TweenSelected();
            }

            EditorGUILayout.Space(8);

            var selectedTweenProperty = serializedObject.FindProperty(nameof(Scriptween.SelectedTween));
            while (selectedTweenProperty.NextVisible(true))
            {
                EditorGUILayout.PropertyField(selectedTweenProperty);               
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
