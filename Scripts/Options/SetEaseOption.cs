using System;
using System.ComponentModel;
using DG.Tweening;
using UnityEngine;

namespace Scriptweener
{
    [Category("Set Ease")]
    [Description("Set Ease<Animation Curve>")]
    [Serializable]
    public class SetEase1Option : BaseScriptweenMethodOption
    {
        public AnimationCurve Curve;
        
        public override void Apply(Tween tween)
        {
            tween.SetEase(Curve);
        }
    }
    
    [Category("Set Ease")]
    [Description("Set Ease<Ease>")]
    [Serializable]
    public class SetEase2Option: BaseScriptweenMethodOption
    {
        public Ease Ease;

        public override void Apply(Tween tween)
        {
            tween.SetEase(Ease);
        }
    }
}