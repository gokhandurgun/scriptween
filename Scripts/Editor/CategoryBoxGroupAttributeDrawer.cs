using System;
using System.ComponentModel;
using Sirenix.OdinInspector.Editor;
using Sirenix.Utilities.Editor;
using UnityEngine;

namespace Scriptweener.Editor
{
    public class CategoryBoxGroupAttributeDrawer<T> : OdinAttributeDrawer<CategoryBoxGroupAttribute, T>
    {
        private string m_Title;
        
        protected override void Initialize()
        {
            m_Title = this.Property.ValueEntry.TypeOfValue.GetCategory();
        }

        protected override void DrawPropertyLayout(GUIContent label)
        {
            SirenixEditorGUI.BeginBox(m_Title);
            this.CallNextDrawer(label);
            SirenixEditorGUI.EndBox();
        }
        
    }
}