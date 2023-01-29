using System;
using UnityEngine;
using DG.Tweening;
using DG.Tweening.Plugins.Core.PathCore;

namespace Scriptweener
{
    [System.ComponentModel.Description("DOTime")]
    [MethodDefinition("DOTime", typeof(ShortcutExtensions), typeof(TrailRenderer), typeof(Single), typeof(Single))]
    [Serializable]
    public class DOTimeScriptween : BaseScriptweenMethod
    {
        public Single endValue;
        public Single duration;
    }
}