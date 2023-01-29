using System;
using DG.Tweening;
using UnityEngine;

namespace Scriptweener
{
    [Serializable]
    public class SequenceScriptweenEntryOptions : BaseScriptweenEntryOptions
    {
        private SequenceScriptween _cachedScriptween;
        
        protected override bool Update(IScriptween scriptween)
        {
            return true;
        }

        public override Tween PlayTween(IScriptween scriptween)
        {
            if (_cachedScriptween != scriptween)
            {
                _cachedScriptween = scriptween as SequenceScriptween;
            }

            if (_cachedScriptween == null) return null;
            return _cachedScriptween.Play();
        }
    }
}