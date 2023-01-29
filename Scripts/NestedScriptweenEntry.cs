using System;

namespace Scriptweener
{
    [Serializable]
    public class NestedScriptweenEntry : BaseScriptweenEntry<SequenceScriptween>
    {
        public NestedScriptweenEntry()
        {
            Scriptween = new SequenceScriptween();
        }
    }
}
