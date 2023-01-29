using System;
using UnityEngine;
using DG.Tweening;
using DG.Tweening.Plugins.Core.PathCore;

namespace Scriptweener
{
    [System.ComponentModel.Description("DOScaleY")]
    [MethodDefinition("DOScaleY", typeof(ShortcutExtensions), typeof(Transform), typeof(Single), typeof(Single))]
    [Serializable]
    public class DOScaleYScriptween : BaseScriptweenMethod
    {
        public Single endValue;
        public Single duration;
    }
}