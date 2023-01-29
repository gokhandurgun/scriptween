using System;
using UnityEngine;
using DG.Tweening;
using DG.Tweening.Plugins.Core.PathCore;

namespace Scriptweener
{
    [System.ComponentModel.Description("DOResize")]
    [MethodDefinition("DOResize", typeof(ShortcutExtensions), typeof(TrailRenderer), typeof(Single), typeof(Single), typeof(Single))]
    [Serializable]
    public class DOResizeScriptween : BaseScriptweenMethod
    {
        public Single toStartWidth;
        public Single toEndWidth;
        public Single duration;
    }
}