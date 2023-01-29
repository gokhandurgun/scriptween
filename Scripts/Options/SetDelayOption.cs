using System;
using System.ComponentModel;
using DG.Tweening;

namespace Scriptweener
{
    [Category("Set Delay")]
    [Description("Set Delay")]
    [Serializable]
    public class SetDelayOption : BaseScriptweenMethodOption
    {
        public float Duration;

        public override void Apply(Tween tween)
        {
            tween.SetDelay(Duration);
        }
    }
}