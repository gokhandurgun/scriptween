using System;
using System.ComponentModel;
using DG.Tweening;

namespace Scriptweener
{
    [Category("Set Loops")]
    [Description("Set Loops")]
    [Serializable]
    public class SetLoopsOption : BaseScriptweenMethodOption
    {
        public int Count;

        public LoopType LoopType;
        
        public override void Apply(Tween tween)
        {
            tween.SetLoops(Count, LoopType);
        }
    }
}