using System;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using DG.Tweening.Plugins.Core.PathCore;

namespace Scriptweener
{
    [System.ComponentModel.Description("DOPivotX")]
    [MethodDefinition("DOPivotX", typeof(DOTweenModuleUI), typeof(RectTransform), typeof(Single), typeof(Single))]
    [Serializable]
    public class DOPivotXScriptween : BaseScriptweenMethod
    {
        public Single endValue;
        public Single duration;
    }
}