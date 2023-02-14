using System;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using DG.Tweening.Plugins.Core.PathCore;

namespace Scriptweener
{
    [System.ComponentModel.Description("DOOrthoSize")]
    [MethodDefinition("DOOrthoSize", typeof(ShortcutExtensions), typeof(Camera), typeof(Single), typeof(Single))]
    [Serializable]
    public class DOOrthoSizeScriptween : BaseScriptweenMethod
    {
        public Single endValue;
        public Single duration;
    }
}