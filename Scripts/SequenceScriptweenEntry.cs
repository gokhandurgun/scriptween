using System;
using UnityEngine.Events;

namespace Scriptweener
{
    [Serializable]
    public class SequenceScriptweenEntry
    {
        public SequenceScriptweenEntryMethod EntryMethod;

        public ScriptweenEntry Scriptween;

        public float AtPosition;
        
        public float Interval;

        public UnityEvent Callback;

#if UNITY_EDITOR
        public bool IsScriptweenShown()
        {
            return EntryMethod == SequenceScriptweenEntryMethod.Append
                   || EntryMethod == SequenceScriptweenEntryMethod.Prepend
                   || EntryMethod == SequenceScriptweenEntryMethod.Join
                   || EntryMethod == SequenceScriptweenEntryMethod.Insert;
        }

        public bool IsAtPositionShown()
        {
            return EntryMethod == SequenceScriptweenEntryMethod.Insert
                   || EntryMethod == SequenceScriptweenEntryMethod.InsertCallback;
        }

        public bool IsIntervalShown()
        {
            return EntryMethod == SequenceScriptweenEntryMethod.AppendInterval
                   || EntryMethod == SequenceScriptweenEntryMethod.PrependInterval;
        }

        public bool IsCallbackShown()
        {
            return EntryMethod == SequenceScriptweenEntryMethod.AppendCallback
                   || EntryMethod == SequenceScriptweenEntryMethod.InsertCallback
                   || EntryMethod == SequenceScriptweenEntryMethod.PrependCallback;
        }
#endif
    }
}