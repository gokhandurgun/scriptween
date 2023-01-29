using System;
using DG.Tweening;
using UnityEngine;

namespace Scriptweener
{
    [Serializable]
    public class SequenceScriptweenEntryOptions : BaseScriptweenEntryOptions
    {
        private SequenceScriptween m_CachedScriptween;
        
        protected override bool Update(IScriptween scriptween)
        {
            return true;
        }

        public override Tween PlayTween(IScriptween scriptween)
        {
            if (m_CachedScriptween != scriptween)
            {
                m_CachedScriptween = scriptween as SequenceScriptween;
            }

            if (m_CachedScriptween == null) return null;
            return m_CachedScriptween.Play();
        }
    }
}