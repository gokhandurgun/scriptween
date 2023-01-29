using System;
using UnityEngine;
using DG.Tweening;
using DG.Tweening.Plugins.Core.PathCore;

namespace Scriptweener
{
    [System.ComponentModel.Description("DOTimeScale")]
    [MethodDefinition("DOTimeScale", typeof(ShortcutExtensions), typeof(Tween), typeof(Single), typeof(Single))]
    [Serializable]
    public class DOTimeScaleScriptween : BaseScriptweenMethod
    {
        public Single endValue;
        public Single duration;
    }
}