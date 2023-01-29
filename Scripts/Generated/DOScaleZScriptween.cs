using System;
using UnityEngine;
using DG.Tweening;
using DG.Tweening.Plugins.Core.PathCore;

namespace Scriptweener
{
    [System.ComponentModel.Description("DOScaleZ")]
    [MethodDefinition("DOScaleZ", typeof(ShortcutExtensions), typeof(Transform), typeof(Single), typeof(Single))]
    [Serializable]
    public class DOScaleZScriptween : BaseScriptweenMethod
    {
        public Single endValue;
        public Single duration;
    }
}