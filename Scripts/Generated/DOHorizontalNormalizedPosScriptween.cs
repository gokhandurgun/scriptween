using System;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using DG.Tweening.Plugins.Core.PathCore;

namespace Scriptweener
{
    [System.ComponentModel.Description("DOHorizontalNormalizedPos")]
    [MethodDefinition("DOHorizontalNormalizedPos", typeof(DOTweenModuleUI), typeof(ScrollRect), typeof(Single), typeof(Single), typeof(Boolean))]
    [Serializable]
    public class DOHorizontalNormalizedPosScriptween : BaseScriptweenMethod
    {
        public Single endValue;
        public Single duration;
        public Boolean snapping;
    }
}