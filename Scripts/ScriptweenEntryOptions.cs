using System;
using DG.Tweening;
using UnityEngine;

namespace Scriptweener
{
    [Serializable]
    public class ScriptweenEntryOptions : BaseScriptweenEntryOptions
    {
        [SerializeField]
        [HideInInspector]
        private ClassTypeReference m_TargetType;
        public ClassTypeReference TargetType
        {
            get
            {
                return m_TargetType;
            }
            set
            {
                if (m_TargetType?.Type == value?.Type) return;
                m_TargetType = value;
                Target = null;
            }
        }

        [ScriptweenTargetObject(nameof(TargetType))]
        public UnityEngine.Object Target;

        private Scriptween m_CachedScriptween;

        public ScriptweenEntryOptions()
        {
            
        }
        
        public ScriptweenEntryOptions(Type targetType)
        {
            TargetType = targetType;
        }

        protected override bool Update(IScriptween scriptween)
        {
            if (scriptween is Scriptween s)
            {
                TargetType = s.GetTargetType();
                return true;
            }

            return false;
        }

        public override Tween PlayTween(IScriptween scriptween)
        {
            if (m_CachedScriptween != scriptween)
            {
                m_CachedScriptween = scriptween as Scriptween;
            }

            if (m_CachedScriptween == null) return null;
            return m_CachedScriptween.Play(Target);
        }

    }
}