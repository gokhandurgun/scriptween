using System;
using System.Linq;
using System.Reflection;
using Sirenix.OdinInspector.Editor;
using UnityEditor;
using UnityEngine;

namespace Scriptweener.Editor
{
    public class ScriptweenTargetObjectAttributeDrawer : OdinAttributeDrawer<ScriptweenTargetObjectAttribute, UnityEngine.Object>
    {
        private PropertyInfo m_PropertyInfo;
        private FieldInfo m_FieldInfo;
        
        protected override void Initialize()
        {
            var hostType = this.Property.Parent.ValueEntry.TypeOfValue;
            var members = hostType.GetMember(this.Attribute.TypeProvider);
            
            PropertyInfo propertyInfo = null;
            FieldInfo fieldInfo = null;
            if (members.Length == 1)
            {
                if ((members[0].MemberType & MemberTypes.Property) != 0)
                {
                    propertyInfo = members[0] as PropertyInfo;
                }
                else if ((members[0].MemberType & MemberTypes.Field) != 0)
                {
                    fieldInfo = members[0] as FieldInfo;
                }
            }

            m_PropertyInfo = propertyInfo;
            m_FieldInfo = fieldInfo;
        }

        protected override void DrawPropertyLayout(GUIContent label)
        {
            var obj = this.Property.Parent.ValueEntry.WeakSmartValue;
            ClassTypeReference targetType = null;
            if (m_PropertyInfo != null)
            {
                targetType = m_PropertyInfo.GetMethod.Invoke(obj, null) as ClassTypeReference;
            }
            else if (m_FieldInfo != null)
            {
                targetType = m_FieldInfo.GetValue(obj) as ClassTypeReference;
            }

            if (targetType != null)
            {
                Rect rect = EditorGUILayout.GetControlRect();

                if (label != null)
                {
                    rect = EditorGUI.PrefixLabel(rect, label);
                }
                
                this.ValueEntry.SmartValue = 
                    EditorGUI.ObjectField(rect, this.ValueEntry.SmartValue, targetType.Type, true);
            }
        }
    }
}