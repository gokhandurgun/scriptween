using System;
using UnityEngine;
using DG.Tweening;
using DG.Tweening.Plugins.Core.PathCore;

namespace Scriptweener
{
    [System.ComponentModel.Description("DOPixelRect")]
    [MethodDefinition("DOPixelRect", typeof(ShortcutExtensions), typeof(Camera), typeof(Rect), typeof(Single))]
    [Serializable]
    public class DOPixelRectScriptween : BaseScriptweenMethod
    {
        public Rect endValue;
        public Single duration;
    }
}