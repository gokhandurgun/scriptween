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
        private Scriptween m_Scriptween;
        private SerializedProperty m_OptionsProperty;

        private void OnEnable()
        {
            if (!target) return;

            m_OptionsProperty = serializedObject.FindProperty("m_OptionCatalogue");
            m_Scriptween = target as Scriptween;

            m_Scriptween.TweenSelected();
        }

        public override void OnInspectorGUI()
        {
            if (!target) return;

            serializedObject.Update();

            var options = Scriptween.TweenNames.ToArray();

            var selectedIndex = 0;
            for (int i = 0; i < options.Length; i++)
            {
                if (m_Scriptween.Tween == options[i])
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
                m_Scriptween.Tween = options[selectedIndex];
                m_Scriptween.TweenSelected();
            }

            EditorGUILayout.Space(8);

            var selectedTweenProperty = serializedObject.FindProperty(nameof(Scriptween.SelectedTween));
            while (selectedTweenProperty.NextVisible(true))
            {
                EditorGUILayout.PropertyField(selectedTweenProperty);               
            }

            EditorGUI.BeginChangeCheck();
            EditorGUILayout.PropertyField(m_OptionsProperty, GUIContent.none);
            if (EditorGUI.EndChangeCheck())
            {
                serializedObject.ApplyModifiedProperties();
            }

            serializedObject.ApplyModifiedProperties();
        }
    }
}
