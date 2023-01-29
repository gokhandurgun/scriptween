using System;
using System.ComponentModel;
using DG.Tweening;

namespace Scriptweener
{    
    [Category("Set Speed Based")]
    [Description("Set Speed Based")]
    [Serializable]
    public class SetSpeedBasedOption : BaseScriptweenMethodOption
    {
        public bool IsSpeedBased;

        public override void Apply(Tween tween)
        {
            tween.SetSpeedBased(IsSpeedBased);
        }
    }
}