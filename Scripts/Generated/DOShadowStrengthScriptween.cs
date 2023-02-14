using System;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using DG.Tweening.Plugins.Core.PathCore;

namespace Scriptweener
{
    [System.ComponentModel.Description("DOShadowStrength")]
    [MethodDefinition("DOShadowStrength", typeof(ShortcutExtensions), typeof(Light), typeof(Single), typeof(Single))]
    [Serializable]
    public class DOShadowStrengthScriptween : BaseScriptweenMethod
    {
        public Single endValue;
        public Single duration;
    }
}