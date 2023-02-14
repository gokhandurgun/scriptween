using System;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using DG.Tweening.Plugins.Core.PathCore;

namespace Scriptweener
{
    [System.ComponentModel.Description("DOScaleX")]
    [MethodDefinition("DOScaleX", typeof(ShortcutExtensions), typeof(Transform), typeof(Single), typeof(Single))]
    [Serializable]
    public class DOScaleXScriptween : BaseScriptweenMethod
    {
        public Single endValue;
        public Single duration;
    }
}