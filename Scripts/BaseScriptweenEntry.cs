using System;
using UnityEngine;

namespace Scriptweener
{
    [Serializable]
    public class BaseScriptweenEntry<T> : IBaseScriptweenEntry
        where T : IScriptween
    {
        [SerializeReference]
        public T Scriptween;

        //TODO: Check saved
        //TODO: Check public fields
        [SerializeReference]
        public BaseScriptweenEntryOptions EntryOptions;

        public IScriptween GetScriptween() => Scriptween;

        public BaseScriptweenEntryOptions GetEntryOptions() => EntryOptions;

#if UNITY_EDITOR
        public void ScriptweenChanged()
        {
            if (Scriptween == null)
            {
                EntryOptions = null;
            }
            else
            {
                EntryOptions = BaseScriptweenEntryOptions.Create(Scriptween, EntryOptions);
            }
        }
#endif
    }
}
