using System;
using UnityEngine;
using DG.Tweening;
using DG.Tweening.Plugins.Core.PathCore;

namespace Scriptweener
{
    [System.ComponentModel.Description("DOFieldOfView")]
    [MethodDefinition("DOFieldOfView", typeof(ShortcutExtensions), typeof(Camera), typeof(Single), typeof(Single))]
    [Serializable]
    public class DOFieldOfViewScriptween : BaseScriptweenMethod
    {
        public Single endValue;
        public Single duration;
    }
}