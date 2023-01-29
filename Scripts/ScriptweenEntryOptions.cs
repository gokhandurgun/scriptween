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
        private ClassTypeReference _targetType;
        public ClassTypeReference TargetType
        {
            get
            {
                return _targetType;
            }
            set
            {
                if (_targetType?.Type == value?.Type) return;
                _targetType = value;
                Target = null;
            }
        }

        [ScriptweenTargetObject(nameof(TargetType))]
        public UnityEngine.Object Target;

        private Scriptween _cachedScriptween;

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
            if (_cachedScriptween != scriptween)
            {
                _cachedScriptween = scriptween as Scriptween;
            }

            if (_cachedScriptween == null) return null;
            return _cachedScriptween.Play(Target);
        }

    }
}