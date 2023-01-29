using System;
using System.ComponentModel;
using DG.Tweening;

namespace Scriptweener
{
    [Category("Set Relative")]
    [Description("Set Relative")]
    [Serializable]
    public class SetRelativeOption : BaseScriptweenMethodOption
    {
        public bool IsRelative;

        public override void Apply(Tween tween)
        {
            tween.SetRelative(IsRelative);
        }
    }
}