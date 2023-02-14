using System;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using DG.Tweening.Plugins.Core.PathCore;

namespace Scriptweener
{
    [System.ComponentModel.Description("DOPivotY")]
    [MethodDefinition("DOPivotY", typeof(DOTweenModuleUI), typeof(RectTransform), typeof(Single), typeof(Single))]
    [Serializable]
    public class DOPivotYScriptween : BaseScriptweenMethod
    {
        public Single endValue;
        public Single duration;
    }
}