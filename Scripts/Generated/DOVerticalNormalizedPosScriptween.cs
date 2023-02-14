using System;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using DG.Tweening.Plugins.Core.PathCore;

namespace Scriptweener
{
    [System.ComponentModel.Description("DOVerticalNormalizedPos")]
    [MethodDefinition("DOVerticalNormalizedPos", typeof(DOTweenModuleUI), typeof(ScrollRect), typeof(Single), typeof(Single), typeof(Boolean))]
    [Serializable]
    public class DOVerticalNormalizedPosScriptween : BaseScriptweenMethod
    {
        public Single endValue;
        public Single duration;
        public Boolean snapping;
    }
}