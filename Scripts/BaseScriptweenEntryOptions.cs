using System;
using UnityEngine;
using DG.Tweening;

namespace Scriptweener
{
    [Serializable]
    public class BaseScriptweenEntryOptions
    {
        public virtual Tween PlayTween(IScriptween scriptween) => null;

        protected virtual bool Update(IScriptween scriptween) => false;

        public static BaseScriptweenEntryOptions Create(IScriptween scriptween, BaseScriptweenEntryOptions options = null)
        {
            if (options != null)
            {
                if (options.Update(scriptween))
                {
                    return options;
                }
            }

            if (scriptween is Scriptween s)
            {
                return new ScriptweenEntryOptions(s.GetTargetType());
            }
            else if (scriptween is SequenceScriptween sequenceScriptween)
            {
                return new SequenceScriptweenEntryOptions();
            }

            return null;
        }
    }

}
