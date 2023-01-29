using System.Reflection;
using UnityEditor;
using UnityEngine;

namespace Scriptweener.Editor
{
    [CustomPropertyDrawer(typeof(ScriptweenTargetObjectAttribute), true)]
    public class ScriptweenTargetObjectAttributeDrawer : NestablePropertyDrawer
    {
        private PropertyInfo m_PropertyInfo;
        private FieldInfo m_FieldInfo;

        protected override void OnEnable(SerializedProperty property)
        {
            base.OnEnable(property);

            var a = attribute as ScriptweenTargetObjectAttribute;

            var hostType = _currentPropertyParentObject.GetType();
            var members = hostType.GetMember(a.TypeProvider);

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

        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            base.OnGUI(position, property, label);

            var obj = _currentPropertyParentObject;
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
                property.objectReferenceValue = 
                    EditorGUI.ObjectField(position, label, property.objectReferenceValue, targetType.Type, true);
            }
        }
    }
}