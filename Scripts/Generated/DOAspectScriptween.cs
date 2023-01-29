using System;
using UnityEngine;
using DG.Tweening;
using DG.Tweening.Plugins.Core.PathCore;

namespace Scriptweener
{
    [System.ComponentModel.Description("DOAspect")]
    [MethodDefinition("DOAspect", typeof(ShortcutExtensions), typeof(Camera), typeof(Single), typeof(Single))]
    [Serializable]
    public class DOAspectScriptween : BaseScriptweenMethod
    {
        public Single endValue;
        public Single duration;
    }
}