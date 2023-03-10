using System;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using DG.Tweening.Plugins.Core.PathCore;

namespace Scriptweener
{
    [System.ComponentModel.Description("DORect")]
    [MethodDefinition("DORect", typeof(ShortcutExtensions), typeof(Camera), typeof(Rect), typeof(Single))]
    [Serializable]
    public class DORectScriptween : BaseScriptweenMethod
    {
        public Rect endValue;
        public Single duration;
    }
}