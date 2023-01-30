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
    [CustomPropertyDrawer(typeof(ScriptweenMethodOptionCatalogue), true)]
    public class ScriptweenMethodOptionCatalogueEditor : NestablePropertyDrawer
    {
        private ScriptweenMethodOptionCatalogue _optionCatalogue;

        private SerializedProperty _optionsProperty;

        private StringListSearchProvider _optionSearchProvider;

        protected override void OnEnable(SerializedProperty property)
        {
            base.OnEnable(property);

            _optionCatalogue = _currentPropertyObject as ScriptweenMethodOptionCatalogue;
            _optionsProperty = property.FindPropertyRelative(nameof(ScriptweenMethodOptionCatalogue.Options));
        }

        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            base.OnGUI(position, property, label);

            EditorGUI.BeginProperty(position, label, property);

            _optionsProperty.serializedObject.Update();

            _optionsProperty.isExpanded =
                EditorGUILayout.Foldout(_optionsProperty.isExpanded, _optionsProperty.displayName);
            if (_optionsProperty.isExpanded)
            {
                EditorGUI.indentLevel++;
                var options = _optionCatalogue.OptionNames.ToArray();

                if (_optionSearchProvider == null)
                {
                    _optionSearchProvider = new StringListSearchProvider();
                }

                EditorGUILayout.BeginHorizontal();
                EditorGUILayout.LabelField("Add Option", GUILayout.ExpandWidth(false), GUILayout.Width(EditorGUIUtility.labelWidth));
                var lastRect = GUILayoutUtility.GetLastRect();
                lastRect.y += EditorGUIUtility.singleLineHeight * 2;
                lastRect.x += EditorGUIUtility.labelWidth + 125;
                if (GUILayout.Button("(select)", EditorStyles.popup))
                {
                    _optionSearchProvider.Load("Add Option", options, x =>
                    {
                        _optionCatalogue.AddOption(x);
                    });

                    SearchWindow.Open(new SearchWindowContext(GUIUtility.GUIToScreenPoint(lastRect.position)), _optionSearchProvider);
                }
                EditorGUILayout.EndHorizontal();

                var arraySize = _optionsProperty.arraySize;
                for (var i = 0; i < arraySize; i++)
                {
                    var arrayElement = _optionsProperty.GetArrayElementAtIndex(i);
                    var category = arrayElement.managedReferenceValue.GetType().GetCategory();

                    EditorGUILayout.BeginHorizontal("box");
                    {
                        EditorGUILayout.BeginVertical();

                        var style = new GUIStyle(GUI.skin.label);
                        style.richText = true;
                        style.fontStyle = FontStyle.Bold;
                        EditorGUILayout.LabelField($@"#{i} {category}", style);

                        arrayElement.Next(true);
                        EditorGUILayout.PropertyField(arrayElement, true);

                        GUILayout.EndVertical();
                    }
                    {
                        EditorGUILayout.BeginVertical(GUILayout.Width(20));

                        GUILayout.FlexibleSpace();

                        if (GUILayout.Button("\u2715", GUILayout.Width(20), GUILayout.Height(20)))
                        {
                            _optionCatalogue.Options.RemoveAt(i);
                        }

                        GUILayout.FlexibleSpace();

                        GUILayout.EndVertical();
                    }
                    EditorGUILayout.EndHorizontal();
                }

                EditorGUI.indentLevel--;
            }

            _optionsProperty.serializedObject.ApplyModifiedProperties();

            EditorGUI.EndProperty();
        }
    }
}
