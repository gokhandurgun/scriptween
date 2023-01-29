using System;
using System.ComponentModel;
using DG.Tweening;

namespace Scriptweener
{
    [Category("Set Id")]
    [Description("Set Id")]
    [Serializable]
    public class SetIdOption : BaseScriptweenMethodOption
    {
        public int Id;

        public override void Apply(Tween tween)
        {
            tween.SetId(Id);
        }
    }
}