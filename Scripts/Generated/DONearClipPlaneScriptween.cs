using System;
using UnityEngine;
using DG.Tweening;
using DG.Tweening.Plugins.Core.PathCore;

namespace Scriptweener
{
    [System.ComponentModel.Description("DONearClipPlane")]
    [MethodDefinition("DONearClipPlane", typeof(ShortcutExtensions), typeof(Camera), typeof(Single), typeof(Single))]
    [Serializable]
    public class DONearClipPlaneScriptween : BaseScriptweenMethod
    {
        public Single endValue;
        public Single duration;
    }
}