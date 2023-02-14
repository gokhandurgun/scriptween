using System;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using DG.Tweening.Plugins.Core.PathCore;

namespace Scriptweener
{
    [System.ComponentModel.Description("DOIntensity")]
    [MethodDefinition("DOIntensity", typeof(ShortcutExtensions), typeof(Light), typeof(Single), typeof(Single))]
    [Serializable]
    public class DOIntensityScriptween : BaseScriptweenMethod
    {
        public Single endValue;
        public Single duration;
    }
}